namespace CAPA_DE_PRESENTACION
{
    partial class FormularioEstatusYReportes
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
            PanTop = new Panel();
            lblPanTop = new Label();
            tabControlPrincipal = new TabControl();
            tabActivos = new TabPage();
            GBPlanificadosConformados = new GroupBox();
            panel1 = new Panel();
            btnGenerar = new Button();
            btnNotificacion = new Button();
            dgvActivos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            tabHistorial = new TabPage();
            GBHistorialEventos = new GroupBox();
            panellll = new Panel();
            btnGenerarReporte = new Button();
            btnNotificar = new Button();
            dgvHistorial = new DataGridView();
            colHistorialId = new DataGridViewTextBoxColumn();
            colHNombre = new DataGridViewTextBoxColumn();
            colHEstatus = new DataGridViewTextBoxColumn();
            panelActions = new Panel();
            btnNotificarCambio = new Button();
            btnGenerarReporte2 = new Button();
            PanTop.SuspendLayout();
            tabControlPrincipal.SuspendLayout();
            tabActivos.SuspendLayout();
            GBPlanificadosConformados.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            tabHistorial.SuspendLayout();
            GBHistorialEventos.SuspendLayout();
            panellll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // PanTop
            // 
            PanTop.BackColor = Color.Black;
            PanTop.BackgroundImage = Properties.Resources.download__5_1;
            PanTop.BackgroundImageLayout = ImageLayout.Center;
            PanTop.Controls.Add(lblPanTop);
            PanTop.Dock = DockStyle.Top;
            PanTop.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanTop.ForeColor = Color.White;
            PanTop.Location = new Point(0, 0);
            PanTop.Name = "PanTop";
            PanTop.Size = new Size(988, 81);
            PanTop.TabIndex = 0;
 //           PanTop.Paint += PanTop_Paint;
            // 
            // lblPanTop
            // 
            lblPanTop.Anchor = AnchorStyles.None;
            lblPanTop.AutoSize = true;
            lblPanTop.Location = new Point(278, 28);
            lblPanTop.Name = "lblPanTop";
            lblPanTop.Size = new Size(410, 23);
            lblPanTop.TabIndex = 0;
            lblPanTop.Text = "GESTIÓN DE ESTATUS Y REPORTES";
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabActivos);
            tabControlPrincipal.Controls.Add(tabHistorial);
            tabControlPrincipal.Dock = DockStyle.Fill;
            tabControlPrincipal.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlPrincipal.Location = new Point(0, 81);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(988, 672);
            tabControlPrincipal.TabIndex = 1;
   //         tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            // 
            // tabActivos
            // 
            tabActivos.BackColor = Color.White;
            tabActivos.Controls.Add(GBPlanificadosConformados);
            tabActivos.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabActivos.Location = new Point(4, 27);
            tabActivos.Name = "tabActivos";
            tabActivos.Padding = new Padding(3);
            tabActivos.Size = new Size(980, 641);
            tabActivos.TabIndex = 0;
            tabActivos.Text = "Estatus De Eventos";
            // 
            // GBPlanificadosConformados
            // 
            GBPlanificadosConformados.BackColor = Color.Gainsboro;
            GBPlanificadosConformados.Controls.Add(panel1);
            GBPlanificadosConformados.Controls.Add(dgvActivos);
            GBPlanificadosConformados.Dock = DockStyle.Fill;
            GBPlanificadosConformados.Location = new Point(3, 3);
            GBPlanificadosConformados.Name = "GBPlanificadosConformados";
            GBPlanificadosConformados.Size = new Size(974, 635);
            GBPlanificadosConformados.TabIndex = 0;
            GBPlanificadosConformados.TabStop = false;
            GBPlanificadosConformados.Text = "Eventos Planificados y Confirmados";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.download__5_2;
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(btnNotificacion);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 504);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 128);
            panel1.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.None;
            btnGenerar.ForeColor = Color.Black;
            btnGenerar.Location = new Point(116, 46);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(207, 55);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerarReporte_Click;
            // 
            // btnNotificacion
            // 
            btnNotificacion.Anchor = AnchorStyles.None;
            btnNotificacion.ForeColor = Color.Black;
            btnNotificacion.Location = new Point(658, 46);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(233, 55);
            btnNotificacion.TabIndex = 0;
            btnNotificacion.Text = "Notificar Cambios";
            btnNotificacion.UseVisualStyleBackColor = true;
            btnNotificacion.Click += btnNotificarCambio_Click;
            // 
            // dgvActivos
            // 
            dgvActivos.BackgroundColor = Color.Gainsboro;
            dgvActivos.BorderStyle = BorderStyle.None;
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colEstatus });
            dgvActivos.Cursor = Cursors.Hand;
            dgvActivos.Dock = DockStyle.Fill;
            dgvActivos.Location = new Point(3, 24);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.RowHeadersWidth = 51;
            dgvActivos.Size = new Size(968, 608);
            dgvActivos.TabIndex = 1;
            dgvActivos.SelectionChanged += dgvActivos_SelectionChanged;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colId.DataPropertyName = "Id";
            colId.FillWeight = 10F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.DataPropertyName = "Nombre";
            colNombre.FillWeight = 60F;
            colNombre.HeaderText = "Nombre Del Evento";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            // 
            // colEstatus
            // 
            colEstatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEstatus.DataPropertyName = "Estatus";
            colEstatus.FillWeight = 30F;
            colEstatus.HeaderText = "Estatus";
            colEstatus.MinimumWidth = 6;
            colEstatus.Name = "colEstatus";
            // 
            // tabHistorial
            // 
            tabHistorial.BackColor = Color.Gainsboro;
            tabHistorial.Controls.Add(GBHistorialEventos);
            tabHistorial.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabHistorial.ForeColor = Color.White;
            tabHistorial.Location = new Point(4, 27);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3);
            tabHistorial.Size = new Size(980, 641);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "Historial De Eventos";
            // 
            // GBHistorialEventos
            // 
            GBHistorialEventos.BackColor = Color.Gainsboro;
            GBHistorialEventos.Controls.Add(panellll);
            GBHistorialEventos.Controls.Add(dgvHistorial);
            GBHistorialEventos.Dock = DockStyle.Fill;
            GBHistorialEventos.Location = new Point(3, 3);
            GBHistorialEventos.Name = "GBHistorialEventos";
            GBHistorialEventos.Size = new Size(974, 635);
            GBHistorialEventos.TabIndex = 0;
            GBHistorialEventos.TabStop = false;
            GBHistorialEventos.Text = "Historial de Eventos (Realizados y Cancelados)";
            // 
            // panellll
            // 
            panellll.BackgroundImage = Properties.Resources.download__5_2;
            panellll.Controls.Add(btnGenerarReporte);
            panellll.Controls.Add(btnNotificar);
            panellll.Dock = DockStyle.Bottom;
            panellll.Location = new Point(3, 504);
            panellll.Name = "panellll";
            panellll.Size = new Size(968, 128);
            panellll.TabIndex = 1;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Anchor = AnchorStyles.None;
            btnGenerarReporte.ForeColor = Color.Black;
            btnGenerarReporte.Location = new Point(104, 30);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(194, 55);
            btnGenerarReporte.TabIndex = 1;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // btnNotificar
            // 
            btnNotificar.Anchor = AnchorStyles.None;
            btnNotificar.ForeColor = Color.Black;
            btnNotificar.Location = new Point(626, 30);
            btnNotificar.Name = "btnNotificar";
            btnNotificar.Size = new Size(211, 55);
            btnNotificar.TabIndex = 0;
            btnNotificar.Text = "Notificar Cambios";
            btnNotificar.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.Gainsboro;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { colHistorialId, colHNombre, colHEstatus });
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(3, 24);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(968, 608);
            dgvHistorial.TabIndex = 0;
            dgvHistorial.SelectionChanged += dgvHistorial_SelectionChanged;
            // 
            // colHistorialId
            // 
            colHistorialId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHistorialId.DataPropertyName = "Id";
            colHistorialId.FillWeight = 10F;
            colHistorialId.HeaderText = "ID";
            colHistorialId.MinimumWidth = 6;
            colHistorialId.Name = "colHistorialId";
            // 
            // colHNombre
            // 
            colHNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHNombre.DataPropertyName = "Nombre";
            colHNombre.FillWeight = 60F;
            colHNombre.HeaderText = "Nombre del Evento";
            colHNombre.MinimumWidth = 6;
            colHNombre.Name = "colHNombre";
            // 
            // colHEstatus
            // 
            colHEstatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHEstatus.DataPropertyName = "Estatus";
            colHEstatus.FillWeight = 40F;
            colHEstatus.HeaderText = "Estatus";
            colHEstatus.MinimumWidth = 6;
            colHEstatus.Name = "colHEstatus";
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelActions.BackColor = Color.Black;
            panelActions.BackgroundImage = Properties.Resources.download__5_;
            panelActions.BackgroundImageLayout = ImageLayout.Center;
            panelActions.Controls.Add(btnNotificarCambio);
            panelActions.Controls.Add(btnGenerarReporte2);
            panelActions.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelActions.Location = new Point(0, 628);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(988, 125);
            panelActions.TabIndex = 2;
            // 
            // btnNotificarCambio
            // 
            btnNotificarCambio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNotificarCambio.Location = new Point(579, 33);
            btnNotificarCambio.Name = "btnNotificarCambio";
            btnNotificarCambio.Size = new Size(200, 59);
            btnNotificarCambio.TabIndex = 4;
            btnNotificarCambio.Text = "Notificar Cambios";
            btnNotificarCambio.UseVisualStyleBackColor = true;
            btnNotificarCambio.Click += btnNotificarCambio_Click;
            // 
            // btnGenerarReporte2
            // 
            btnGenerarReporte2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerarReporte2.Location = new Point(183, 33);
            btnGenerarReporte2.Name = "btnGenerarReporte2";
            btnGenerarReporte2.Size = new Size(178, 55);
            btnGenerarReporte2.TabIndex = 3;
            btnGenerarReporte2.Text = "Generar Reporte";
            btnGenerarReporte2.UseVisualStyleBackColor = true;
            btnGenerarReporte2.Click += btnGenerarReporte_Click;
            // 
            // FormularioEstatusYReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 753);
            Controls.Add(tabControlPrincipal);
            Controls.Add(PanTop);
            Controls.Add(panelActions);
            MinimumSize = new Size(1006, 800);
            Name = "FormularioEstatusYReportes";
            Text = "FormularioEstatusYReportes";
            WindowState = FormWindowState.Maximized;
            PanTop.ResumeLayout(false);
            PanTop.PerformLayout();
            tabControlPrincipal.ResumeLayout(false);
            tabActivos.ResumeLayout(false);
            GBPlanificadosConformados.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            tabHistorial.ResumeLayout(false);
            GBHistorialEventos.ResumeLayout(false);
            panellll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanTop;
        private Label lblPanTop;
        private TabControl tabControlPrincipal;
        private TabPage tabActivos;
        private TabPage tabHistorial;
        private Panel panelActions;
        private GroupBox GBPlanificadosConformados;
        private Button btnNotificarCambio;
        private Button btnGenerarReporte2;
        private Button btnGenerarReporte;
        private Button btnNotificar;
        private GroupBox GBHistorialEventos;
        private DataGridView dgvHistorial;
        private DataGridView dgvActivos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colEstatus;
        private Panel panellll;
        private Panel panel1;
        private Button btnGenerar;
        private Button btnNotificacion;
        private DataGridViewTextBoxColumn colHistorialId;
        private DataGridViewTextBoxColumn colHNombre;
        private DataGridViewTextBoxColumn colHEstatus;
    }
}