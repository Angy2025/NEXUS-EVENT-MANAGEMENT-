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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblnombre = new Label();
            lbllugar = new Label();
            lbldate = new Label();
            groupBox1 = new GroupBox();
            dgv3 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgv3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.White;
            lblnombre.Font = new Font("Century", 9F, FontStyle.Bold);
            lblnombre.ImageAlign = ContentAlignment.MiddleLeft;
            lblnombre.Location = new Point(18, 381);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(169, 18);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre Del Evento:";
            lblnombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbllugar
            // 
            lbllugar.AutoSize = true;
            lbllugar.BackColor = Color.White;
            lbllugar.Font = new Font("Century", 9F, FontStyle.Bold);
            lbllugar.ImageAlign = ContentAlignment.MiddleLeft;
            lbllugar.Location = new Point(18, 453);
            lbllugar.Name = "lbllugar";
            lbllugar.Size = new Size(185, 18);
            lbllugar.TabIndex = 1;
            lbllugar.Text = "Ubicacion Del Evento:";
            lbllugar.TextAlign = ContentAlignment.MiddleLeft;
            lbllugar.Click += label2_Click;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.White;
            lbldate.Font = new Font("Century", 9F, FontStyle.Bold);
            lbldate.ImageAlign = ContentAlignment.MiddleLeft;
            lbldate.Location = new Point(18, 517);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(184, 18);
            lbldate.TabIndex = 2;
            lbldate.Text = "Fecha De Realizacion:";
            lbldate.TextAlign = ContentAlignment.MiddleLeft;
            lbldate.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(dgv3);
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
            groupBox1.Size = new Size(883, 706);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgv3
            // 
            dgv3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv3.BackgroundColor = Color.FromArgb(247, 165, 42);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuBar;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv3.GridColor = Color.Black;
            dgv3.Location = new Point(360, 77);
            dgv3.Name = "dgv3";
            dgv3.RowHeadersWidth = 51;
            dgv3.Size = new Size(481, 263);
            dgv3.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 328);
            panel1.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(483, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 28);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Agregar Nuevo Evento";
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
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.CERRAR;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(256, 681);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 51);
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
            btnGuardar.Location = new Point(602, 688);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 44);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(165, 217, 165);
            numericUpDown1.Font = new Font("Century", 9F, FontStyle.Bold);
            numericUpDown1.ForeColor = Color.Black;
            numericUpDown1.Location = new Point(256, 634);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(490, 26);
            numericUpDown1.TabIndex = 9;
            // 
            // CBType
            // 
            CBType.BackColor = Color.FromArgb(165, 217, 165);
            CBType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBType.Font = new Font("Century", 9F, FontStyle.Bold);
            CBType.FormattingEnabled = true;
            CBType.ImeMode = ImeMode.NoControl;
            CBType.Items.AddRange(new object[] { "Eventos Culturales", "Eventos Deportivos", "Eventos Tecnologicos ", "Eventos Cinematograficos ", "Eventos De Networinkg " });
            CBType.Location = new Point(256, 568);
            CBType.Name = "CBType";
            CBType.Size = new Size(490, 26);
            CBType.TabIndex = 8;
            CBType.SelectedIndexChanged += CBType_SelectedIndexChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(165, 217, 165);
            dateTimePicker.CalendarTitleBackColor = Color.FromArgb(165, 217, 165);
            dateTimePicker.CalendarTitleForeColor = Color.FromArgb(165, 217, 165);
            dateTimePicker.CalendarTrailingForeColor = Color.FromArgb(165, 217, 165);
            dateTimePicker.CustomFormat = "dddd, dd 'de' MMMM 'de' yyyy, hh:mm tt";
            dateTimePicker.Font = new Font("Century", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(256, 506);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(490, 28);
            dateTimePicker.TabIndex = 7;
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textPlace
            // 
            textPlace.BackColor = Color.FromArgb(165, 217, 165);
            textPlace.Font = new Font("Century", 9F, FontStyle.Bold);
            textPlace.Location = new Point(256, 442);
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(490, 26);
            textPlace.TabIndex = 6;
            // 
            // textName
            // 
            textName.BackColor = Color.FromArgb(165, 217, 165);
            textName.Font = new Font("Century", 9F, FontStyle.Bold);
            textName.Location = new Point(256, 373);
            textName.Name = "textName";
            textName.Size = new Size(490, 26);
            textName.TabIndex = 5;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.White;
            lblCapacidad.Font = new Font("Century", 9F, FontStyle.Bold);
            lblCapacidad.ImageAlign = ContentAlignment.MiddleLeft;
            lblCapacidad.Location = new Point(18, 645);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(177, 18);
            lblCapacidad.TabIndex = 4;
            lblCapacidad.Text = "Asistencia al Evento:";
            lblCapacidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.BackColor = Color.White;
            lbltipo.Font = new Font("Century", 9F, FontStyle.Bold);
            lbltipo.ImageAlign = ContentAlignment.MiddleLeft;
            lbltipo.Location = new Point(18, 579);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(182, 18);
            lbltipo.TabIndex = 3;
            lbltipo.Text = "Categoria del Evento:";
            lbltipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormularioDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(883, 706);
            Controls.Add(groupBox1);
            Cursor = Cursors.Arrow;
            Name = "FormularioDetalle";
            Text = "FormularioDetalle";
            Load += FormularioDetalle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv3).EndInit();
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
        private DataGridView dgv3;
    }
}