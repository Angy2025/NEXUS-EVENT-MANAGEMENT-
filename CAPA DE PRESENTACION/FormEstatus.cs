using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CAPA_DE_NEGOCIOS;
using System.Drawing;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormEstatus : Form
    {
        #region Campos y Propiedades

        public Action<Form> AbrirFormularioHijo { get; set; }
        // El formulario ahora solo necesita conocer a su manager de lógica específico.
        private readonly ObtencionDatosEstatus _estatusdedatos = new ObtencionDatosEstatus();

        #endregion


        #region Constructor y Carga

        public FormEstatus()
        {
            InitializeComponent();
        }

        private void FormEstatus_Load(object sender, EventArgs e)
        {
            try
            {
                // Configura el estilo y permite la autogeneración de columnas
                ConfigurarEstiloDGV(dgvActivos);
                ConfigurarEstiloDGV(dgvHistorial);

                // Conecta el evento que se ejecutará DESPUÉS de que los datos se carguen para ocultar columnas
                dgvActivos.DataBindingComplete += Dgv_DataBindingComplete;
                dgvHistorial.DataBindingComplete += Dgv_DataBindingComplete;

                // Carga los datos usando los métodos de la capa de negocios
                CargarEstatusEventos();
                CargarHistorialEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Configuración de UI y Carga de Datos

        private void ConfigurarEstiloDGV(DataGridView dgv)
        {
            // La clave es decirle a la tabla que cree las columnas por sí misma
            dgv.AutoGenerateColumns = true;

            // Estilos de comportamiento y apariencia general
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Esta propiedad pone toda la tabla en modo de solo lectura
            dgv.ReadOnly = true;
        }

        private void CargarEstatusEventos()
        {
            // El formulario no sabe de SQL. Solo le pide los eventos activos al manager
            dgvActivos.DataSource = _estatusdedatos.ObtenerEventosActivos();
        }

        private void CargarHistorialEventos()
        {
            // El formulario solo le pide el historial de eventos al manager
            dgvHistorial.DataSource = _estatusdedatos.ObtenerEventosDeHistorial();
        }

        // Este evento se ejecuta cuando los datos terminan de cargarse
        // Aquí ocultamos las columnas que no queremos ver
        private void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || dgv.Columns.Count == 0) return;

            // Lista de las propiedades que SÍ queremos ver
            var columnasVisibles = new List<string> { "Nombre", "Estatus" };

            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                // Si el nombre de la columna (que es el nombre de la propiedad del objeto)
                // NO está en nuestra lista de columnas visibles, la ocultamos.
                if (!columnasVisibles.Contains(columna.Name))
                {
                    columna.Visible = false;
                }
            }
        }

        #endregion


        #region Generación de Reporte

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Este código determina qué tabla está viendo el usuario actualmente.
            DataGridView dgvSeleccionado = (tabControl1.SelectedTab == tabEstatus) ? dgvActivos : dgvHistorial;

            if (dgvSeleccionado?.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un evento de la lista para generar el reporte.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // La columna "Id" existe en memoria (pero está oculta), así que podemos acceder a su valor.
            int eventoId = Convert.ToInt32(dgvSeleccionado.CurrentRow.Cells["Id"].Value);

            // El formulario ahora le pide el evento completo a su manager específico.
            EventoBase eventoCompleto = _estatusdedatos.ObtenerEventoPorId(eventoId);

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
            else
            {
                MessageBox.Show("No se pudieron encontrar los detalles del evento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}