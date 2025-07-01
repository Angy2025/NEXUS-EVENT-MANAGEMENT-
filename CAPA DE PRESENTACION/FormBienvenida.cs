using System;
using System.Windows.Forms;


namespace CAPA_DE_PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInstruccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timerunic_Tick(object sender, EventArgs e)
        {
            //Detenemos el timer para que no se repita
            timerunic.Stop();

            //Creamos una instancia de nuestro formulario de gestión
            FormLogin log = new FormLogin();

            //Lo mostramos
            log.Show();

            //Ocultamos este formulario de bienvedida
            this.Hide();
        }
    }
}
