namespace CAPA_DE_PRESENTACION
{
    partial class FormVisorPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pdfViewerControl = new PdfiumViewer.PdfViewer();
            panel1 = new Panel();
            btnSave = new Button();
            btnCloseVisor = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pdfViewerControl
            // 
            pdfViewerControl.BackColor = Color.FromArgb(95, 83, 60);
            pdfViewerControl.BackgroundImageLayout = ImageLayout.Stretch;
            pdfViewerControl.Dock = DockStyle.Fill;
            pdfViewerControl.Location = new Point(0, 0);
            pdfViewerControl.Margin = new Padding(4, 5, 4, 5);
            pdfViewerControl.Name = "pdfViewerControl";
            pdfViewerControl.Size = new Size(988, 753);
            pdfViewerControl.TabIndex = 3;
            pdfViewerControl.Load += FormVisorPDF_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 0, 0, 0);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCloseVisor);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 533);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 220);
            panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(132, 89);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 59);
            btnSave.TabIndex = 1;
            btnSave.Text = "Guargar PDF";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCloseVisor
            // 
            btnCloseVisor.Anchor = AnchorStyles.None;
            btnCloseVisor.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseVisor.Location = new Point(649, 89);
            btnCloseVisor.Name = "btnCloseVisor";
            btnCloseVisor.Size = new Size(196, 59);
            btnCloseVisor.TabIndex = 0;
            btnCloseVisor.Text = "Cerrar Visor";
            btnCloseVisor.UseVisualStyleBackColor = true;
            btnCloseVisor.Click += btnCloseVisor_Click;
            // 
            // FormVisorPDF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__11_6;
            ClientSize = new Size(988, 753);
            Controls.Add(panel1);
            Controls.Add(pdfViewerControl);
            ForeColor = Color.Black;
            MinimumSize = new Size(1006, 800);
            Name = "FormVisorPDF";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelEncabezado;
        private Label lblNombreEvento;
        private Label lblTitulo1;
        private PdfiumViewer.PdfViewer pdfViewerControl;
        private Panel panel1;
        private Button btnSave;
        private Button btnCloseVisor;
    }
}