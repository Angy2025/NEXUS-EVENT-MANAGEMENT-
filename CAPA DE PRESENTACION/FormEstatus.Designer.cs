namespace CAPA_DE_PRESENTACION
{
    partial class FormEstatus
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
            panelBotones = new Panel();
            btnGenerarReporte = new Button();
            panelTitulo = new Panel();
            lbllll = new Label();
            tabControl1 = new TabControl();
            tabEstatus = new TabPage();
            dgvActivos = new DataGridView();
            tabHistorial = new TabPage();
            dgvHistorial = new DataGridView();
            panelBotones.SuspendLayout();
            panelTitulo.SuspendLayout();
            tabControl1.SuspendLayout();
            tabEstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.Transparent;
            panelBotones.BackgroundImageLayout = ImageLayout.Stretch;
            panelBotones.Controls.Add(btnGenerarReporte);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelBotones.Location = new Point(0, 632);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(988, 121);
            panelBotones.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Anchor = AnchorStyles.None;
            btnGenerarReporte.Location = new Point(341, 25);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(242, 65);
            btnGenerarReporte.TabIndex = 0;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.Transparent;
            panelTitulo.BackgroundImageLayout = ImageLayout.Stretch;
            panelTitulo.Controls.Add(lbllll);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(988, 180);
            panelTitulo.TabIndex = 1;
            // 
            // lbllll
            // 
            lbllll.Anchor = AnchorStyles.None;
            lbllll.AutoSize = true;
            lbllll.BackColor = Color.White;
            lbllll.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbllll.ForeColor = Color.Black;
            lbllll.Location = new Point(308, 68);
            lbllll.Name = "lbllll";
            lbllll.Size = new Size(364, 33);
            lbllll.TabIndex = 0;
            lbllll.Text = "ESTATUS Y REPORTES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabEstatus);
            tabControl1.Controls.Add(tabHistorial);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 180);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(988, 452);
            tabControl1.TabIndex = 2;
            // 
            // tabEstatus
            // 
            tabEstatus.BackColor = Color.Black;
            tabEstatus.Controls.Add(dgvActivos);
            tabEstatus.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabEstatus.Location = new Point(4, 30);
            tabEstatus.Name = "tabEstatus";
            tabEstatus.Padding = new Padding(3);
            tabEstatus.Size = new Size(980, 418);
            tabEstatus.TabIndex = 0;
            tabEstatus.Text = "Estatus de Eventos";
            // 
            // dgvActivos
            // 
            dgvActivos.BackgroundColor = Color.FromArgb(153, 156, 166);
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivos.Dock = DockStyle.Fill;
            dgvActivos.Location = new Point(3, 3);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.RowHeadersWidth = 51;
            dgvActivos.Size = new Size(974, 412);
            dgvActivos.TabIndex = 0;
            // 
            // tabHistorial
            // 
            tabHistorial.BackColor = Color.Black;
            tabHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabHistorial.Location = new Point(4, 30);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3);
            tabHistorial.Size = new Size(980, 418);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "Historial de Eventos";
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.FromArgb(233, 221, 207);
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(3, 3);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(974, 412);
            dgvHistorial.TabIndex = 0;
            // 
            // FormEstatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__9_;
            ClientSize = new Size(988, 753);
            Controls.Add(tabControl1);
            Controls.Add(panelTitulo);
            Controls.Add(panelBotones);
            MaximumSize = new Size(1006, 800);
            MinimumSize = new Size(1006, 800);
            Name = "FormEstatus";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormEstatus_Load;
            panelBotones.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabEstatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            tabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private Panel panelTitulo;
        private Button btnGenerarReporte;
        private TabControl tabControl1;
        private TabPage tabEstatus;
        private TabPage tabHistorial;
        private DataGridView dgvActivos;
        private DataGridView dgvHistorial;
        private Label lbllll;
    }
}