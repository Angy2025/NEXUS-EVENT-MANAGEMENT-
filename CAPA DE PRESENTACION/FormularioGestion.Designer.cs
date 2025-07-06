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
            comBox = new ComboBox();
            label1 = new Label();
            GBEstadistica = new GroupBox();
            lblProximoEvento = new Label();
            lblTotalEventos = new Label();
            GBbusqueda = new GroupBox();
            lblFiltrar = new Label();
            GBacciones = new GroupBox();
            btndeModificar = new Button();
            btndeAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            GBEstadistica.SuspendLayout();
            GBbusqueda.SuspendLayout();
            GBacciones.SuspendLayout();
            SuspendLayout();
            // 
            // btneliminar
            // 
            btneliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btneliminar.BackColor = Color.White;
            btneliminar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.Black;
            btneliminar.Image = Properties.Resources.ELIMINAR;
            btneliminar.Location = new Point(468, 27);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(186, 60);
            btneliminar.TabIndex = 20;
            btneliminar.Text = "Eliminar Evento";
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // dgv2
            // 
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv2.BackgroundColor = Color.White;
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
            dgv2.Location = new Point(50, 365);
            dgv2.Name = "dgv2";
            dgv2.ReadOnly = true;
            dgv2.RowHeadersWidth = 51;
            dgv2.Size = new Size(770, 236);
            dgv2.TabIndex = 17;
            dgv2.CellDoubleClick += dgv2_CellDoubleClick;
            // 
            // comBox
            // 
            comBox.AllowDrop = true;
            comBox.Anchor = AnchorStyles.Top;
            comBox.BackColor = Color.Gainsboro;
            comBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comBox.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comBox.FormattingEnabled = true;
            comBox.Items.AddRange(new object[] { "Culturales", "Deportivos", "Tecnologicos ", "Cinematograficos ", "Networinkg ", "Todos Los Eventos" });
            comBox.Location = new Point(319, 40);
            comBox.Name = "comBox";
            comBox.Size = new Size(329, 28);
            comBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(237, 39);
            label1.Name = "label1";
            label1.Size = new Size(401, 28);
            label1.TabIndex = 12;
            label1.Text = "GESTION DE EVENTOS NEXUS";
            // 
            // GBEstadistica
            // 
            GBEstadistica.Controls.Add(lblProximoEvento);
            GBEstadistica.Controls.Add(lblTotalEventos);
            GBEstadistica.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBEstadistica.Location = new Point(94, 114);
            GBEstadistica.Name = "GBEstadistica";
            GBEstadistica.Size = new Size(701, 99);
            GBEstadistica.TabIndex = 21;
            GBEstadistica.TabStop = false;
            GBEstadistica.Text = "Estadisticas Rapidas:";
            // 
            // lblProximoEvento
            // 
            lblProximoEvento.AutoSize = true;
            lblProximoEvento.FlatStyle = FlatStyle.Flat;
            lblProximoEvento.Font = new Font("Century", 10.2F, FontStyle.Bold);
            lblProximoEvento.Location = new Point(325, 42);
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
            lblTotalEventos.Location = new Point(45, 42);
            lblTotalEventos.Name = "lblTotalEventos";
            lblTotalEventos.Size = new Size(182, 21);
            lblTotalEventos.TabIndex = 22;
            lblTotalEventos.Text = "Total de Eventos: 0";
            // 
            // GBbusqueda
            // 
            GBbusqueda.Controls.Add(lblFiltrar);
            GBbusqueda.Controls.Add(comBox);
            GBbusqueda.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBbusqueda.Location = new Point(94, 242);
            GBbusqueda.Name = "GBbusqueda";
            GBbusqueda.Size = new Size(701, 95);
            GBbusqueda.TabIndex = 24;
            GBbusqueda.TabStop = false;
            GBbusqueda.Text = "Busqueda y Filtros:";
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltrar.Location = new Point(45, 41);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(261, 22);
            lblFiltrar.TabIndex = 25;
            lblFiltrar.Text = "Filtrar por Tipo de Evento:";
            // 
            // GBacciones
            // 
            GBacciones.Controls.Add(btndeModificar);
            GBacciones.Controls.Add(btndeAgregar);
            GBacciones.Controls.Add(btneliminar);
            GBacciones.FlatStyle = FlatStyle.Flat;
            GBacciones.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBacciones.Location = new Point(94, 627);
            GBacciones.Name = "GBacciones";
            GBacciones.Size = new Size(679, 115);
            GBacciones.TabIndex = 25;
            GBacciones.TabStop = false;
            // 
            // btndeModificar
            // 
            btndeModificar.Location = new Point(248, 27);
            btndeModificar.Name = "btndeModificar";
            btndeModificar.Size = new Size(183, 62);
            btndeModificar.TabIndex = 22;
            btndeModificar.Text = "Modificar Evento";
            btndeModificar.UseVisualStyleBackColor = true;
            btndeModificar.Click += btndeModificar_Click;
            // 
            // btndeAgregar
            // 
            btndeAgregar.Location = new Point(26, 27);
            btndeAgregar.Name = "btndeAgregar";
            btndeAgregar.Size = new Size(179, 60);
            btndeAgregar.TabIndex = 21;
            btndeAgregar.Text = "Agregar Evento";
            btndeAgregar.UseVisualStyleBackColor = true;
            btndeAgregar.Click += btndeAgregar_Click;
            // 
            // FormularioGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.download;
            ClientSize = new Size(856, 800);
            Controls.Add(GBacciones);
            Controls.Add(GBbusqueda);
            Controls.Add(GBEstadistica);
            Controls.Add(dgv2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(856, 800);
            MinimumSize = new Size(856, 800);
            Name = "FormularioGestion";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTION";
            Load += frmGestionEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            GBEstadistica.ResumeLayout(false);
            GBEstadistica.PerformLayout();
            GBbusqueda.ResumeLayout(false);
            GBbusqueda.PerformLayout();
            GBacciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btneliminar;
        private DataGridView dgv2;
        private Button btnbuscar;
        private ComboBox comBox;
        private Label label1;
        private GroupBox GBEstadistica;
        private Label lblTotalEventos;
        private Label lblProximoEvento;
        private GroupBox GBbusqueda;
        private Label lblFiltrar;
        private GroupBox GBacciones;
        private Button btndeModificar;
        private Button btndeAgregar;
    }
}