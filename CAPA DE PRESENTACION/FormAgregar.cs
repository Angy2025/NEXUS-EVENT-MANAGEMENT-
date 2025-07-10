using CAPA_DE_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioDetalle : Form
    {
        #region de Campos y Propiedades


        // Instancia de la capa de negocios para interactuar con la lógica de eventos
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();

        private readonly ConfingeventosDetalle _configDetalle = new ConfingeventosDetalle();

        // Almacena el evento que se está editando. Si es null, significa que estamos en modo "Agregar"
        private EventoBase _eventoAEditar = null;

        #endregion



        #region Constructores y Carga del Formulario
        public FormularioDetalle()
        {
            InitializeComponent();
            this.Text = "Agregar Nuevo Evento";
        }

        // Constructor para el modo "Modificar"
        public FormularioDetalle(EventoBase eventoParaEditar) : this() //Llama al constructor base primero
        {
            this.Text = "Modificar Evento";
            _eventoAEditar = eventoParaEditar; // Guardamos la referencia al evento que vamos a editar
        }

        private void FormularioDetalle_Load(object sender, EventArgs e)
        {
            ConfigurarComboBox();

            // Si estamos en modo "Modificar", llena los campos con los datos del evento
            if (_eventoAEditar != null)
            {
                CargarDatos();
            }
        }
        #endregion






        #region Metodos de Configuración
        private void CargarDatos()
        {
            // Asignamos los datos del objeto a los controles del formulario
            textName.Text = _eventoAEditar.Nombre;
            textPlace.Text = _eventoAEditar.Lugar;
            dateTimePicker.Value = _eventoAEditar.FechaHora; // Combinamos la fecha y la hora para establecer correctamente el DateTimePicker
            CBType.SelectedItem = _eventoAEditar.Categoria;
            numericUpDown1.Value = _eventoAEditar.Capacidad;
        }
        private void ConfigurarComboBox()
        {
            // El formulario no conoce la lista de categorías, solo se la pide a la capa de negocios.
            CBType.DataSource = _configDetalle.ObtenerCategoriasDisponibles();
        }
        #endregion






        #region Eventos de Controles

        //Se ejecuta al hacer clic en el botón Guardar

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO Requisito: Validación de Datos/campos
                if (string.IsNullOrWhiteSpace(textName.Text)) 
                {
                    MessageBox.Show("El nombre y el tipo del evento son obligatorios.", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Creación o Actualización del Objeto, si estamos en modo "Agregar" (_eventoAEditar es null), creamos un nuevo objeto
                
                if (_eventoAEditar == null)
                {
                    // Si estamos en modo "Agregar", le pedimos a la capa de negocios que cree el objeto por nosotros

                    string tipoSeleccionado = CBType.SelectedItem.ToString();
                    _eventoAEditar = _configDetalle.CrearEventoPorTipo(tipoSeleccionado);
                }
                //Recolección de Datos del Formulario 
                _eventoAEditar.Nombre = textName.Text;
                _eventoAEditar.Lugar = textPlace.Text;
                _eventoAEditar.FechaHora = dateTimePicker.Value; 
                _eventoAEditar.Categoria = CBType.SelectedItem.ToString();
                _eventoAEditar.Capacidad = (int)numericUpDown1.Value;

                // Le pasamos el objeto al manager para que lo guarde (agrega o modifica)
                _eventosManager.AddEvent(_eventoAEditar);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
