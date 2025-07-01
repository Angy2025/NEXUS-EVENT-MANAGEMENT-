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
            lbldetalle = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            numericUpDown1 = new NumericUpDown();
            CBType = new ComboBox();
            dateTimePicker = new DateTimePicker();
            textPlace = new TextBox();
            textName = new TextBox();
            lblCapacidad = new Label();
            lbltipo = new Label();
            lblTitle = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.White;
            lblnombre.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lblnombre.ImageAlign = ContentAlignment.MiddleLeft;
            lblnombre.Location = new Point(146, 169);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(198, 22);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre Del Evento:";
            lblnombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbllugar
            // 
            lbllugar.AutoSize = true;
            lbllugar.BackColor = Color.White;
            lbllugar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lbllugar.ImageAlign = ContentAlignment.MiddleLeft;
            lbllugar.Location = new Point(146, 241);
            lbllugar.Name = "lbllugar";
            lbllugar.Size = new Size(217, 22);
            lbllugar.TabIndex = 1;
            lbllugar.Text = "Ubicacion Del Evento:";
            lbllugar.TextAlign = ContentAlignment.MiddleLeft;
            lbllugar.Click += label2_Click;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.White;
            lbldate.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lbldate.ImageAlign = ContentAlignment.MiddleLeft;
            lbldate.Location = new Point(146, 305);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(216, 22);
            lbldate.TabIndex = 2;
            lbldate.Text = "Fecha De Realizacion:";
            lbldate.TextAlign = ContentAlignment.MiddleLeft;
            lbldate.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(lbldetalle);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(CBType);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(textPlace);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(lblCapacidad);
            groupBox1.Controls.Add(lbltipo);
            groupBox1.Controls.Add(lblnombre);
            groupBox1.Controls.Add(lbllugar);
            groupBox1.Controls.Add(lbldate);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(883, 706);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lbldetalle
            // 
            lbldetalle.AutoSize = true;
            lbldetalle.BackColor = Color.White;
            lbldetalle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldetalle.Location = new Point(304, 35);
            lbldetalle.Name = "lbldetalle";
            lbldetalle.Size = new Size(0, 23);
            lbldetalle.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.CERRAR;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(488, 576);
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
            btnGuardar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnGuardar.Image = Properties.Resources.GUARDAR;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(176, 607);
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
            numericUpDown1.Font = new Font("Century", 10.8F, FontStyle.Bold);
            numericUpDown1.Location = new Point(470, 433);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(315, 29);
            numericUpDown1.TabIndex = 9;
            // 
            // CBType
            // 
            CBType.BackColor = Color.FromArgb(91, 186, 100);
            CBType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBType.Font = new Font("Century", 10.8F, FontStyle.Bold);
            CBType.FormattingEnabled = true;
            CBType.ImeMode = ImeMode.NoControl;
            CBType.Items.AddRange(new object[] { "Eventos Culturales", "Eventos Deportivos", "Eventos Tecnologicos ", "Eventos Cinematograficos ", "Eventos De Networinkg " });
            CBType.Location = new Point(470, 367);
            CBType.Name = "CBType";
            CBType.Size = new Size(315, 30);
            CBType.TabIndex = 8;
            CBType.SelectedIndexChanged += CBType_SelectedIndexChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dddd, dd 'de' MMMM 'de' yyyy, hh:mm tt";
            dateTimePicker.Font = new Font("Century", 10.8F, FontStyle.Bold);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(470, 305);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(315, 29);
            dateTimePicker.TabIndex = 7;
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textPlace
            // 
            textPlace.Font = new Font("Century", 10.8F, FontStyle.Bold);
            textPlace.Location = new Point(470, 241);
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(315, 29);
            textPlace.TabIndex = 6;
            // 
            // textName
            // 
            textName.Font = new Font("Century", 10.8F, FontStyle.Bold);
            textName.Location = new Point(470, 169);
            textName.Name = "textName";
            textName.Size = new Size(315, 29);
            textName.TabIndex = 5;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.White;
            lblCapacidad.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lblCapacidad.ImageAlign = ContentAlignment.MiddleLeft;
            lblCapacidad.Location = new Point(146, 433);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(207, 22);
            lblCapacidad.TabIndex = 4;
            lblCapacidad.Text = "Asistencia al Evento:";
            lblCapacidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.BackColor = Color.White;
            lbltipo.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lbltipo.ImageAlign = ContentAlignment.MiddleLeft;
            lbltipo.Location = new Point(146, 367);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(212, 22);
            lbltipo.TabIndex = 3;
            lbltipo.Text = "Categoria del Evento:";
            lbltipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(233, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(394, 40);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Agregar Nuevo Evento";
            // 
            // FormularioDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(883, 706);
            Controls.Add(groupBox1);
            Name = "FormularioDetalle";
            Text = "FormularioDetalle";
            Load += FormularioDetalle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblnombre;
        private Label lbllugar;
        private Label lbldate;
        private GroupBox groupBox1;
        private Label lblCapacidad;
        private Label lbltipo;
        private ComboBox CBType;
        private DateTimePicker dateTimePicker;
        private TextBox textPlace;
        private TextBox textName;
        private NumericUpDown numericUpDown1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lbldetalle;
        private Label lblTitle;
    }
}