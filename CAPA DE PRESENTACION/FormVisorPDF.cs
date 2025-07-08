using System;
using System.IO;
using System.Windows.Forms;
using PdfiumViewer; // Asegúrate de tener el using para PdfiumViewer
using System.Diagnostics; // Necesario para Process.Start

namespace CAPA_DE_PRESENTACION
{
    public partial class FormVisorPDF : Form
    {
        private readonly byte[] _pdfData; // Almacena los bytes del PDF

        public FormVisorPDF(byte[] pdfData, string nombreEvento)
        {
            InitializeComponent();
            _pdfData = pdfData;
            this.Text = $"Reporte para: {nombreEvento}"; // Título del formulario
        }

        #region --- Eventos del Formulario ---

        private void FormVisorPDF_Load(object sender, EventArgs e)
        {
            // Cuando el formulario carga, muestra el PDF en el visor
            if (_pdfData != null && _pdfData.Length > 0)
            {
                try
                {
                    // Creamos un stream en memoria a partir de los bytes del PDF
                    var stream = new MemoryStream(_pdfData);
                    // Cargamos el stream en el control PdfViewer
                    pdfViewerControl.Document = PdfDocument.Load(stream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo cargar la vista previa del PDF: {ex.Message}", "Error de Visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region --- Lógica de Botones ---

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Abre el diálogo para que el usuario elija dónde guardar el archivo
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveDialog.Title = "Guardar Reporte como PDF";
                // Sugerimos un nombre de archivo limpio y descriptivo
                saveDialog.FileName = $"Reporte_{this.Text.Replace("Reporte para: ", "").Trim()}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. Guarda los bytes del PDF en la ubicación elegida por el usuario
                        File.WriteAllBytes(saveDialog.FileName, _pdfData);
                        MessageBox.Show("Reporte guardado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 2. Abre el archivo PDF recién guardado con el visor por defecto del sistema
                        var processStartInfo = new ProcessStartInfo()
                        {
                            FileName = saveDialog.FileName,
                            UseShellExecute = true // Importante para que Windows use el visor de PDF predeterminado
                        };
                        Process.Start(processStartInfo);

                        // 3. Cierra el formulario del visor después de guardar y abrir
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al guardar o abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCloseVisor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
