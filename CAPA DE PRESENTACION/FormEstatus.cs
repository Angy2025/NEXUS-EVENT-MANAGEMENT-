using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CAPA_DE_NEGOCIOS; // Para EventoBase, Tecnologico, etc.
using CapaDatos; // Para ConnectionToSql

namespace CAPA_DE_PRESENTACION
{
    public partial class FormEstatus : Form
    {
        // Heredamos la conexión desde la capa de datos
        private class EventosData : ConnectionToSql
        {
            public SqlConnection ObtenerConexion() => GetConnection();
        }

        private readonly string _connectionString = new EventosData().ObtenerConexion().ConnectionString;

        public FormEstatus()
        {
            InitializeComponent();
        }

        #region --- Carga de Datos ---

        private void FormEstatus_Load(object sender, EventArgs e)
        {
            CargarEstatusEventos();
            CargarHistorialEventos();
        }

        private void CargarEstatusEventos()
        {
            // Eventos que aún no han ocurrido (Planificado y Confirmado)
            string query = "SELECT Id, Nombre, Estatus FROM Evento WHERE Estatus IN ('Planificado', 'Confirmado') ORDER BY FechaHora ASC;";
            // --- CORRECCIÓN AQUÍ ---
            CargarDatos(dgvActivos, query); // Corregido de dgvEstatus a dgvActivos
        }

        private void CargarHistorialEventos()
        {
            // Eventos que ya pasaron o fueron cancelados ('Realizado', 'Cancelado')
            string query = "SELECT Id, Nombre, Estatus FROM Evento WHERE Estatus IN ('Realizado', 'Cancelado') ORDER BY FechaHora DESC;";
            CargarDatos(dgvHistorial, query); // Este ya era correcto
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

                    // Ocultar la columna ID, pero mantenerla accesible
                    if (dgv.Columns["Id"] != null)
                    {
                        dgv.Columns["Id"].Visible = false;
                    }

                    // Ajustar las columnas visibles para que ocupen todo el ancho
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region --- Generación de Reporte ---

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataGridView dgvActivo = null;

            // Determina el DataGridView activo basado en la pestaña seleccionada
            if (tabControl1.SelectedTab == tabEstatus)
            {
                // --- CORRECCIÓN AQUÍ ---
                dgvActivo = dgvActivos; // Corregido de dgvEstatus a dgvActivos
            }
            else if (tabControl1.SelectedTab == tabHistorial)
            {
                dgvActivo = dgvHistorial;
            }

            if (dgvActivo?.CurrentRow != null)
            {
                // Obtiene el ID de la fila seleccionada (usando la columna oculta)
                int eventoId = Convert.ToInt32(dgvActivo.CurrentRow.Cells["Id"].Value);

                // Obtiene el objeto completo del evento desde la base de datos
                EventoBase eventoCompleto = ObtenerEventoCompletoPorId(eventoId);

                if (eventoCompleto != null)
                {
                    // Genera el PDF usando la clase de la capa de negocios
                    var generador = new GeneradorDeReportes(eventoCompleto);
                    byte[] pdfData = generador.GenerarPDF();

                    // Abre el formulario visor con los datos del PDF
                    FormVisorPDF visor = new FormVisorPDF(pdfData, eventoCompleto.Nombre);
                    visor.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un evento de la lista para generar el reporte.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        // Aquí podrías tener una lógica para instanciar la clase correcta
                        // según la 'Categoria'. Por ahora, usamos 'Tecnologico' como ejemplo.
                        evento = new Tecnologico // O Deportivo, Cultural, etc.
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString(),
                            Lugar = reader["Lugar"].ToString(),
                            FechaHora = Convert.ToDateTime(reader["FechaHora"]),
                            Categoria = reader["Categoria"].ToString(), // Asignamos la categoría
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
