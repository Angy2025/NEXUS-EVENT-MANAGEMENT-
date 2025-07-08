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
using CAPA_DE_ENTIDADES.CACHE;



namespace CAPA_DE_PRESENTACION
{
    public partial class FormAcceso : Form
    {
        #region Campos de clase

        //Mantiene una referencia al formulario activo dentro del panel principal
        private Form? activeForm = null;
        #endregion




        #region Constructor, Carga del formulario y eleccion de fotos por login
        public FormAcceso()
        {
            InitializeComponent();

            //Configuraciones iniciales del formulario para una apariencia sin bordes y sin título
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FormAcceso_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            lblnom.Text = NewLoginUser.Nombre + " " + NewLoginUser.Apellido;
            lblposicion.Text = NewLoginUser.Posicion;
            lblEmail.Text = NewLoginUser.Email;

            try
            {
                // Obtiene la ruta relativa de la imagen desde la caché (ramon.png y angelica.png)
                string fotoPath = NewLoginUser.FotoPath;

                // Verifica que la ruta no esté vacía
                if (!string.IsNullOrEmpty(fotoPath))
                {
                    // Combina la ruta de inicio de la aplicación con la ruta de la foto
                    // para obtener la ruta completa del archivo
                    string rutaCompleta = System.IO.Path.Combine(Application.StartupPath, fotoPath);

                    // Carga la imagen en el PictureBox
                    if (System.IO.File.Exists(rutaCompleta))
                    {
                        PBuser.Image = Image.FromFile(rutaCompleta);
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier error al cargar la imagen 
                MessageBox.Show("No se pudo cargar la imagen de perfil: " + ex.Message);
            }
        }
        #endregion





        #region Eventos click de los menus
        private void btnGestionEventos_Click(object sender, EventArgs e)
        {
            FormularioGestion frmGestion = new FormularioGestion();

            frmGestion.AbrirFormularioHijo = this.OpenPanelHerencia;
            OpenPanelHerencia(frmGestion);
        }
        private void btnEstatus_Click(object sender, EventArgs e)
        {
            var frmEstatus = new FormEstatus();
            frmEstatus.AbrirFormularioHijo = this.OpenPanelHerencia;
            OpenPanelHerencia(frmEstatus);
        }

        private void btnExit_Click(object sender, EventArgs e) //Boton "Cerrar sesion"
        {
            if (MessageBox.Show("¿Esta seguro de que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        #endregion






        #region Metodo para abrir Formularios hijos en el panel principal


        private void OpenPanelHerencia(Form herenciaForm)
        {
            //Si hay un formulario abierto, lo cerramos
            if (activeForm != null)
                activeForm.Close();

            activeForm = herenciaForm;

            // Configuramos el formulario hijo para que se comporte como un control
            herenciaForm.TopLevel = false;
            herenciaForm.FormBorderStyle = FormBorderStyle.None;
            herenciaForm.Dock = DockStyle.Fill;


            // Lo agregamos al panel y lo traemos al frente
            PanelHerencia.Controls.Add(herenciaForm);
            PanelHerencia.Tag = herenciaForm;
            herenciaForm.BringToFront();
            herenciaForm.Show();
        }
        #endregion





        #region Controles de la ventana (cerrar, restaurar, Maximizar, Minimizar)
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button9_Click(object sender, EventArgs e) //Maximizar
        {
            // Alterna entre estado maximizado y normal
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            buttonMaximizar.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            buttonMaximizar.Visible = true;
        }
        #endregion





        #region Arrastrar el Formulario desde el panel

        //Importamos de la API de Windows para permitir mover el form sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelHerencia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        #region Eventos vacios, xd
        private void label1_Click(object sender, EventArgs e) { }
        private void PanelMenuLateral_Paint(object sender, PaintEventArgs e) { }
        private void PBuser_Click(object sender, EventArgs e) { }
        private void panelsub3_Paint(object sender, PaintEventArgs e) { }

        #endregion









        
    }
}
