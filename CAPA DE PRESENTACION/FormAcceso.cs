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
        public FormAcceso()
        {
            InitializeComponent();
            PersonalizarDiseño();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void PersonalizarDiseño()
        {
            PanelSubMenuMedios.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelSubMenuMedios.Visible == true)
            {
                PanelSubMenuMedios.Visible = false;
            }
            if (PanelDetalles.Visible == true)
            {
                PanelDetalles.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelSubMenuMedios);
        }

        private void b_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new FormularioGestion());

            //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

            hideSubMenu();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private Form activeForm = null;
        private void OpenPanelHerencia(Form herenciaForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = herenciaForm;
            herenciaForm.TopLevel = false;
            herenciaForm.FormBorderStyle = FormBorderStyle.None;
            herenciaForm.Dock = DockStyle.Fill;
            PanelHerencia.Controls.Add(herenciaForm);
            PanelHerencia.Tag = herenciaForm;
            herenciaForm.BringToFront();
            herenciaForm.Show();
        }
        private void PanelHerencia_Paint(object sender, PaintEventArgs e)
        {

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelDetalles);
        }

        private void PanelHerencia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMod2_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new FormularioDetalle()); //Agregar Evento
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new FormModificar()); //Editar Evento existente
            hideSubMenu();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new FormIngreso()); //Login Form
            hideSubMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadUserData()
        {
            lblnom.Text = NewLoginUser.Nombre + ", " + NewLoginUser.Apellido;
            lblposicion.Text = NewLoginUser.Posicion;
            lblEmail.Text = NewLoginUser.Email;
        }

        private void FormAcceso_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void PanelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void button2_Click(object sender, EventArgs e)
            {
                //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

                hideSubMenu();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

                hideSubMenu();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

                hideSubMenu();
            }

             private void panel4_Paint(object sender, PaintEventArgs e)
            {

            }

             */
    }
}
