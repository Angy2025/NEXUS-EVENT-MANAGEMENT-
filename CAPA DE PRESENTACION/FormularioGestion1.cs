using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CAPA_DE_NEGOCIOS;


namespace CAPA_DE_PRESENTACION
{
    public partial class frmGestionEventos : Form
    {
        // El formulario guarda una referencia al Gerente de Negocios
        private CN_EventosManager _eventosManager;
        public frmGestionEventos()
        {
            InitializeComponent();

            //Creamos el objeto de la Capa de Datos que habla con SQL.
            CRUD manejadorDeDatos = new CRUD();

            // 2. Creamos el objeto de la Capa de Negocios y le "pasamos" el objeto de datos.
            // Así, el Manager puede dar órdenes sin saber los detalles de SQL.
            _eventosManager = new CN_EventosManager(manejadorDeDatos);
        }

        private void FormularioPrincpal_Load(object sender, EventArgs e)
        {
            CargarEventos();
        }

        //MÉTODO PARA CARGAR Y REFRESCAR LA TABLA
        private void CargarEventos()
        {
            try
            {
                // Le pedimos al Manager la lista de eventos. El Manager se encargará del resto
                // Asignamos la lista de objetos al DataSource del DataGridView
                // El DataGridView mostrará automáticamente las propiedades públicas de los objetos
                dgv2.DataSource = _eventosManager.ObtenerTodosLosEventos();
            }
            catch (Exception ex)
            {
                // Si ocurre un error (ej. no se puede conectar a la BD), mostramos un mensaje.
                MessageBox.Show($"Ocurrió un error al cargar los eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarEvent()
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionEventos_Load(object sender, EventArgs e)
        {

        }

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FormularioDetalle frmDetalle = new FormularioDetalle();
            if (frmDetalle.ShowDialog() == DialogResult.OK)
            {
                // El usuario hizo clic en "Guardar",
                // así que refrescamos la tabla para ver el nuevo evento
                CargarEventos();
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            //validamos que haya una fila seleccionada
            if (dgv2.SelectedRows.Count > 0)
            {
                //Obtenemos el evento seleccionado
                EventoBase EditEvento = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;

                //Abrimos el formulario de detalles, pasandole el evento a editar
                FormularioDetalle frmDetalle = new FormularioDetalle(EditEvento);
                if (frmDetalle.ShowDialog() == DialogResult.OK)
                {
                    // Si el usuario guardo, se refresca la tabla nuevamente
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
                // Obtenemos los datos del evento para mostrar un mensaje
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
                        CargarEventos(); // Refrescamos la tabla
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
    }
}
