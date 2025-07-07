using CAPA_DE_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioEstatusYReportes : Form
    {
        #region Campos y Propiedades

        public Action<Form>? AbrirFormularioHijo { get; set; }
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();
        private List<EventoBase> _listaCompletaDeEventos;
        private EventoBase? _eventoSeleccionado = null;

        #endregion

        #region Constructor y Carga

        public FormularioEstatusYReportes()
        {
            InitializeComponent();
        }

        private void FormularioEstatusYReportes_Load(object sender, EventArgs e)
        {
            try
            {
                // ¡Paso clave! Primero definimos las columnas que queremos ver.
                DefinirColumnas(dgvActivos);
                DefinirColumnas(dgvHistorial);

                // Luego, aplicamos el estilo.
                ConfigurarDataGrids(dgvActivos);
                ConfigurarDataGrids(dgvHistorial);

                // Finalmente, cargamos los datos.
                CargarYDistribuirEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Configuración y Lógica de Datos

        /// <summary>
        /// Crea y configura las columnas manualmente (ID, Nombre, Estatus) para los DGVs de este formulario.
        /// </summary>
        private void DefinirColumnas(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false; // Le decimos a la tabla que no cree columnas por su cuenta.

            // Creamos solo las 3 columnas que necesitamos.
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", FillWeight = 15 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre del Evento", DataPropertyName = "Nombre", FillWeight = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estatus", DataPropertyName = "Estatus", FillWeight = 25 });
        }

        private void ConfigurarDataGrids(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
        }

        private void CargarYDistribuirEventos()
        {
            _listaCompletaDeEventos = _eventosManager.ObtainAllEvents();

            var eventosActivos = _listaCompletaDeEventos
                .Where(e => e.Estatus == "Planificado" || e.Estatus == "Confirmado")
                .ToList();

            var eventosHistorial = _listaCompletaDeEventos
                .Where(e => e.Estatus == "Realizado" || e.Estatus == "Cancelado")
                .ToList();

            dgvActivos.DataSource = null;
            dgvActivos.DataSource = eventosActivos;

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = eventosHistorial;
        }

        #endregion

        #region Eventos de Controles

        private void dgvActivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActivos.Focused && dgvActivos.SelectedRows.Count > 0)
            {
                dgvHistorial.ClearSelection();
                _eventoSeleccionado = dgvActivos.SelectedRows[0].DataBoundItem as EventoBase;
            }
        }

        private void dgvHistorial_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistorial.Focused && dgvHistorial.SelectedRows.Count > 0)
            {
                dgvActivos.ClearSelection();
                _eventoSeleccionado = dgvHistorial.SelectedRows[0].DataBoundItem as EventoBase;
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (_eventoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un evento para generar su reporte.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var generador = new GeneradorDeReportes(_eventoSeleccionado);
                byte[] pdfBytes = generador.GenerarPDF();
                var visor = new FormVisorPDF(pdfBytes, _eventoSeleccionado.Nombre);

                if (AbrirFormularioHijo != null)
                {
                    AbrirFormularioHijo(visor);
                }
                else
                {
                    visor.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotificarCambio_Click(object sender, EventArgs e)
        {
            if (_eventoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un evento para notificar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = $"Simulación de envío de correo:\n\nSe ha enviado una notificación sobre el estado '{_eventoSeleccionado.Estatus}' del evento '{_eventoSeleccionado.Nombre}' a todos los involucrados.";
            MessageBox.Show(mensaje, "Notificación Simulada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}