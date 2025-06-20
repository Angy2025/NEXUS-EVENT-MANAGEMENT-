namespace CAPA_DE_PRESENTACION
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEventos = new DataGridView();
            txtTitulo = new TextBox();
            btnclose = new Button();
            groupBox1 = new GroupBox();
            btnD = new Button();
            btnC = new Button();
            lblTitulo = new Label();
            txtTipoEvento = new TextBox();
            txtLugarEvento = new TextBox();
            txtIdEvento = new TextBox();
            txtNombreEvento = new TextBox();
            txtFechaEvento = new TextBox();
            label4 = new Label();
            lblplace = new Label();
            lbldate = new Label();
            lblname = new Label();
            btnResumen = new Button();
            lblIdEvento = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEventos.BackgroundColor = Color.LightGray;
            dgvEventos.BorderStyle = BorderStyle.Fixed3D;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.GridColor = Color.Black;
            dgvEventos.Location = new Point(31, 40);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.Size = new Size(245, 236);
            dgvEventos.TabIndex = 0;
            dgvEventos.CellClick += dgvEventos_CellClick;
            dgvEventos.CellContentClick += dataGridView1_CellContentClick;
            dgvEventos.CellDoubleClick += dgvEventos_CellDoubleClick;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.White;
            txtTitulo.Enabled = false;
            txtTitulo.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ActiveCaptionText;
            txtTitulo.Location = new Point(275, 64);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(403, 43);
            txtTitulo.TabIndex = 2;
            txtTitulo.TabStop = false;
            txtTitulo.Text = "Nexus Event Management\r\n";
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            txtTitulo.WordWrap = false;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // btnclose
            // 
            btnclose.BackColor = SystemColors.ButtonHighlight;
            btnclose.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = Color.Black;
            btnclose.Location = new Point(324, 548);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(116, 33);
            btnclose.TabIndex = 19;
            btnclose.Text = "Cerrar";
            btnclose.TextAlign = ContentAlignment.BottomCenter;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(btnD);
            groupBox1.Controls.Add(btnC);
            groupBox1.Controls.Add(btnclose);
            groupBox1.Controls.Add(lblTitulo);
            groupBox1.Controls.Add(txtTipoEvento);
            groupBox1.Controls.Add(txtLugarEvento);
            groupBox1.Controls.Add(txtIdEvento);
            groupBox1.Controls.Add(txtNombreEvento);
            groupBox1.Controls.Add(txtFechaEvento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblplace);
            groupBox1.Controls.Add(lbldate);
            groupBox1.Controls.Add(lblname);
            groupBox1.Controls.Add(btnResumen);
            groupBox1.Controls.Add(lblIdEvento);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(69, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 611);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnD
            // 
            btnD.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnD.Location = new Point(462, 374);
            btnD.Name = "btnD";
            btnD.Size = new Size(114, 29);
            btnD.TabIndex = 28;
            btnD.Text = "Deportivos";
            btnD.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.Location = new Point(613, 374);
            btnC.Name = "btnC";
            btnC.Size = new Size(118, 29);
            btnC.TabIndex = 27;
            btnC.Text = "Culturales";
            btnC.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(90, 83);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(208, 27);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Detalles Del Evento";
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTipoEvento.Location = new Point(158, 367);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.ReadOnly = true;
            txtTipoEvento.Size = new Size(197, 28);
            txtTipoEvento.TabIndex = 23;
            // 
            // txtLugarEvento
            // 
            txtLugarEvento.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLugarEvento.Location = new Point(158, 258);
            txtLugarEvento.Name = "txtLugarEvento";
            txtLugarEvento.ReadOnly = true;
            txtLugarEvento.Size = new Size(197, 28);
            txtLugarEvento.TabIndex = 21;
            // 
            // txtIdEvento
            // 
            txtIdEvento.AllowDrop = true;
            txtIdEvento.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdEvento.Location = new Point(158, 137);
            txtIdEvento.Name = "txtIdEvento";
            txtIdEvento.ReadOnly = true;
            txtIdEvento.Size = new Size(197, 30);
            txtIdEvento.TabIndex = 25;
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreEvento.Location = new Point(158, 195);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.ReadOnly = true;
            txtNombreEvento.Size = new Size(197, 28);
            txtNombreEvento.TabIndex = 20;
            // 
            // txtFechaEvento
            // 
            txtFechaEvento.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaEvento.Location = new Point(158, 313);
            txtFechaEvento.Name = "txtFechaEvento";
            txtFechaEvento.ReadOnly = true;
            txtFechaEvento.Size = new Size(197, 28);
            txtFechaEvento.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 374);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 17;
            label4.Text = "Tipo:";
            // 
            // lblplace
            // 
            lblplace.AutoSize = true;
            lblplace.BackColor = Color.White;
            lblplace.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplace.Location = new Point(61, 254);
            lblplace.Name = "lblplace";
            lblplace.Size = new Size(63, 21);
            lblplace.TabIndex = 18;
            lblplace.Text = "Lugar:";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.White;
            lbldate.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldate.Location = new Point(61, 313);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(63, 21);
            lbldate.TabIndex = 16;
            lbldate.Text = "Fecha:";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.White;
            lblname.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.Black;
            lblname.Location = new Point(61, 195);
            lblname.Name = "lblname";
            lblname.Size = new Size(82, 21);
            lblname.TabIndex = 15;
            lblname.Text = "Nombre:";
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.White;
            btnResumen.Enabled = false;
            btnResumen.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumen.ForeColor = Color.Black;
            btnResumen.Location = new Point(90, 426);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(224, 36);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "Ver resumen del evento";
            btnResumen.UseVisualStyleBackColor = false;
            btnResumen.Click += btnResumen_Click;
            // 
            // lblIdEvento
            // 
            lblIdEvento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIdEvento.AutoSize = true;
            lblIdEvento.BackColor = Color.White;
            lblIdEvento.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdEvento.Location = new Point(61, 146);
            lblIdEvento.Name = "lblIdEvento";
            lblIdEvento.Size = new Size(34, 21);
            lblIdEvento.TabIndex = 24;
            lblIdEvento.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.Gemini_Generated_Image_6y0fnb6y0fnb6y0f;
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Controls.Add(dgvEventos);
            groupBox2.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(444, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 305);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "       Seleccione Un Tipo de Evento";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.Gemini_Generated_Image_6y0fnb6y0fnb6y0f__1_;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Font = new Font("Cambria", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(234, 197);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "¡Welcome to...!";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(895, 793);
            Controls.Add(groupBox3);
            Controls.Add(txtTitulo);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEventos;
        private TextBox txtTitulo;
        private Button btnclose;
        private GroupBox groupBox1;
        private TextBox txtLugarEvento;
        private TextBox txtNombreEvento;
        private TextBox txtFechaEvento;
        private Label lblplace;
        private Label lbldate;
        private Button btnResumen;
        private Label lblIdEvento;
        private Label lblname;
        private Label label4;
        private TextBox txtIdEvento;
        private TextBox txtTipoEvento;
        private Label lblTitulo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnD;
        private Button btnC;
    }
}
