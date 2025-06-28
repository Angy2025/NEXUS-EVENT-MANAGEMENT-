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
using System.Runtime.CompilerServices;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioDetalle : Form
    {
        private EventoBase _eventoAEditar = null;
        private CRUD _crud = new CRUD();
        private CN_EventosManager _eventosManager;

        //Constructor para agregar nuevo evento
        public FormularioDetalle()
        {
            InitializeComponent();
            this.Text = "Agregar Evento";
            _crud = new CRUD();
            _eventosManager = new CN_EventosManager(_crud);
        }

        //Constructor para modificar un evento existente
        public FormularioDetalle(EventoBase eventoParaEditar) : this()
        {
            this.Text = "Modificar Evento";
            _eventoAEditar = eventoParaEditar;
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (_eventoAEditar != null)
            {
                textBox1.Text = _eventoAEditar.Nombre;
                textBox2.Text = _eventoAEditar.Lugar;
                dateTimePicker1.Value = _eventoAEditar.Fecha;
                comboBox1.SelectedItem = _eventoAEditar.Tipo;
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
                _eventoAEditar.Nombre = textBox1.Text;
                _eventoAEditar.Lugar = textBox2.Text;
                _eventoAEditar.Fecha = dateTimePicker1.Value;
                _eventoAEditar.Tipo = comboBox1.SelectedItem.ToString();
                _eventoAEditar.Capacidad = (int)numericUpDown1.Value;

                //Le pasamos el objeto al manager de negocios para que aplique
                // las reglas y lo guarde (ya sea como nuevo o como modificación)

                _eventosManager.GuardarEvento(_eventoAEditar);

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
    }
}
