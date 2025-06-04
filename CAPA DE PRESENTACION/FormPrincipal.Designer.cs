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
            btnC = new Button();
            btnD = new Button();
            btnResumen = new Button();
            txtTipoEvento = new TextBox();
            lblTitulo = new Label();
            lblname = new Label();
            lbldate = new Label();
            label4 = new Label();
            lblplace = new Label();
            btnclose = new Button();
            txtNombreEvento = new TextBox();
            txtLugarEvento = new TextBox();
            txtFechaEvento = new TextBox();
            lblIdEvento = new Label();
            txtIdEvento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEventos.BackgroundColor = Color.OldLace;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.GridColor = Color.OldLace;
            dgvEventos.Location = new Point(911, 103);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.Size = new Size(594, 377);
            dgvEventos.TabIndex = 0;
            dgvEventos.CellClick += dgvEventos_CellClick;
            dgvEventos.CellContentClick += dataGridView1_CellContentClick;
            dgvEventos.CellDoubleClick += dgvEventos_CellDoubleClick;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Black;
            txtTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ButtonHighlight;
            txtTitulo.Location = new Point(408, 23);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(496, 42);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "Nexus Event Managment\r\n";
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            txtTitulo.WordWrap = false;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Black;
            btnC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = SystemColors.ButtonHighlight;
            btnC.Location = new Point(681, 359);
            btnC.Name = "btnC";
            btnC.Size = new Size(181, 57);
            btnC.TabIndex = 3;
            btnC.Text = "Cultural";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Black;
            btnD.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnD.ForeColor = SystemColors.ButtonHighlight;
            btnD.Location = new Point(681, 156);
            btnD.Name = "btnD";
            btnD.Size = new Size(181, 66);
            btnD.TabIndex = 4;
            btnD.Text = "Deportivo";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.Black;
            btnResumen.Enabled = false;
            btnResumen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumen.ForeColor = SystemColors.ControlLightLight;
            btnResumen.Location = new Point(1115, 511);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(265, 41);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "Ver resumen del evento";
            btnResumen.UseVisualStyleBackColor = false;
            btnResumen.Click += btnResumen_Click;
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.Location = new Point(236, 389);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.ReadOnly = true;
            txtTipoEvento.Size = new Size(197, 27);
            txtTipoEvento.TabIndex = 23;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(90, 103);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(285, 25);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "DETALLES DEL EVENTO";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.White;
            lblname.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.Location = new Point(23, 238);
            lblname.Name = "lblname";
            lblname.Size = new Size(176, 23);
            lblname.TabIndex = 15;
            lblname.Text = "Nombre del evento:";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.White;
            lbldate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldate.Location = new Point(23, 344);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(159, 23);
            lbldate.TabIndex = 16;
            lbldate.Text = "Fecha del evento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 396);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 17;
            label4.Text = "Tipo de evento:";
            // 
            // lblplace
            // 
            lblplace.AutoSize = true;
            lblplace.BackColor = Color.White;
            lblplace.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplace.Location = new Point(23, 287);
            lblplace.Name = "lblplace";
            lblplace.Size = new Size(160, 23);
            lblplace.TabIndex = 18;
            lblplace.Text = "Lugar del evento:";
            // 
            // btnclose
            // 
            btnclose.BackColor = SystemColors.ButtonHighlight;
            btnclose.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = Color.Black;
            btnclose.Location = new Point(164, 477);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(94, 29);
            btnclose.TabIndex = 19;
            btnclose.Text = "Cerrar";
            btnclose.TextAlign = ContentAlignment.BottomCenter;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(236, 234);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.ReadOnly = true;
            txtNombreEvento.Size = new Size(197, 27);
            txtNombreEvento.TabIndex = 20;
            // 
            // txtLugarEvento
            // 
            txtLugarEvento.Location = new Point(236, 283);
            txtLugarEvento.Name = "txtLugarEvento";
            txtLugarEvento.ReadOnly = true;
            txtLugarEvento.Size = new Size(197, 27);
            txtLugarEvento.TabIndex = 21;
            // 
            // txtFechaEvento
            // 
            txtFechaEvento.Location = new Point(236, 337);
            txtFechaEvento.Name = "txtFechaEvento";
            txtFechaEvento.ReadOnly = true;
            txtFechaEvento.Size = new Size(197, 27);
            txtFechaEvento.TabIndex = 22;
            // 
            // lblIdEvento
            // 
            lblIdEvento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIdEvento.AutoSize = true;
            lblIdEvento.BackColor = Color.White;
            lblIdEvento.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdEvento.Location = new Point(23, 185);
            lblIdEvento.Name = "lblIdEvento";
            lblIdEvento.Size = new Size(116, 20);
            lblIdEvento.TabIndex = 24;
            lblIdEvento.Text = "ID del Evento";
            // 
            // txtIdEvento
            // 
            txtIdEvento.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdEvento.Location = new Point(236, 182);
            txtIdEvento.Name = "txtIdEvento";
            txtIdEvento.Size = new Size(197, 30);
            txtIdEvento.TabIndex = 25;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.descargar__2_;
            ClientSize = new Size(1600, 692);
            Controls.Add(txtIdEvento);
            Controls.Add(lblIdEvento);
            Controls.Add(txtTipoEvento);
            Controls.Add(txtFechaEvento);
            Controls.Add(txtLugarEvento);
            Controls.Add(txtNombreEvento);
            Controls.Add(btnclose);
            Controls.Add(lblplace);
            Controls.Add(label4);
            Controls.Add(lbldate);
            Controls.Add(lblname);
            Controls.Add(lblTitulo);
            Controls.Add(btnResumen);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(txtTitulo);
            Controls.Add(dgvEventos);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEventos;
        private TextBox txtTitulo;
        private Button btnC;
        private Button btnD;
        private Button btnResumen;
        private PictureBox pictureBox1;
        private TextBox txtTipoEvento;
        private TextBox txtFechaEvento;
        private TextBox txtLugarEvento;
        private TextBox txtNombreEvento;
        private Button btnclose;
        private Label lblplace;
        private Label label4;
        private Label lbldate;
        private Label lblname;
        private Label lblTitulo;
        private Label lblIdEvento;
        private TextBox txtIdEvento;
    }
}
