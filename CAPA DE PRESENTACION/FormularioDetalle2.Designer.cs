namespace CAPA_DE_PRESENTACION
{
    partial class FormularioDetalle
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
            lblnombre = new Label();
            lbllugar = new Label();
            lbldate = new Label();
            groupBox1 = new GroupBox();
            txtTitulo = new TextBox();
            lbldetalle = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblCapacidad = new Label();
            lbltipo = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.White;
            lblnombre.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblnombre.Location = new Point(30, 74);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(77, 20);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre:";
            // 
            // lbllugar
            // 
            lbllugar.AutoSize = true;
            lbllugar.BackColor = Color.White;
            lbllugar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbllugar.Location = new Point(30, 130);
            lbllugar.Name = "lbllugar";
            lbllugar.Size = new Size(66, 20);
            lbllugar.TabIndex = 1;
            lbllugar.Text = "Lugar: ";
            lbllugar.Click += label2_Click;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.White;
            lbldate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbldate.Location = new Point(30, 189);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(118, 20);
            lbldate.TabIndex = 2;
            lbldate.Text = "Fecha y Hora:";
            lbldate.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(lbldetalle);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblCapacidad);
            groupBox1.Controls.Add(lbltipo);
            groupBox1.Controls.Add(lblnombre);
            groupBox1.Controls.Add(lbllugar);
            groupBox1.Controls.Add(lbldate);
            groupBox1.Location = new Point(111, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 471);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.White;
            txtTitulo.Enabled = false;
            txtTitulo.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ActiveCaptionText;
            txtTitulo.Location = new Point(131, 552);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(403, 43);
            txtTitulo.TabIndex = 13;
            txtTitulo.TabStop = false;
            txtTitulo.Text = "Nexus Event Management\r\n";
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            txtTitulo.WordWrap = false;
            // 
            // lbldetalle
            // 
            lbldetalle.AutoSize = true;
            lbldetalle.BackColor = Color.White;
            lbldetalle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldetalle.Location = new Point(128, 23);
            lbldetalle.Name = "lbldetalle";
            lbldetalle.Size = new Size(245, 23);
            lbldetalle.TabIndex = 12;
            lbldetalle.Text = "DETALLES DEL EVENTO";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Image = Properties.Resources.CERRAR;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(255, 357);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 42);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.GUARDAR;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(80, 356);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 43);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(182, 291);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.White;
            lblCapacidad.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblCapacidad.Location = new Point(30, 293);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(97, 20);
            lblCapacidad.TabIndex = 4;
            lblCapacidad.Text = "Capacidad:";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.BackColor = Color.White;
            lbltipo.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbltipo.Location = new Point(30, 244);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(132, 20);
            lbltipo.TabIndex = 3;
            lbltipo.Text = "Tipo de Evento:";
            // 
            // FormularioDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(724, 625);
            Controls.Add(txtTitulo);
            Controls.Add(groupBox1);
            Name = "FormularioDetalle";
            Text = "FormularioDetalle";
            Load += FormularioDetalle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lbllugar;
        private Label lbldate;
        private GroupBox groupBox1;
        private Label lblCapacidad;
        private Label lbltipo;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lbldetalle;
        private TextBox txtTitulo;
    }
}