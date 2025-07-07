using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Drawing.Printing;
using PdfiumViewer;


namespace CAPA_DE_PRESENTACION
{
    public partial class FormVisorPDF : Form
    {
        private byte[] _pdfData; //Almacena los bytes del PDF

        // El constructor recibe los datos del PDF y el nombre del evento
        public FormVisorPDF(byte[] pdfData, string nombreEvento)
        {
            InitializeComponent();
            _pdfData = pdfData;
            this.Text = $"Reporte para: {nombreEvento}";
        }
        private void FormVisorPDF_Load(object sender, EventArgs e)
        {
            // Cuando el formulario carga, muestra el PDF en el visor
            if (_pdfData != null)
            {
                // Creamos un stream en memoria a partir de los bytes del PDF
                var stream = new MemoryStream(_pdfData);
                // Cargamos el stream en el control PdfViewer
                pdfViewerControl.Document = PdfiumViewer.PdfDocument.Load(stream);
            }
        }
        private void btnCloseVisor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Abre el 
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveDialog.Title = "Guardar Reporte como PDF";
                saveDialog.FileName = $"Reporte_{this.Text.Replace("Reporte para: ", "")}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Si el usuario elige una ubicación, guarda los bytes del PDF en un archivo
                        File.WriteAllBytes(saveDialog.FileName, _pdfData);
                        MessageBox.Show("Reporte guardado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //LÍNEAS AÑADIDAS PARA ABRIR EL ARCHIVO
                        var psi = new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = saveDialog.FileName,
                            UseShellExecute = true // Importante para que use el visor por defecto
                        };
                        System.Diagnostics.Process.Start(psi);
                        // ---------------------------------------------
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al guardar o abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
