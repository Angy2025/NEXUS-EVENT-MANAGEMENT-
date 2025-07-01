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
            PanelManagement.Visible = false;
            PanelSubMenuMedios.Visible = false;
            PanelTools.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelSubMenuMedios.Visible == true)
            {
                PanelSubMenuMedios.Visible = false;
            }
            if (PanelManagement.Visible == true)
            {
                PanelManagement.Visible = false;
            }
            if (PanelTools.Visible == true)
            {
                PanelTools.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelManagement);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CODIGO PARA ABRIR EL FORMULARIO DE MEDIOS(PRINCIPAL)

            hideSubMenu();
        }
    }
}
