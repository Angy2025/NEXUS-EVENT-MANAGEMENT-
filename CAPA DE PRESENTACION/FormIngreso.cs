using System;
using CAPA_DE_NEGOCIOS;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }



        # region Funcionalidad para arrastrar el formulario

        // Importamos las funciones de la API de Windows para permitir arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FormIngreso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion




        #region TextBox Placeholder
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
                {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Gray;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true; // Para ocultar la contraseña
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false; // Para ocultar la contraseña
            }
        }
        #endregion



        #region Botones de control de ventana

        private void btnC_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cerrar la aplicación
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizar la ventana
        }
        #endregion



        private void FormIngreso_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAccess_Click(object sender, EventArgs e)
        {
            // Validaciones iniciales de los campos
            if (txtUser.Text == "USUARIO" || string.IsNullOrWhiteSpace(txtUser.Text))
            {
                msgError("Por favor, ingrese su nombre de usuario.");
                return;
            }
            if (txtPassword.Text == "CONTRASEÑA" || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                msgError("Por favor, ingrese su contraseña.");
                return;
            }
            try
            {
                // Lógica de Negocio para el login
                UserModel user = new UserModel();
                bool validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);

                if (validLogin)
                {
                    // Si el login es exitoso, abre el menú principal
                    FormAcceso mainmenu = new FormAcceso();
                    mainmenu.FormClosed += Logout; // Asocia el evento para cuando se cierre sesión
                    mainmenu.Show();
                    this.Hide();
                }
                else
                {
                    // Si las credenciales son incorrectas
                    msgError("Usuario o contraseña incorrectos.\nPor favor, intente nuevamente.");
                    ResetPassword();
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier error de conexión a la BD u otro problema
                msgError("Error al intentar iniciar sesión: " + ex.Message);
            }
        }




        #region Metodos de ayuda para el formulario
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "      " + msg; // Mostrar mensaje de error en la etiqueta
            lblErrorMessage.Visible = true; // Hacer visible la etiqueta de error
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            ResetPassword();
            txtUser.Text = "USUARIO";
            txtUser.ForeColor = Color.Gray;
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void ResetPassword()
        { 
            txtPassword.Text = "CONTRASEÑA"; // Resetea el campo de contraseña
            txtPassword.ForeColor = Color.Gray; // Cambia el color del texto a gris
            txtPassword.UseSystemPasswordChar = false;
        }
        #endregion
    }
}

