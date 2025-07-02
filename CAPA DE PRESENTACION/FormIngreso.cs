using System;
using CAPA_DE_NEGOCIOS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // Personalizar el diseño del formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            //Creamos una instancia de nuestro formulario de gestión
            FormAcceso acceso = new FormAcceso();
            acceso.Show();
            this.Hide(); // Ocultar el formulario de ingreso
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

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
            if (txtUser.Text == "")
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
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false; // Para ocultar la contraseña
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar la aplicación
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizar la ventana
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

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPassword.Text != "CONTRASEÑA")
                {

                }
                else msgError("Por favor, ingrese su contraseña");
            }
            else msgError("Por favor, ingrese su nombre de usuario");
            {
               
            }
        }
        

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "      " + msg; // Mostrar mensaje de error en la etiqueta
            lblErrorMessage.Visible = true; // Hacer visible la etiqueta de error


        }


        /*private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para verificar las credenciales del usuario
            // Por ejemplo, comparar con una base de datos o una lista de usuarios permitidos
            // Si las credenciales son correctas, puedes abrir el formulario principal
            FormAcceso acceso = new FormAcceso();
            acceso.Show();
            this.Hide(); // Ocultar el formulario de ingreso
        }*/
    }
}
