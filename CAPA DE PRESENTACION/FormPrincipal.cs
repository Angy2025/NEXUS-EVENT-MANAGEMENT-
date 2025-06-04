using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using CapaNegocios;//EventosManager y Eventos (mis clases en esa capa)
using CapaDatos;
using Microsoft.Data.SqlClient;
using System.Data; //List

namespace CAPA_DE_PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        private EventosManager eventosManager;

        public FormPrincipal()
        {
            InitializeComponent();
            eventosManager = new EventosManager();

            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            this.dgvEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellDoubleClick);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        // MÉTODO PRIVADO REUTILIZABLE
        private void CargarEventosPorTipo(string tipo)
        {
            try
            {
                EventosDatos data = new EventosDatos();
                using (SqlConnection conn = new SqlConnection(data.CadenaConexion))
                {
                    SqlDataAdapter adapt;
                    conn.Open();

                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT Id, Nombre FROM Evento WHERE Tipo = @Tipo", conn);
                    adapt.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
                    adapt.Fill(dt);

                    dgvEventos.DataSource = dt;
                    conn.Close();
                }
                btnResumen.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar eventos de tipo " + tipo + ": " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            if (dgvEventos.SelectedCells.Count > 0)
            {
                int idEvento = Convert.ToInt32(dgvEventos.SelectedRows[0].Cells["Id"].Value);

                EventosManager manager = new EventosManager();
                Eventos evento = manager.ObtenerResumenEvento(idEvento);

                if (evento != null)
                {
                    txtIdEvento.Text = evento.Id.ToString();
                    txtNombreEvento.Text = evento.Nombre;
                    txtFechaEvento.Text = evento.Fecha;
                    txtLugarEvento.Text = evento.Lugar;
                    txtTipoEvento.Text = evento.Tipo;
                }
                else
                {
                    MessageBox.Show("No se encontró el evento.");
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un evento.");
            }
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
    }
}
