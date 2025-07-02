using CAPA_DE_NEGOCIOS;
using CapaDatos;
using System;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioDetalle : Form
    {
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();

        private EventoBase _eventoAEditar = null; // Evento que se va a editar, si es que existe

        public FormularioDetalle()
        {
            InitializeComponent();
        }

        // Este constructor se llama cuando se le pasa un evento existente desde la tabla principal
        public FormularioDetalle(EventoBase eventoParaEditar) : this()
        {
            this.Text = "Modificar Evento";
            _eventoAEditar = eventoParaEditar; // Guardamos la referencia al evento que vamos a editar
            CargarDatos(); // Llamamos al método para llenar los campos del formulario
        }
        private void CargarDatos()
        {
            if (_eventoAEditar != null)
            {
                // Asignamos los datos del objeto a los controles del formulario
                textName.Text = _eventoAEditar.Nombre;
                textPlace.Text = _eventoAEditar.Lugar;
                dateTimePicker.Value = _eventoAEditar.Fecha;
                CBType.SelectedItem = _eventoAEditar.Tipo;
                numericUpDown1.Value = _eventoAEditar.Capacidad;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormularioDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la aplicación: {ex.Message}", "Error de Arranque", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si estamos en modo crear, creamos un evento nuevo
                if (_eventoAEditar == null)
                {
                    //Evento generico para agregar
                    _eventoAEditar = new Cultural(); // Cambia esto según el tipo de evento que quieras agregar
                }

                //Recolectar los datos del formulario y ponerlos en el objeto
                _eventoAEditar.Nombre = textName.Text;
                _eventoAEditar.Lugar = textPlace.Text;
                _eventoAEditar.Fecha = dateTimePicker.Value;
                _eventoAEditar.Tipo = CBType.SelectedItem.ToString();
                _eventoAEditar.Capacidad = (int)numericUpDown1.Value;

                //Le pasamos el objeto al manager de negocios para que aplique
                // las reglas y lo guarde (ya sea como nuevo o como modificación)

                _eventosManager.AddEvent(_eventoAEditar);

                //Le indicamos al formulario que se guardó correctamente
                this.DialogResult = DialogResult.OK;
                this.Close(); // Cerramos el formulario de Detalles
            }
            catch (Exception ex)
            {
                //Si hubo un error, mostramos un mensaje al usuario
                MessageBox.Show($"Error al guardar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Si el usuario cancela, simplemente cerramos el formulario sin guardar nada
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CBType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurarComboBox()
        {
            CBType.Items.Clear();
            CBType.Items.Add("Deportivo");
            CBType.Items.Add("Cultural");
            CBType.Items.Add("Tecnológico");
            CBType.Items.Add("Cinematográfico");
            CBType.Items.Add("Profesional");
        }
    }
}
