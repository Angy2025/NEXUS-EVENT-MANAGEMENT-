using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            PersonalizarDiseño();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelSubMenuMedios);
        }

        private void b_Click(object sender, EventArgs e)
        {
            //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

            hideSubMenu();
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
    }
}
