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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnclose2 = new Button();
            btneliminar = new Button();
            btnmod = new Button();
            btnagregar = new Button();
            button3 = new Button();
            button2 = new Button();
            dgv2 = new DataGridView();
            btnbuscar = new Button();
            textBox1 = new TextBox();
            lblbuscar = new Label();
            comBox = new ComboBox();
            label1 = new Label();
            txtTitulo2 = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_6y0fnb6y0fnb6y0f1;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome to...!";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(btnclose2);
            groupBox2.Controls.Add(btneliminar);
            groupBox2.Controls.Add(btnmod);
            groupBox2.Controls.Add(btnagregar);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dgv2);
            groupBox2.Controls.Add(btnbuscar);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblbuscar);
            groupBox2.Controls.Add(comBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(95, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1010, 654);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnclose2
            // 
            btnclose2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose2.ForeColor = Color.Black;
            btnclose2.Image = Properties.Resources.CERRAR;
            btnclose2.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose2.Location = new Point(777, 482);
            btnclose2.Name = "btnclose2";
            btnclose2.Size = new Size(94, 55);
            btnclose2.TabIndex = 11;
            btnclose2.Text = "Cerrar";
            btnclose2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnclose2.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.White;
            btneliminar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.Black;
            btneliminar.Image = Properties.Resources.ELIMINAR;
            btneliminar.Location = new Point(568, 482);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(166, 55);
            btneliminar.TabIndex = 10;
            btneliminar.Text = "Eliminar Evento";
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnmod
            // 
            btnmod.BackColor = Color.White;
            btnmod.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmod.ForeColor = Color.Black;
            btnmod.Image = Properties.Resources.MODIFICAR;
            btnmod.ImageAlign = ContentAlignment.MiddleLeft;
            btnmod.Location = new Point(332, 482);
            btnmod.Name = "btnmod";
            btnmod.Size = new Size(179, 55);
            btnmod.TabIndex = 9;
            btnmod.Text = "Modificar Evento";
            btnmod.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnmod.UseVisualStyleBackColor = false;
            btnmod.Click += btnmod_Click;
            // 
            // btnagregar
            // 
            btnagregar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.ForeColor = Color.Black;
            btnagregar.Image = Properties.Resources.ICONO_DE_AGREGAR;
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(120, 482);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(159, 55);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Agregar Nuevo";
            btnagregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(11, 31);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 23);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgv2
            // 
            dgv2.BackgroundColor = Color.White;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(120, 136);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersWidth = 51;
            dgv2.Size = new Size(767, 320);
            dgv2.TabIndex = 5;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.Image = Properties.Resources.BUSCAR;
            btnbuscar.Location = new Point(785, 76);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(102, 29);
            btnbuscar.TabIndex = 4;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(654, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 3;
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.BackColor = Color.White;
            lblbuscar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbuscar.ForeColor = Color.Black;
            lblbuscar.Location = new Point(469, 80);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(167, 20);
            lblbuscar.TabIndex = 2;
            lblbuscar.Text = "Buscar por Nombre:";
            // 
            // comBox
            // 
            comBox.AllowDrop = true;
            comBox.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comBox.FormattingEnabled = true;
            comBox.Items.AddRange(new object[] { "Culturales", "Deportivos", "Tecnologicos ", "Cinematograficos ", "Networinkg ", "Todos Los Eventos" });
            comBox.Location = new Point(273, 75);
            comBox.Name = "comBox";
            comBox.Size = new Size(176, 28);
            comBox.TabIndex = 1;
            comBox.SelectedIndexChanged += comBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(128, 78);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Eventos:";
            // 
            // txtTitulo2
            // 
            txtTitulo2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTitulo2.Location = new Point(427, 47);
            txtTitulo2.Name = "txtTitulo2";
            txtTitulo2.Size = new Size(376, 34);
            txtTitulo2.TabIndex = 2;
            txtTitulo2.Text = "    NEXUS EVENT MANAGEMENT";
            // 
            // FormularioGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1185, 778);
            Controls.Add(txtTitulo2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            ForeColor = Color.DarkBlue;
            Name = "FormularioGestion";
            Text = "GESTION";
            Load += frmGestionEventos_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTitulo2;
        private ComboBox comBox;
        private Label label1;
        private TextBox textBox1;
        private Label lblbuscar;
        private DataGridView dgv2;
        private Button btnbuscar;
        private Button btnclose2;
        private Button btneliminar;
        private Button btnmod;
        private Button btnagregar;
        private Button button3;
        private Button button2;
    }
}