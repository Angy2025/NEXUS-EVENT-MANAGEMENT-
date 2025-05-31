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
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEventos.BackgroundColor = Color.Black;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.GridColor = SystemColors.Desktop;
            dgvEventos.Location = new Point(349, 145);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.Size = new Size(481, 363);
            dgvEventos.TabIndex = 0;
            dgvEventos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Black;
            txtTitulo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ButtonHighlight;
            txtTitulo.Location = new Point(233, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(401, 34);
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
            btnC.Location = new Point(389, 529);
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
            btnD.Location = new Point(621, 529);
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
            txtInstruccion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstruccion.ForeColor = SystemColors.ButtonHighlight;
            txtInstruccion.Location = new Point(389, 98);
            txtInstruccion.Name = "txtInstruccion";
            txtInstruccion.Size = new Size(408, 30);
            txtInstruccion.TabIndex = 5;
            txtInstruccion.Text = "Seleccione el tipo de evento al que desea asistir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(867, 602);
            Controls.Add(txtInstruccion);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(txtTitulo);
            Controls.Add(dgvEventos);
            Name = "Form1";
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
    }
}
