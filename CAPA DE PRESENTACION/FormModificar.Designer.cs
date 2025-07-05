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
            panel1 = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.CERRAR;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(576, 591);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 44);
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
            btnGuardar.Location = new Point(255, 591);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 44);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Century", 10.8F, FontStyle.Bold);
            numericUpDown1.Location = new Point(471, 499);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(359, 29);
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
            CBType.Location = new Point(471, 433);
            CBType.Name = "CBType";
            CBType.Size = new Size(359, 30);
            CBType.TabIndex = 20;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dddd, dd 'de' MMMM 'de' yyyy, hh:mm tt";
            dateTimePicker.Font = new Font("Century", 10.8F, FontStyle.Bold);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(471, 371);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(359, 29);
            dateTimePicker.TabIndex = 19;
            // 
            // textPlace
            // 
            textPlace.Font = new Font("Century", 10.8F, FontStyle.Bold);
            textPlace.Location = new Point(471, 307);
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(359, 29);
            textPlace.TabIndex = 18;
            // 
            // textName
            // 
            textName.Font = new Font("Century", 10.8F, FontStyle.Bold);
            textName.Location = new Point(471, 235);
            textName.Name = "textName";
            textName.Size = new Size(359, 29);
            textName.TabIndex = 17;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.White;
            lblCapacidad.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lblCapacidad.ImageAlign = ContentAlignment.MiddleLeft;
            lblCapacidad.Location = new Point(191, 499);
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
            lbltipo.Location = new Point(191, 433);
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
            lblnombre.Location = new Point(191, 235);
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
            lbllugar.Location = new Point(191, 307);
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
            lbldate.Location = new Point(191, 371);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(216, 22);
            lbldate.TabIndex = 14;
            lbldate.Text = "Fecha De Realizacion:";
            lbldate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 211);
            panel1.TabIndex = 24;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(309, 155);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(331, 28);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Modificar Evento Existente";
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(883, 706);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
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
            ForeColor = Color.Black;
            MinimumSize = new Size(901, 753);
            Name = "FormModificar";
            Opacity = 0.85D;
            Text = "FormModificar";
            Load += FormModificar_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel panel1;
        private Label lblTitle;
    }
}