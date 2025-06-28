using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Propósito: Mostrar un diálogo de confirmación

namespace CAPA_DE_PRESENTACION
{
    public partial class FormConfirmacion : Form
    {
        public FormConfirmacion(string nombreEvento)
        {
            InitializeComponent();
            //Usamos el nombre para personalizar el mensaje de confirmación
            lblMensaje.Text = $"¿Está seguro de que desea eliminar el evento '{nombreEvento}'?";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes; //boton Aceptar
        }

        private void FormConfirmacion_Load(object sender, EventArgs e)
        {

        }

        private void FormConfirmacion_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No; //boton Cancelar
        }
    }
}
