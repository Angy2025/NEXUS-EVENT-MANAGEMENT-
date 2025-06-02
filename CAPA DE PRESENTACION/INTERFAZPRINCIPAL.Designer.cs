namespace CAPA_DE_PRESENTACION
{
    partial class INTERFAZPRINCIPAL
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
            txtInstruccion = new TextBox();
            btnResumen = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEventos.BackgroundColor = Color.Gainsboro;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.GridColor = SystemColors.ActiveCaptionText;
            dgvEventos.Location = new Point(459, 133);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.Size = new Size(457, 363);
            dgvEventos.TabIndex = 0;
            dgvEventos.CellContentClick += dataGridView1_CellContentClick;
            dgvEventos.CellDoubleClick += dgvEventos_CellDoubleClick;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Black;
            txtTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ButtonHighlight;
            txtTitulo.Location = new Point(163, 24);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(496, 42);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "NEXUS EVENT MANAGMENT";
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            txtTitulo.WordWrap = false;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Black;
            btnC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = SystemColors.ButtonHighlight;
            btnC.Location = new Point(26, 214);
            btnC.Name = "btnC";
            btnC.Size = new Size(159, 30);
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
            btnD.Location = new Point(230, 214);
            btnD.Name = "btnD";
            btnD.Size = new Size(159, 30);
            btnD.TabIndex = 4;
            btnD.Text = "Deportivo";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // txtInstruccion
            // 
            txtInstruccion.BackColor = SystemColors.InactiveCaptionText;
            txtInstruccion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstruccion.ForeColor = SystemColors.ButtonHighlight;
            txtInstruccion.Location = new Point(12, 133);
            txtInstruccion.Name = "txtInstruccion";
            txtInstruccion.ReadOnly = true;
            txtInstruccion.Size = new Size(408, 34);
            txtInstruccion.TabIndex = 5;
            txtInstruccion.Text = "Seleccione el tipo de evento al que desea asistir";
            txtInstruccion.TextChanged += txtInstruccion_TextChanged;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.Black;
            btnResumen.Enabled = false;
            btnResumen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumen.ForeColor = SystemColors.ControlLightLight;
            btnResumen.Location = new Point(545, 515);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(305, 29);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "Ver resumen del evento";
            btnResumen.UseVisualStyleBackColor = false;
            btnResumen.Click += btnResumen_Click;
            // 
            // INTERFAZPRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(953, 602);
            Controls.Add(btnResumen);
            Controls.Add(txtInstruccion);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(txtTitulo);
            Controls.Add(dgvEventos);
            Name = "INTERFAZPRINCIPAL";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEventos;
        private TextBox txtTitulo;
        private Button btnC;
        private Button btnD;
        private TextBox txtInstruccion;
        private Button btnResumen;
    }
}
