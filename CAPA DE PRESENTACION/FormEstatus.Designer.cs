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
            panelTitulo = new Panel();
            btnGenerarReporte = new Button();
            btnNotificarCambios = new Button();
            tabControl1 = new TabControl();
            tabEstatus = new TabPage();
            tabHistorial = new TabPage();
            dgvActivos = new DataGridView();
            dgvHistorial = new DataGridView();
            lbllll = new Label();
            panelBotones.SuspendLayout();
            panelTitulo.SuspendLayout();
            tabControl1.SuspendLayout();
            tabEstatus.SuspendLayout();
            tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnNotificarCambios);
            panelBotones.Controls.Add(btnGenerarReporte);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelBotones.Location = new Point(0, 632);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(988, 121);
            panelBotones.TabIndex = 0;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lbllll);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(988, 117);
            panelTitulo.TabIndex = 1;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Anchor = AnchorStyles.None;
            btnGenerarReporte.Location = new Point(191, 28);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(206, 43);
            btnGenerarReporte.TabIndex = 0;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // btnNotificarCambios
            // 
            btnNotificarCambios.Anchor = AnchorStyles.None;
            btnNotificarCambios.Location = new Point(593, 28);
            btnNotificarCambios.Name = "btnNotificarCambios";
            btnNotificarCambios.Size = new Size(200, 43);
            btnNotificarCambios.TabIndex = 1;
            btnNotificarCambios.Text = "Notificar Cambios";
            btnNotificarCambios.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabEstatus);
            tabControl1.Controls.Add(tabHistorial);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 117);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(988, 515);
            tabControl1.TabIndex = 2;
            // 
            // tabEstatus
            // 
            tabEstatus.Controls.Add(dgvActivos);
            tabEstatus.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabEstatus.Location = new Point(4, 30);
            tabEstatus.Name = "tabEstatus";
            tabEstatus.Padding = new Padding(3);
            tabEstatus.Size = new Size(980, 481);
            tabEstatus.TabIndex = 0;
            tabEstatus.Text = "Estatus de Eventos";
            tabEstatus.UseVisualStyleBackColor = true;
            // 
            // tabHistorial
            // 
            tabHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabHistorial.Location = new Point(4, 30);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3);
            tabHistorial.Size = new Size(980, 481);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "Historial de Eventos";
            tabHistorial.UseVisualStyleBackColor = true;
            // 
            // dgvActivos
            // 
            dgvActivos.BackgroundColor = Color.WhiteSmoke;
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivos.Dock = DockStyle.Fill;
            dgvActivos.Location = new Point(3, 3);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.RowHeadersWidth = 51;
            dgvActivos.Size = new Size(974, 475);
            dgvActivos.TabIndex = 0;
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.WhiteSmoke;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(3, 3);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(974, 475);
            dgvHistorial.TabIndex = 0;
            // 
            // lbllll
            // 
            lbllll.Anchor = AnchorStyles.None;
            lbllll.AutoSize = true;
            lbllll.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllll.Location = new Point(360, 42);
            lbllll.Name = "lbllll";
            lbllll.Size = new Size(261, 23);
            lbllll.TabIndex = 0;
            lbllll.Text = "ESTATUS Y REPORTES";
            // 
            // FormEstatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 753);
            Controls.Add(tabControl1);
            Controls.Add(panelTitulo);
            Controls.Add(panelBotones);
            MaximumSize = new Size(1006, 800);
            MinimumSize = new Size(1006, 800);
            Name = "FormEstatus";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panelBotones.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabEstatus.ResumeLayout(false);
            tabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private Panel panelTitulo;
        private Button btnNotificarCambios;
        private Button btnGenerarReporte;
        private TabControl tabControl1;
        private TabPage tabEstatus;
        private TabPage tabHistorial;
        private DataGridView dgvActivos;
        private DataGridView dgvHistorial;
        private Label lbllll;
    }
}