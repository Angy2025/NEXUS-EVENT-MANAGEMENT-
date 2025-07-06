using CAPA_DE_NEGOCIOS;
using CapaDatos;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioDetalle : Form
    {
        #region de Campos y Propiedades


        // Instancia de la capa de negocios para interactuar con la lógica de eventos.
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();


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

            // Si estamos en modo "Modificar", llena los campos con los datos del evento.
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

            // Combinamos la fecha y la hora para establecer correctamente el DateTimePicker
            dateTimePicker.Value = _eventoAEditar.Fecha.Date + _eventoAEditar.Hora;

            CBType.SelectedItem = _eventoAEditar.Tipo;
            numericUpDown1.Value = _eventoAEditar.Capacidad;
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
        #endregion






        #region Eventos de Controles

        //Se ejecuta al hacer clic en el botón Guardar

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validación de Datos 
                if (string.IsNullOrWhiteSpace(textName.Text))
                {
                    MessageBox.Show("El nombre del evento es obligatorio.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                if (CBType.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de evento.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Creación o Actualización del Objeto, si estamos en modo "Agregar" (_eventoAEditar es null), creamos un nuevo objeto.

                if (_eventoAEditar == null)
                {
                    // Creamos la instancia correcta basándonos en la selección del ComboBox
                    string tipoSeleccionado = CBType.SelectedItem.ToString();
                    switch (tipoSeleccionado)
                    {
                        case "Deportivo": _eventoAEditar = new Deportivo();
                            break;
                        case "Cultural": _eventoAEditar = new Cultural(); 
                            break;
                        case "Tecnológico": _eventoAEditar = new Tecnologico();
                            break;
                        case "Cinematográfico": _eventoAEditar = new Cinematografico(); 
                            break;
                        case "Profesional": _eventoAEditar = new Profesional(); 
                            break;
                    }
                }

                //Recolección de Datos del Formulario 
                _eventoAEditar.Nombre = textName.Text;
                _eventoAEditar.Lugar = textPlace.Text;
                _eventoAEditar.Fecha = dateTimePicker.Value.Date; // Obtenemos solo la parte de la FECHA
                _eventoAEditar.Hora = dateTimePicker.Value.TimeOfDay; // Obtenemos solo la parte de la HORA como un TimeSpan
                _eventoAEditar.Tipo = CBType.SelectedItem.ToString();
                _eventoAEditar.Capacidad = (int)numericUpDown1.Value;

                // Le pasamos el objeto al manager para que lo guarde (agrega o modifica)
                _eventosManager.AddEvent(_eventoAEditar);

                // Le indicamos al formulario anterior que la operación fue exitosa
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Si el usuario cancela, simplemente cerramos el formulario sin guardar nada
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
