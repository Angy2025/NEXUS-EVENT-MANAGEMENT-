using CAPA_DE_NEGOCIOS;
using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioGestion : Form
    {
        SqlConnection connection = new SqlConnection("Server=.;Database=Nexus;Integrated Security=true" + " ;TrustServerCertificate=True;"); //
        SqlDataAdapter adapt;
        //Creamos un puente con la capa de negocios que todo el formulario utilizara

        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();

        //  public List<EventoBase> _listaCompletaDeEventos;

        public FormularioGestion()
        {
            InitializeComponent();
        }



        private void FormularioPrincpal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarEventos();
                ConfigurarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la aplicación: {ex.Message}", "Error de Arranque", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Método para configurar el ComboBox con los tipos de eventos
        private void ConfigurarComboBox()
        {
            comBox.Items.Clear();
            comBox.Items.Add("Todos");
            comBox.Items.Add("Deportivo");
            comBox.Items.Add("Cultural");
            comBox.Items.Add("Tecnológico");
            comBox.Items.Add("Cinematográfico");
            comBox.Items.Add("Profesional");
            comBox.SelectedIndex = 0; //Seleccionamos "Todos" por defecto, inicalizandose en 0 
        }



        //Metodo para cargar y refrescar la tabla de eventos
        private void CargarEventos()
        {
            // Obtenemos la lista completa de la base de datos y la guardamos en nuestra variable de clase
            _listaCompletaDeEventos = _eventosManager.ObtainAllEvents();

            // Limpiamos los filtros y mostramos todos los eventos en la tabla
            if (comBox.Items.Count > 0) comBox.SelectedIndex = 0;
            textBox1.Clear();
            dgv2.DataSource = _listaCompletaDeEventos;
        }



        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cada vez que el ComboBox cambia, aplicamos los filtros
            AplicarFiltros();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Cada vez que se hace clic en el botón de buscar, aplicamos los filtros
            AplicarFiltros();
        }





        private void btnagregar_Click(object sender, EventArgs e)
        {
            FormularioDetalle frmDetalle = new FormularioDetalle();
            if (frmDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarEventos();
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                //Obtenemos el eventoBase seleccionado
                EventoBase EditEvento = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;

                //Abrimos el formulario de detalles, pasandole el evento a editar
                FormularioDetalle frmDetalle = new FormularioDetalle(EditEvento);
                if (frmDetalle.ShowDialog() == DialogResult.OK)
                {
                    CargarEventos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un evento para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                // Obtenemos los datos nombre y Id del evento para mostrar un mensaje
                int id = (int)dgv2.SelectedRows[0].Cells["Id"].Value;
                string nombre = dgv2.SelectedRows[0].Cells["Nombre"].Value.ToString();

                // Mostramos el formulario de confirmación
                FormConfirmacion frmConfirmar = new FormConfirmacion(nombre);

                if (frmConfirmar.ShowDialog() == DialogResult.Yes)
                {
                    try
                    {
                        // Le damos la orden al Manager de eliminar el evento
                        _eventosManager.EliminarEvento(id);
                        MessageBox.Show("Evento eliminado con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEventos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un evento para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmGestionEventos_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Evento", connection);
            adapt.Fill(dt);
            dgv2.DataSource = dt;
            connection.Close();
        }


        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        private readonly string CadenaConexion = "Server=.;Database=Nexus;Integrated Security=true;TrustServerCertificate=True;";
        private List<EventoBase> _listaCompletaDeEventos; // Asegúrate que esta lista se carga correctamente

        private void AplicarFiltros()
        {
            // 1. Verificación inicial: Si la lista base no está cargada, no hacer nada.
            if (_listaCompletaDeEventos == null)
            {
                return;
            }

            // 2. Empezar siempre con la lista completa.
            IEnumerable<EventoBase> consultaFiltrada = _listaCompletaDeEventos;

            // 3. FILTRO POR TIPO (ComboBox)
            // Se comprueba que haya un item seleccionado y no sea la opción "Todos"
            if (comBox.SelectedItem != null)
            {
                string tipoSeleccionado = comBox.SelectedItem.ToString();

                // Si no es "Todos" (o como llames a tu opción para ver todo), aplicamos el filtro.
                // Usamos .Equals con StringComparison.OrdinalIgnoreCase para evitar problemas de mayúsculas/minúsculas.
                if (!tipoSeleccionado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
                {
                    consultaFiltrada = consultaFiltrada.Where(evento =>
                        evento.Tipo != null &&
                        evento.Tipo.Equals(tipoSeleccionado, StringComparison.OrdinalIgnoreCase));
                }
            }

            // 4. FILTRO POR NOMBRE (TextBox de Búsqueda)
            // Se encadena el filtro sobre el resultado anterior.
            string textoBusqueda = textBox1.Text.Trim();
            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                // Usamos ToLower() para una búsqueda insensible a mayúsculas/minúsculas.
                string textoBusquedaLower = textoBusqueda.ToLower();
                consultaFiltrada = consultaFiltrada.Where(evento =>
                    evento.Nombre != null &&
                    evento.Nombre.ToLower().Contains(textoBusquedaLower));
            }

            // 5. Actualizar el DataGridView con el resultado final.
            // Convertimos el resultado de la consulta (IEnumerable) a una Lista (List).
            dgv2.DataSource = null;
            dgv2.DataSource = consultaFiltrada.ToList();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
