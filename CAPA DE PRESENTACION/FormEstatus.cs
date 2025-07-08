using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CAPA_DE_NEGOCIOS;
using CapaDatos;
using System.Drawing;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormEstatus : Form
    {
        public Action<Form> AbrirFormularioHijo { get; set; }


        #region Campos y Carga de Datos

        private class EventosData : ConnectionToSql
        {
            public SqlConnection ObtenerConexion() => GetConnection();
        }

        private readonly string _connectionString = new EventosData().ObtenerConexion().ConnectionString;

        public FormEstatus()
        {
            InitializeComponent();
        }

        private void FormEstatus_Load(object sender, EventArgs e)
        {
            // Llamamos al método de estilo para ambas tablas
            ConfigurarEstiloDGV(dgvActivos);
            ConfigurarEstiloDGV(dgvHistorial);

            CargarEstatusEventos();
            CargarHistorialEventos();
        }

        private void ConfigurarEstiloDGV(DataGridView dgv)
        {
            // Estilos de comportamiento y apariencia general
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Estilos para el texto y las filas
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Estilo para la selección
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 168, 116);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void CargarEstatusEventos()
        {
            string query = "SELECT Id, Nombre, Estatus FROM Evento WHERE Estatus IN ('Planificado', 'Confirmado') ORDER BY FechaHora ASC;";
            CargarDatos(dgvActivos, query);
        }

        private void CargarHistorialEventos()
        {
            string query = "SELECT Id, Nombre, Estatus FROM Evento WHERE Estatus IN ('Realizado', 'Cancelado') ORDER BY FechaHora DESC;";
            CargarDatos(dgvHistorial, query);
        }

        private void CargarDatos(DataGridView dgv, string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;

                    if (dgv.Columns.Contains("Id") && dgv.Columns["Id"] != null)
                    {
                        dgv.Columns["Id"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion




        #region Generación de Reporte 

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataGridView dgvActivo = (tabControl1.SelectedTab == tabEstatus) ? dgvActivos : dgvHistorial;

            if (dgvActivo?.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un evento de la lista para generar el reporte.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int eventoId = Convert.ToInt32(dgvActivo.CurrentRow.Cells["Id"].Value);
            EventoBase eventoCompleto = ObtenerEventoCompletoPorId(eventoId);

            if (eventoCompleto != null)
            {
                var generador = new GeneradorDeReportes(eventoCompleto);
                byte[] pdfData = generador.GenerarPDF();
                var frmVisor = new FormVisorPDF(pdfData, eventoCompleto.Nombre);

                if (AbrirFormularioHijo != null)
                {
                    AbrirFormularioHijo(frmVisor);
                }
                else
                {
                    frmVisor.ShowDialog();
                }
            }
        }

        private EventoBase ObtenerEventoCompletoPorId(int id)
        {
            EventoBase evento = null;
            string query = "SELECT * FROM Evento WHERE Id = @Id;";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        evento = new Tecnologico // O la clase que corresponda
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString(),
                            Lugar = reader["Lugar"].ToString(),
                            FechaHora = Convert.ToDateTime(reader["FechaHora"]),
                            Categoria = reader["Categoria"].ToString(),
                            Capacidad = Convert.ToInt32(reader["Capacidad"]),
                            Estatus = reader["Estatus"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los detalles del evento: {ex.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return evento;
        }
        #endregion
    }
}
