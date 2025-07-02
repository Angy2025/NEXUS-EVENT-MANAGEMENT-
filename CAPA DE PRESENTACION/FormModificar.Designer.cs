namespace CAPA_DE_PRESENTACION
{
    partial class FormModificar
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnCancelar = new Button();
            btnGuardar = new Button();
            numericUpDown1 = new NumericUpDown();
            CBType = new ComboBox();
            dateTimePicker = new DateTimePicker();
            textPlace = new TextBox();
            textName = new TextBox();
            lblCapacidad = new Label();
            lbltipo = new Label();
            lblnombre = new Label();
            lbllugar = new Label();
            lbldate = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(253, 155, 22);
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 85;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(883, 189);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Modificar Evento Existente";
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.CERRAR;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(538, 583);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 51);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnGuardar.Image = Properties.Resources.GUARDAR;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(190, 586);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 44);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Century", 10.8F, FontStyle.Bold);
            numericUpDown1.Location = new Point(463, 483);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(315, 29);
            numericUpDown1.TabIndex = 21;
            // 
            // CBType
            // 
            CBType.BackColor = Color.FromArgb(91, 186, 100);
            CBType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBType.Font = new Font("Century", 10.8F, FontStyle.Bold);
            CBType.FormattingEnabled = true;
            CBType.ImeMode = ImeMode.NoControl;
            CBType.Items.AddRange(new object[] { "Eventos Culturales", "Eventos Deportivos", "Eventos Tecnologicos ", "Eventos Cinematograficos ", "Eventos De Networinkg " });
            CBType.Location = new Point(463, 417);
            CBType.Name = "CBType";
            CBType.Size = new Size(315, 30);
            CBType.TabIndex = 20;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dddd, dd 'de' MMMM 'de' yyyy, hh:mm tt";
            dateTimePicker.Font = new Font("Century", 10.8F, FontStyle.Bold);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(463, 355);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(315, 29);
            dateTimePicker.TabIndex = 19;
            // 
            // textPlace
            // 
            textPlace.Font = new Font("Century", 10.8F, FontStyle.Bold);
            textPlace.Location = new Point(463, 291);
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(315, 29);
            textPlace.TabIndex = 18;
            // 
            // textName
            // 
            textName.Font = new Font("Century", 10.8F, FontStyle.Bold);
            textName.Location = new Point(463, 219);
            textName.Name = "textName";
            textName.Size = new Size(315, 29);
            textName.TabIndex = 17;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.White;
            lblCapacidad.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lblCapacidad.ImageAlign = ContentAlignment.MiddleLeft;
            lblCapacidad.Location = new Point(139, 483);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(207, 22);
            lblCapacidad.TabIndex = 16;
            lblCapacidad.Text = "Asistencia al Evento:";
            lblCapacidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.BackColor = Color.White;
            lbltipo.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lbltipo.ImageAlign = ContentAlignment.MiddleLeft;
            lbltipo.Location = new Point(139, 417);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(212, 22);
            lbltipo.TabIndex = 15;
            lbltipo.Text = "Categoria del Evento:";
            lbltipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.White;
            lblnombre.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lblnombre.ImageAlign = ContentAlignment.MiddleLeft;
            lblnombre.Location = new Point(139, 219);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(198, 22);
            lblnombre.TabIndex = 12;
            lblnombre.Text = "Nombre Del Evento:";
            lblnombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbllugar
            // 
            lbllugar.AutoSize = true;
            lbllugar.BackColor = Color.White;
            lbllugar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lbllugar.ImageAlign = ContentAlignment.MiddleLeft;
            lbllugar.Location = new Point(139, 291);
            lbllugar.Name = "lbllugar";
            lbllugar.Size = new Size(217, 22);
            lbllugar.TabIndex = 13;
            lbllugar.Text = "Ubicacion Del Evento:";
            lbllugar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.White;
            lbldate.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lbldate.ImageAlign = ContentAlignment.MiddleLeft;
            lbldate.Location = new Point(139, 355);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(216, 22);
            lbldate.TabIndex = 14;
            lbldate.Text = "Fecha De Realizacion:";
            lbldate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(883, 706);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(numericUpDown1);
            Controls.Add(CBType);
            Controls.Add(dateTimePicker);
            Controls.Add(textPlace);
            Controls.Add(textName);
            Controls.Add(lblCapacidad);
            Controls.Add(lbltipo);
            Controls.Add(lblnombre);
            Controls.Add(lbllugar);
            Controls.Add(lbldate);
            Controls.Add(iconButton1);
            MinimumSize = new Size(901, 753);
            Name = "FormModificar";
            Opacity = 0.85D;
            Text = "FormModificar";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal FontAwesome.Sharp.IconButton iconButton1;
        private Button btnCancelar;
        private Button btnGuardar;
        private NumericUpDown numericUpDown1;
        private ComboBox CBType;
        private DateTimePicker dateTimePicker;
        private TextBox textPlace;
        private TextBox textName;
        private Label lblCapacidad;
        private Label lbltipo;
        private Label lblnombre;
        private Label lbllugar;
        private Label lbldate;
    }
}