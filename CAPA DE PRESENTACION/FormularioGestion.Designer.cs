namespace CAPA_DE_PRESENTACION
{
    partial class FormularioGestion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btneliminar = new Button();
            dgv2 = new DataGridView();
            label1 = new Label();
            GBEstadistica = new GroupBox();
            lblProximoEvento = new Label();
            lblTotalEventos = new Label();
            GBacciones = new GroupBox();
            btndeModificar = new Button();
            btndeAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            GBEstadistica.SuspendLayout();
            GBacciones.SuspendLayout();
            SuspendLayout();
            // 
            // btneliminar
            // 
            btneliminar.Anchor = AnchorStyles.None;
            btneliminar.BackColor = Color.White;
            btneliminar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.Black;
            btneliminar.Image = Properties.Resources.ELIMINAR;
            btneliminar.Location = new Point(495, 27);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(186, 60);
            btneliminar.TabIndex = 20;
            btneliminar.Text = "Eliminar Evento";
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // dgv2
            // 
            dgv2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv2.BackgroundColor = Color.FromArgb(220, 230, 229);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            dgv2.GridColor = Color.Black;
            dgv2.Location = new Point(50, 258);
            dgv2.Name = "dgv2";
            dgv2.ReadOnly = true;
            dgv2.RowHeadersWidth = 51;
            dgv2.Size = new Size(879, 345);
            dgv2.TabIndex = 17;
            dgv2.CellDoubleClick += dgv2_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(312, 39);
            label1.Name = "label1";
            label1.Size = new Size(401, 28);
            label1.TabIndex = 12;
            label1.Text = "GESTION DE EVENTOS NEXUS";
            // 
            // GBEstadistica
            // 
            GBEstadistica.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GBEstadistica.BackColor = Color.FromArgb(214, 168, 116);
            GBEstadistica.Controls.Add(lblProximoEvento);
            GBEstadistica.Controls.Add(lblTotalEventos);
            GBEstadistica.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBEstadistica.ForeColor = Color.Black;
            GBEstadistica.Location = new Point(80, 101);
            GBEstadistica.Name = "GBEstadistica";
            GBEstadistica.Size = new Size(818, 116);
            GBEstadistica.TabIndex = 21;
            GBEstadistica.TabStop = false;
            GBEstadistica.Text = "Control Rapido:";
            // 
            // lblProximoEvento
            // 
            lblProximoEvento.Anchor = AnchorStyles.None;
            lblProximoEvento.AutoSize = true;
            lblProximoEvento.FlatStyle = FlatStyle.Flat;
            lblProximoEvento.Font = new Font("Century", 10.2F, FontStyle.Bold);
            lblProximoEvento.Location = new Point(448, 54);
            lblProximoEvento.Name = "lblProximoEvento";
            lblProximoEvento.Size = new Size(197, 21);
            lblProximoEvento.TabIndex = 23;
            lblProximoEvento.Text = "Proximo Evento: N/A";
            // 
            // lblTotalEventos
            // 
            lblTotalEventos.AutoSize = true;
            lblTotalEventos.FlatStyle = FlatStyle.Flat;
            lblTotalEventos.Font = new Font("Century", 10.2F, FontStyle.Bold);
            lblTotalEventos.Location = new Point(54, 54);
            lblTotalEventos.Name = "lblTotalEventos";
            lblTotalEventos.Size = new Size(182, 21);
            lblTotalEventos.TabIndex = 22;
            lblTotalEventos.Text = "Total de Eventos: 0";
            // 
            // GBacciones
            // 
            GBacciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GBacciones.BackColor = Color.FromArgb(214, 168, 116);
            GBacciones.Controls.Add(btndeModificar);
            GBacciones.Controls.Add(btndeAgregar);
            GBacciones.Controls.Add(btneliminar);
            GBacciones.FlatStyle = FlatStyle.Flat;
            GBacciones.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBacciones.Location = new Point(92, 632);
            GBacciones.Name = "GBacciones";
            GBacciones.Size = new Size(750, 115);
            GBacciones.TabIndex = 25;
            GBacciones.TabStop = false;
            // 
            // btndeModificar
            // 
            btndeModificar.Anchor = AnchorStyles.None;
            btndeModificar.Location = new Point(275, 27);
            btndeModificar.Name = "btndeModificar";
            btndeModificar.Size = new Size(183, 62);
            btndeModificar.TabIndex = 22;
            btndeModificar.Text = "Modificar Evento";
            btndeModificar.UseVisualStyleBackColor = true;
            btndeModificar.Click += btndeModificar_Click;
            // 
            // btndeAgregar
            // 
            btndeAgregar.Anchor = AnchorStyles.None;
            btndeAgregar.Image = Properties.Resources.icons8_add_to_favorites_26;
            btndeAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btndeAgregar.Location = new Point(53, 27);
            btndeAgregar.Name = "btndeAgregar";
            btndeAgregar.Size = new Size(189, 62);
            btndeAgregar.TabIndex = 21;
            btndeAgregar.Text = "Agregar Evento";
            btndeAgregar.TextAlign = ContentAlignment.MiddleRight;
            btndeAgregar.UseVisualStyleBackColor = true;
            btndeAgregar.Click += btndeAgregar_Click;
            // 
            // FormularioGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = Properties.Resources.Stage;
            ClientSize = new Size(1006, 800);
            Controls.Add(GBacciones);
            Controls.Add(GBEstadistica);
            Controls.Add(dgv2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1006, 800);
            MinimumSize = new Size(1006, 800);
            Name = "FormularioGestion";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTION";
            WindowState = FormWindowState.Maximized;
            Load += frmGestionEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            GBEstadistica.ResumeLayout(false);
            GBEstadistica.PerformLayout();
            GBacciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btneliminar;
        private DataGridView dgv2;
        private Button btnbuscar;
        private Label label1;
        private GroupBox GBEstadistica;
        private Label lblTotalEventos;
        private Label lblProximoEvento;
        private GroupBox GBacciones;
        private Button btndeModificar;
        private Button btndeAgregar;
    }
}