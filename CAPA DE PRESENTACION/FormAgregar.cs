using CAPA_DE_NEGOCIOS;
using System;
using System.Linq; 
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

        private bool esModoModificar = false;

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
            // Establece la fecha mínima seleccionable en el calendario al día de hoy
            dateTimePicker.MinDate = DateTime.Today;

            // Establece el límite de caracteres para los campos de texto
            textName.MaxLength = 60;
            textPlace.MaxLength = 60;

            // Establece el valor mínimo para la capacidad, evitando que sea 0
            numericUpDown1.Minimum = 1;

            // Suscribe los eventos KeyPress para validar los caracteres en tiempo real
            textName.KeyPress += TextBox_KeyPress_NoNumeros;
            textPlace.KeyPress += TextBox_KeyPress_NoNumeros;




            // Primero, configuramos los controles que no dependen de los datos, como el ComboBox
            ConfigurarComboBox();

            // Si estamos en modo "Modificar", cargamos los datos del evento
            if (_eventoAEditar != null)
            {
                CargarDatos();
            }



            // Finalmente, establecemos la fecha mínima permitida para la selección del usuario
            // Esto se hace al final para no entrar en conflicto con la carga de fechas pasadas
            dateTimePicker.MinDate = DateTime.Today;
        }
        #endregion






        #region Metodos de Configuración
        private void CargarDatos()
        {
            textName.Text = _eventoAEditar.Nombre;
            textPlace.Text = _eventoAEditar.Lugar;

            // Primero, verificamos si la fecha del evento a editar es anterior a la fecha mínima actual del control
            if (_eventoAEditar.FechaHora < dateTimePicker.MinDate)
            {
                // Si lo es, temporalmente ajustamos la fecha mínima del control para permitir que se asigne el valor antiguo
                dateTimePicker.MinDate = _eventoAEditar.FechaHora;
            }
            // Ahora que es seguro hacerlo, asignamos el valor
            dateTimePicker.Value = _eventoAEditar.FechaHora;
            CBType.SelectedItem = _eventoAEditar.Categoria;
            numericUpDown1.Value = _eventoAEditar.Capacidad;
        }
        private void ConfigurarComboBox()
        {
            // El formulario no conoce la lista de categorías, solo se la pide a la capa de negocios
            CBType.DataSource = _configDetalle.ObtenerCategoriasDisponibles();
        }

        // Este evento se dispara cada vez que el usuario presiona una tecla en los TextBox de Nombre y Lugar
        private void TextBox_KeyPress_NoNumeros(object sender, KeyPressEventArgs e)
        {
            // Se permite la entrada de letras, espacios, y teclas de control (como borrar o copiar/pegar)
            // pero se bloquea la entrada de números y la mayoría de los símbolos.
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                // Si la tecla presionada no es una de las permitidas, se ignora
                e.Handled = true;
            }
        }
        #endregion






        #region Eventos de Controles

        //Se ejecuta al hacer clic en el botón Guardar

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // --- INICIO DE VALIDACIONES MEJORADAS ---
                if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textPlace.Text) || CBType.SelectedItem == null)
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación para la capacidad, aunque ya está limitada por el control, es una buena práctica
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("La capacidad del evento no puede ser cero.", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              

                if (_eventoAEditar == null)
                {
                    string tipoSeleccionado = CBType.SelectedItem.ToString();
                    _eventoAEditar = _configDetalle.CrearEventoPorTipo(tipoSeleccionado);
                }

                _eventoAEditar.Nombre = textName.Text;
                _eventoAEditar.Lugar = textPlace.Text;
                _eventoAEditar.FechaHora = dateTimePicker.Value;
                _eventoAEditar.Categoria = CBType.SelectedItem.ToString();
                _eventoAEditar.Capacidad = (int)numericUpDown1.Value;

                _eventosManager.AddEvent(_eventoAEditar);

                
                // Muestra un mensaje diferente dependiendo si se agregó o modificó el evento
                if (esModoModificar)
                {
                    MessageBox.Show("Evento modificado con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Evento guardado con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               

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
