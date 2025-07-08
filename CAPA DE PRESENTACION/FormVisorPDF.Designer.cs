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
            PanelEncabezado = new Panel();
            lblTitulo1 = new Label();
            lblNombreEvento = new Label();
            pdfViewerControl = new PdfiumViewer.PdfViewer();
            panel1 = new Panel();
            btnSave = new Button();
            btnCloseVisor = new Button();
            PanelEncabezado.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelEncabezado
            // 
            PanelEncabezado.BackColor = Color.Transparent;
            PanelEncabezado.Controls.Add(lblTitulo1);
            PanelEncabezado.Controls.Add(lblNombreEvento);
            PanelEncabezado.Dock = DockStyle.Top;
            PanelEncabezado.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanelEncabezado.ForeColor = Color.Black;
            PanelEncabezado.Location = new Point(0, 0);
            PanelEncabezado.Name = "PanelEncabezado";
            PanelEncabezado.Size = new Size(988, 136);
            PanelEncabezado.TabIndex = 0;
            // 
            // lblTitulo1
            // 
            lblTitulo1.Anchor = AnchorStyles.None;
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo1.Location = new Point(198, 39);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(616, 23);
            lblTitulo1.TabIndex = 0;
            lblTitulo1.Text = "VISOR DE REPORTES --- NEXUS EVENT MANAGEMENT";
            // 
            // lblNombreEvento
            // 
            lblNombreEvento.Anchor = AnchorStyles.None;
            lblNombreEvento.AutoSize = true;
            lblNombreEvento.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreEvento.Location = new Point(57, 91);
            lblNombreEvento.Name = "lblNombreEvento";
            lblNombreEvento.Size = new Size(342, 23);
            lblNombreEvento.TabIndex = 1;
            lblNombreEvento.Text = "Reporte Para: Torneo de Ajedrez";
            // 
            // pdfViewerControl
            // 
            pdfViewerControl.BackColor = Color.Transparent;
            pdfViewerControl.Dock = DockStyle.Fill;
            pdfViewerControl.Location = new Point(0, 136);
            pdfViewerControl.Margin = new Padding(4, 5, 4, 5);
            pdfViewerControl.Name = "pdfViewerControl";
            pdfViewerControl.Size = new Size(988, 617);
            pdfViewerControl.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCloseVisor);
            panel1.Location = new Point(0, 628);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 125);
            panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(132, 41);
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
            btnCloseVisor.Location = new Point(649, 41);
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
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 753);
            Controls.Add(panel1);
            Controls.Add(pdfViewerControl);
            Controls.Add(PanelEncabezado);
            ForeColor = Color.Black;
            MinimumSize = new Size(1006, 800);
            Name = "FormVisorPDF";
            WindowState = FormWindowState.Maximized;
//            Load += FormVisorPDF_Load_1;
            PanelEncabezado.ResumeLayout(false);
            PanelEncabezado.PerformLayout();
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