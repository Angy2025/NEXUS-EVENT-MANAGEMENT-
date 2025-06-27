using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_DE_NEGOCIOS; // Importamos la capa de negocios para manejar los eventos


namespace CAPA_DE_PRESENTACION
{
    public partial class frmGestionEventos : Form
    {
        public frmGestionEventos()
        {
            InitializeComponent();
        }

        private void FormularioPrincpal_Load(object sender, EventArgs e)
        {

        }

        private void MostrarEvent()
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionEventos_Load(object sender, EventArgs e)
        {

        }

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FormularioDetalle frmDetalle = new FormularioDetalle();
            frmDetalle.ShowDialog();

            if (frmDetalle.ShowDialog() == DialogResult.OK)
            {
                // El usuario hizo clic en "Guardar",
                // así que refrescamos la tabla para ver el nuevo evento.
                CargarEventos();
            }
        }
    }
}
