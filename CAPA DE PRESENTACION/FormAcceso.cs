using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 
using CAPA_DE_ENTIDADES.CACHE; // Para acceder a los datos del usuario que inició sesión

namespace CAPA_DE_PRESENTACION
{
    public partial class FormAcceso : Form
    {
        #region Campos de clase

        // Almacena una referencia al formulario que está actualmente abierto en el panel principal.
        // Se usa para poder cerrarlo antes de abrir uno nuevo. Es 'nullable' (con ?) porque al inicio no hay ningún formulario activo.
        private Form? activeForm = null;

        #endregion


        #region Constructor y Carga del formulario

        public FormAcceso()
        {
            InitializeComponent();

            // --- Configuraciones iniciales para una apariencia personalizada sin bordes ---
            this.Text = string.Empty; // Elimina el texto de la barra de título.
            this.ControlBox = false;  // Oculta los botones de minimizar, maximizar y cerrar por defecto de Windows.
            this.DoubleBuffered = true; // Mejora el rendimiento del dibujado del formulario, reduciendo el parpadeo.
            // Limita el área de maximización para que no cubra la barra de tareas de Windows.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Este evento se dispara una sola vez, justo cuando el formulario está listo para mostrarse.
        private void FormAcceso_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar la información del perfil del usuario en la interfaz.
            LoadUserData();
        }

        // Carga los datos del usuario (que fueron guardados en la caché durante el login) en los controles del formulario.
        private void LoadUserData()
        {
            // Asigna el nombre, posición y email a las etiquetas correspondientes.
            lblnom.Text = NewLoginUser.Nombre + " " + NewLoginUser.Apellido;
            lblposicion.Text = NewLoginUser.Posicion;
            lblEmail.Text = NewLoginUser.Email;

            // Bloque try-catch para manejar de forma segura posibles errores al cargar la imagen.
            try
            {
                // Obtiene la ruta relativa de la imagen desde la clase estática de caché (ej: "USUARIOS\ramon.png").
                string fotoPath = NewLoginUser.FotoPath;

                // Se asegura de que la ruta de la foto no esté vacía antes de intentar cargarla.
                if (!string.IsNullOrEmpty(fotoPath))
                {
                    // Combina la ruta de inicio de la aplicación (la carpeta bin\Debug) con la ruta relativa de la foto
                    // para obtener la ubicación completa y exacta del archivo de imagen.
                    string rutaCompleta = System.IO.Path.Combine(Application.StartupPath, fotoPath);

                    // Verifica que el archivo de imagen realmente existe en la ruta calculada antes de intentar cargarlo.
                    if (System.IO.File.Exists(rutaCompleta))
                    {
                        // Carga la imagen desde el archivo y la asigna al control PictureBox.
                        PBuser.Image = Image.FromFile(rutaCompleta);
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre cualquier error (ej: el archivo está dañado), muestra un mensaje al usuario.
                MessageBox.Show("No se pudo cargar la imagen de perfil: " + ex.Message);
            }
        }
        #endregion


        #region Eventos click de los menus

        // Se ejecuta al hacer clic en el botón "Gestionar Eventos".
        private void btnGestionEventos_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de gestión.
            FormularioGestion frmGestion = new FormularioGestion();
            // Le "pasa" a este nuevo formulario el método que debe usar para abrir a sus propios hijos.
            frmGestion.AbrirFormularioHijo = this.OpenPanelHerencia;
            // Llama al método para abrir el formulario de gestión en el panel principal.
            OpenPanelHerencia(frmGestion);
        }

        // Se ejecuta al hacer clic en el botón "Estatus de Eventos".
        private void btnEstatus_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de estatus.
            var frmEstatus = new FormEstatus();
            // Le "pasa" la responsabilidad de abrir formularios hijos.
            frmEstatus.AbrirFormularioHijo = this.OpenPanelHerencia;
            // Abre el formulario de estatus en el panel principal.
            OpenPanelHerencia(frmEstatus);
        }

        // Se ejecuta al hacer clic en el botón "Cerrar sesión".
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo para confirmar la acción.
            if (MessageBox.Show("¿Esta seguro de que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                // Si el usuario presiona "Sí", se cierra este formulario (FormAcceso), lo que debería devolver al usuario al formulario de login.
                this.Close();
        }
        #endregion


        #region Metodo para abrir Formularios hijos en el panel principal

        // Este es el método central para la navegación. Recibe cualquier formulario que deba ser mostrado
        private void OpenPanelHerencia(Form herenciaForm)
        {
            // Comprueba si ya hay un formulario abierto en el panel
            if (activeForm != null)
                // Si lo hay, lo cierra para limpiar el panel antes de abrir el nuevo
                activeForm.Close();

            // Guarda una referencia al nuevo formulario que se va a abrir
            activeForm = herenciaForm;

            //Configura el formulario hijo para que se comporte como un control dentro del panel 
            herenciaForm.TopLevel = false; // Le quita la categoría de "ventana principal"
            herenciaForm.FormBorderStyle = FormBorderStyle.None; // Le quita los bordes y la barra de título
            herenciaForm.Dock = DockStyle.Fill; // Hace que ocupe todo el espacio del panel

            //Agrega y muestra el formulario en el panel
            PanelHerencia.Controls.Add(herenciaForm); // Lo añade a la colección de controles del panel
            PanelHerencia.Tag = herenciaForm; // Guarda una referencia en la propiedad
            herenciaForm.BringToFront(); // Se asegura de que se muestre por encima de cualquier otro control en el panel
            herenciaForm.Show(); // Muestra el formulario
        }
        #endregion


        #region Controles de la ventana (cerrar, restaurar, Maximizar, Minimizar)

        // Botón para cerrar toda la aplicación
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botón para minimizar la ventana principal
        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Botón personalizado para maximizar la ventana
        private void button9_Click(object sender, EventArgs e) //Maximizar
        {
            // Cambia el estado de la ventana a maximizado
            this.WindowState = FormWindowState.Maximized;
            // Oculta el botón de maximizar y muestra el de restaurar para una mejor experiencia de usuario
            btnrestaurar.Visible = true;
            buttonMaximizar.Visible = false;
        }

        // Botón personalizado para restaurar la ventana a su tamaño normal
        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            // Devuelve la ventana a su estado normal.
            this.WindowState = FormWindowState.Normal;
            // Oculta el botón de restaurar y vuelve a mostrar el de maximizar
            btnrestaurar.Visible = false;
            buttonMaximizar.Visible = true;
        }
        #endregion


        #region Arrastrar el Formulario desde el panel

        //Lógica para permitir que el usuario mueva la ventana haciendo clic y arrastrando
        // Se usa porque quitamos la barra de título por defecto de Windows

        // Importa una función de la API de Windows que libera la captura del mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        // Importa una función que envía un mensaje a la ventana, en este caso, para decirle que se mueva
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Se ejecuta cuando el usuario presiona el botón del mouse sobre el panel del título
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // Libera el mouse.
            // Envía un mensaje a Windows para que empiece a mover la ventana
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // También permite arrastrar desde el panel principal donde se muestran los formularios
        private void PanelHerencia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Eventos vacios, xd

        // Estos métodos son generados por el diseñador al hacer doble clic en un control,
        // pero no tienen ninguna lógica asignada. Se pueden dejar así o eliminar si no se usan
        private void label1_Click(object sender, EventArgs e) { }
        private void PanelMenuLateral_Paint(object sender, PaintEventArgs e) { }
        private void PBuser_Click(object sender, EventArgs e) { }
        private void panelsub3_Paint(object sender, PaintEventArgs e) { }

        #endregion
    }
}