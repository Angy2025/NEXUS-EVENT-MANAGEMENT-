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
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // btnclose2
            // 
            btnclose2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnclose2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose2.ForeColor = Color.Black;
            btnclose2.Image = Properties.Resources.CERRAR;
            btnclose2.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose2.Location = new Point(64, 560);
            btnclose2.Name = "btnclose2";
            btnclose2.Size = new Size(90, 45);
            btnclose2.TabIndex = 21;
            btnclose2.Text = "Cerrar";
            btnclose2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnclose2.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btneliminar.BackColor = Color.White;
            btneliminar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.Black;
            btneliminar.Image = Properties.Resources.ELIMINAR;
            btneliminar.Location = new Point(692, 560);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(115, 45);
            btneliminar.TabIndex = 20;
            btneliminar.Text = "Eliminar Evento";
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnmod
            // 
            btnmod.Anchor = AnchorStyles.Bottom;
            btnmod.BackColor = Color.White;
            btnmod.Font = new Font("Century", 9F, FontStyle.Bold);
            btnmod.ForeColor = Color.Black;
            btnmod.Image = Properties.Resources.MODIFICAR;
            btnmod.ImageAlign = ContentAlignment.MiddleLeft;
            btnmod.Location = new Point(538, 464);
            btnmod.Name = "btnmod";
            btnmod.Size = new Size(151, 53);
            btnmod.TabIndex = 19;
            btnmod.Text = "Modificar Evento";
            btnmod.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnmod.UseVisualStyleBackColor = false;
            // 
            // btnagregar
            // 
            btnagregar.Anchor = AnchorStyles.Bottom;
            btnagregar.Font = new Font("Century", 9F, FontStyle.Bold);
            btnagregar.ForeColor = Color.Black;
            btnagregar.Image = Properties.Resources.ICONO_DE_AGREGAR;
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(156, 464);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(131, 53);
            btnagregar.TabIndex = 18;
            btnagregar.Text = "Agregar Nuevo";
            btnagregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregar.UseVisualStyleBackColor = true;
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
            dgv2.Location = new Point(83, 144);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersWidth = 51;
            dgv2.Size = new Size(704, 298);
            dgv2.TabIndex = 17;
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top;
            btnbuscar.BackColor = Color.White;
            btnbuscar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.Image = Properties.Resources.BUSCAR;
            btnbuscar.Location = new Point(727, 85);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(102, 29);
            btnbuscar.TabIndex = 16;
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(590, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 15;
            // 
            // lblbuscar
            // 
            lblbuscar.Anchor = AnchorStyles.Top;
            lblbuscar.AutoSize = true;
            lblbuscar.BackColor = Color.White;
            lblbuscar.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbuscar.ForeColor = Color.Black;
            lblbuscar.Location = new Point(395, 88);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(189, 21);
            lblbuscar.TabIndex = 14;
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
            comBox.Location = new Point(209, 84);
            comBox.Name = "comBox";
            comBox.Size = new Size(176, 28);
            comBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(44, 88);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 12;
            label1.Text = "Tipo de Eventos:";
            // 
            // FormularioGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(873, 688);
            Controls.Add(btnclose2);
            Controls.Add(btneliminar);
            Controls.Add(btnmod);
            Controls.Add(btnagregar);
            Controls.Add(dgv2);
            Controls.Add(btnbuscar);
            Controls.Add(textBox1);
            Controls.Add(lblbuscar);
            Controls.Add(comBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioGestion";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTION";
            Load += frmGestionEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclose2;
        private Button btneliminar;
        private Button btnmod;
        private Button btnagregar;
        private DataGridView dgv2;
        private Button btnbuscar;
        private TextBox textBox1;
        private Label lblbuscar;
        private ComboBox comBox;
        private Label label1;
    }
}