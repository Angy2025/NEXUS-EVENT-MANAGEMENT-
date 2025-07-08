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
            panel1 = new Panel();
            lblTitle = new Label();
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
            lblnombre.Location = new Point(60, 281);
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
            lbllugar.Location = new Point(60, 349);
            lbllugar.Name = "lbllugar";
            lbllugar.Size = new Size(217, 22);
            lbllugar.TabIndex = 1;
            lbllugar.Text = "Ubicacion Del Evento:";
            lbllugar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.White;
            lbldate.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lbldate.ImageAlign = ContentAlignment.MiddleLeft;
            lbldate.Location = new Point(60, 401);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(216, 22);
            lbldate.TabIndex = 2;
            lbldate.Text = "Fecha De Realizacion:";
            lbldate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 154, 0);
            groupBox1.BackgroundImage = Properties.Resources.The_Diplomat_of_the_Year_Award__1_1;
            groupBox1.Controls.Add(panel1);
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
            groupBox1.Size = new Size(1006, 800);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 211);
            panel1.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(385, 141);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(394, 40);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Agregar Nuevo Evento";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbldetalle
            // 
            lbldetalle.AutoSize = true;
            lbldetalle.BackColor = Color.White;
            lbldetalle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldetalle.Location = new Point(320, 134);
            lbldetalle.Name = "lbldetalle";
            lbldetalle.Size = new Size(0, 23);
            lbldetalle.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.CERRAR;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(615, 620);
            btnCancelar.MinimumSize = new Size(182, 65);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(182, 65);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.White;
            btnGuardar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnGuardar.Image = Properties.Resources.GUARDAR;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(256, 620);
            btnGuardar.MinimumSize = new Size(182, 65);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(182, 65);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.BackColor = Color.Black;
            numericUpDown1.Font = new Font("Century", 9F, FontStyle.Bold);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(298, 529);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(658, 26);
            numericUpDown1.TabIndex = 9;
            // 
            // CBType
            // 
            CBType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBType.BackColor = Color.Black;
            CBType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBType.Font = new Font("Century", 9F, FontStyle.Bold);
            CBType.ForeColor = Color.White;
            CBType.FormattingEnabled = true;
            CBType.ImeMode = ImeMode.NoControl;
            CBType.Items.AddRange(new object[] { "Eventos Culturales", "Eventos Deportivos", "Eventos Tecnologicos ", "Eventos Cinematograficos ", "Eventos De Networinkg " });
            CBType.Location = new Point(298, 463);
            CBType.Name = "CBType";
            CBType.Size = new Size(658, 26);
            CBType.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.CalendarMonthBackground = Color.Black;
            dateTimePicker.CalendarTitleBackColor = Color.Black;
            dateTimePicker.CalendarTitleForeColor = Color.Black;
            dateTimePicker.CalendarTrailingForeColor = Color.Black;
            dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dateTimePicker.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(298, 401);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(658, 28);
            dateTimePicker.TabIndex = 7;
            // 
            // textPlace
            // 
            textPlace.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textPlace.BackColor = Color.Black;
            textPlace.Font = new Font("Century", 9F, FontStyle.Bold);
            textPlace.ForeColor = Color.White;
            textPlace.Location = new Point(298, 336);
            textPlace.MinimumSize = new Size(640, 35);
            textPlace.Multiline = true;
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(658, 35);
            textPlace.TabIndex = 6;
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textName.BackColor = Color.Black;
            textName.Font = new Font("Century", 9F, FontStyle.Bold);
            textName.ForeColor = Color.White;
            textName.Location = new Point(298, 268);
            textName.MinimumSize = new Size(640, 35);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(658, 35);
            textName.TabIndex = 5;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.White;
            lblCapacidad.Font = new Font("Century", 10.8F, FontStyle.Bold);
            lblCapacidad.ImageAlign = ContentAlignment.MiddleLeft;
            lblCapacidad.Location = new Point(60, 528);
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
            lbltipo.Location = new Point(60, 463);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(212, 22);
            lbltipo.TabIndex = 3;
            lbltipo.Text = "Categoria del Evento:";
            lbltipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormularioDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.The_Diplomat_of_the_Year_Award__1_;
            ClientSize = new Size(1006, 800);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1006, 800);
            MinimumSize = new Size(1006, 800);
            Name = "FormularioDetalle";
            WindowState = FormWindowState.Maximized;
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
        private Panel panel1;
    }
}