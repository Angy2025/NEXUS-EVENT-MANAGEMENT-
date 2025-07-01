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
            GBox = new GroupBox();
            btnclose2 = new Button();
            btneliminar = new Button();
            btnmod = new Button();
            btnagregar = new Button();
            dgv2 = new DataGridView();
            btnbuscar = new Button();
            textBox1 = new TextBox();
            lblbuscar = new Label();
            comBox = new ComboBox();
            label1 = new Label();
            GBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // GBox
            // 
            GBox.BackColor = Color.FromArgb(229, 85, 7);
            GBox.Controls.Add(btnclose2);
            GBox.Controls.Add(btneliminar);
            GBox.Controls.Add(btnmod);
            GBox.Controls.Add(btnagregar);
            GBox.Controls.Add(dgv2);
            GBox.Controls.Add(btnbuscar);
            GBox.Controls.Add(textBox1);
            GBox.Controls.Add(lblbuscar);
            GBox.Controls.Add(comBox);
            GBox.Controls.Add(label1);
            GBox.ForeColor = Color.Black;
            GBox.Location = new Point(32, 31);
            GBox.Name = "GBox";
            GBox.Size = new Size(810, 634);
            GBox.TabIndex = 1;
            GBox.TabStop = false;
            GBox.Enter += GBox_Enter;
            // 
            // btnclose2
            // 
            btnclose2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnclose2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose2.ForeColor = Color.Black;
            btnclose2.Image = Properties.Resources.CERRAR;
            btnclose2.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose2.Location = new Point(30, 547);
            btnclose2.Name = "btnclose2";
            btnclose2.Size = new Size(90, 45);
            btnclose2.TabIndex = 11;
            btnclose2.Text = "Cerrar";
            btnclose2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnclose2.UseVisualStyleBackColor = true;
            btnclose2.Click += btnclose2_Click;
            // 
            // btneliminar
            // 
            btneliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btneliminar.BackColor = Color.White;
            btneliminar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.Black;
            btneliminar.Image = Properties.Resources.ELIMINAR;
            btneliminar.Location = new Point(658, 547);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(115, 45);
            btneliminar.TabIndex = 10;
            btneliminar.Text = "Eliminar Evento";
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnmod
            // 
            btnmod.Anchor = AnchorStyles.Bottom;
            btnmod.BackColor = Color.White;
            btnmod.Font = new Font("Century", 9F, FontStyle.Bold);
            btnmod.ForeColor = Color.Black;
            btnmod.Image = Properties.Resources.MODIFICAR;
            btnmod.ImageAlign = ContentAlignment.MiddleLeft;
            btnmod.Location = new Point(504, 451);
            btnmod.Name = "btnmod";
            btnmod.Size = new Size(151, 53);
            btnmod.TabIndex = 9;
            btnmod.Text = "Modificar Evento";
            btnmod.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnmod.UseVisualStyleBackColor = false;
            btnmod.Click += btnmod_Click;
            // 
            // btnagregar
            // 
            btnagregar.Anchor = AnchorStyles.Bottom;
            btnagregar.Font = new Font("Century", 9F, FontStyle.Bold);
            btnagregar.ForeColor = Color.Black;
            btnagregar.Image = Properties.Resources.ICONO_DE_AGREGAR;
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(122, 451);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(131, 53);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Agregar Nuevo";
            btnagregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // dgv2
            // 
            dgv2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv2.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuBar;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(49, 131);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersWidth = 51;
            dgv2.Size = new Size(704, 298);
            dgv2.TabIndex = 5;
            dgv2.CellContentClick += dgv2_CellContentClick;
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top;
            btnbuscar.BackColor = Color.White;
            btnbuscar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.Image = Properties.Resources.BUSCAR;
            btnbuscar.Location = new Point(693, 72);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(102, 29);
            btnbuscar.TabIndex = 4;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(556, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblbuscar
            // 
            lblbuscar.Anchor = AnchorStyles.Top;
            lblbuscar.AutoSize = true;
            lblbuscar.BackColor = Color.White;
            lblbuscar.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbuscar.ForeColor = Color.Black;
            lblbuscar.Location = new Point(361, 75);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(189, 21);
            lblbuscar.TabIndex = 2;
            lblbuscar.Text = "Buscar por Nombre:";
            // 
            // comBox
            // 
            comBox.AllowDrop = true;
            comBox.Anchor = AnchorStyles.Top;
            comBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comBox.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comBox.FormattingEnabled = true;
            comBox.Items.AddRange(new object[] { "Culturales", "Deportivos", "Tecnologicos ", "Cinematograficos ", "Networinkg ", "Todos Los Eventos" });
            comBox.Location = new Point(175, 71);
            comBox.Name = "comBox";
            comBox.Size = new Size(176, 28);
            comBox.TabIndex = 1;
            comBox.SelectedIndexChanged += comBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 75);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Eventos:";
            // 
            // FormularioGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(873, 688);
            Controls.Add(GBox);
            ForeColor = Color.Black;
            Name = "FormularioGestion";
            Text = "GESTION";
            Load += frmGestionEventos_Load;
            GBox.ResumeLayout(false);
            GBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GBox;
        private Label label1;
        private TextBox textBox1;
        private Label lblbuscar;
        private DataGridView dgv2;
        private Button btnbuscar;
        private Button btnclose2;
        private Button btneliminar;
        private Button btnmod;
        private Button btnagregar;
        private ComboBox comBox;
    }
}