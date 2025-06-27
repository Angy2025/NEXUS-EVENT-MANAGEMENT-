using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using CapaDatos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormPrincipal : Form
    {

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        // MÉTODO PRIVADO REUTILIZABLE
        private void CargarEventosPorTipo(string tipo)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            Color.FromArgb(47, 60, 71);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {

            CargarEventosPorTipo("Deportivo");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CargarEventosPorTipo("Cultural");
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            MostrarResumenEvento();
        }

        private void MostrarResumenEvento()
        {
           
        }

        private void txtInstruccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            // 1. Detenemos el timer para que no se repita
            timerunic.Stop();

            // 2. Creamos una instancia de nuestro formulario principal de gestión
            FormPrincipal frmBienvenida = new FormPrincipal();

            // 3. Lo mostramos
            frmBienvenida.Show();

            // 4. Ocultamos este formulario de bienvenida
            this.Hide();
        }
    }
}
