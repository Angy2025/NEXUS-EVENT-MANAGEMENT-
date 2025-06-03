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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEventos.BackgroundColor = Color.Gainsboro;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.GridColor = SystemColors.ActiveCaptionText;
            dgvEventos.Location = new Point(369, 104);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.Size = new Size(607, 376);
            dgvEventos.TabIndex = 0;
            dgvEventos.CellContentClick += dataGridView1_CellContentClick;
            dgvEventos.CellDoubleClick += dgvEventos_CellDoubleClick;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Black;
            txtTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ButtonHighlight;
            txtTitulo.Location = new Point(227, 31);
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
            btnC.Location = new Point(87, 316);
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
            btnD.Location = new Point(87, 208);
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
            btnResumen.Location = new Point(540, 500);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(265, 41);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "Ver resumen del evento";
            btnResumen.UseVisualStyleBackColor = false;
            btnResumen.Click += btnResumen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.descargar__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 456);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 170);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.The_Diplomat_of_the_Year_Award;
            ClientSize = new Size(1014, 649);
            Controls.Add(pictureBox1);
            Controls.Add(btnResumen);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(txtTitulo);
            Controls.Add(dgvEventos);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
