using CAPA_DE_NEGOCIOS;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioGestion : Form
    {
        //Creamos un puente con la capa de negocios que todo el formulario utilizara
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();

        private List<EventoBase> _listaCompletaDeEventos;

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
                MessageBox.Show($"Error CRÍTICO al iniciar la aplicación: {ex.Message}", "Error de Arranque", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }


        private void ConfigurarComboBox()
        {
            // Asumo que tu control se llama 'comBox'.
            comBox.Items.Clear();
            comBox.Items.Add("Todos");
            comBox.Items.Add("Deportivo");
            comBox.Items.Add("Cultural");
            comBox.Items.Add("Tecnológico");
            comBox.Items.Add("Cinematográfico");
            comBox.Items.Add("Profesional");
            comBox.SelectedIndex = 0;
        }



        //Metodo para cargar y refrescar la tabla de eventos
        private void CargarEventos()
        {
            // Obtenemos la lista completa de la base de datos y la guardamos en nuestra variable de clase.
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


        private void AplicarFiltros()
        {
            if (_listaCompletaDeEventos == null || comBox.SelectedItem == null)
            {
                return;
            }


            List<EventoBase> listaFiltrada = _listaCompletaDeEventos;

            //FILTRO POR TIPO (ComboBox)
            string tipoSeleccionado = comBox.SelectedItem.ToString();
            if (tipoSeleccionado != "Todos")
            {
                listaFiltrada = listaFiltrada.Where(evento => evento.Tipo == tipoSeleccionado).ToList();

            }


            //FILTRO POR NOMBRE (TextBox de Búsqueda)
            string textoBusqueda = textBox1.Text.Trim(); // .Trim() quita espacios en blanco al inicio y al final.
            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                // Si el usuario ha escrito algo en el cuadro de búsqueda, filtramos la lista que ya podría estar filtrada por tipo
                listaFiltrada = listaFiltrada
                    .Where(evento => evento.Nombre.ToLower().Contains(textoBusqueda.ToLower())) // ToLower() hace que la búsqueda no distinga mayúsculas/minúsculas.
                    .ToList();
            }


            // Finalmente actualizamos, asignamos la lista (ya sea completa, filtrada por tipo, o filtrada por tipo y nombre) al dgv2
            dgv2.DataSource = null;
            dgv2.DataSource = listaFiltrada;
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
            //validamos que haya una fila seleccionada
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

        }
    }
}
