namespace CAPA_DE_PRESENTACION
{
    partial class FormularioGestion
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btneliminar = new Button();
            dgv2 = new DataGridView();
            btnbuscar = new Button();
            comBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // btneliminar
            // 
            btneliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btneliminar.BackColor = Color.White;
            btneliminar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.Black;
            btneliminar.Image = Properties.Resources.ELIMINAR;
            btneliminar.Location = new Point(643, 679);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(183, 62);
            btneliminar.TabIndex = 20;
            btneliminar.Text = "Eliminar Evento";
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // dgv2
            // 
            dgv2.BackgroundColor = Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(165, 217, 165);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            dgv2.GridColor = Color.Black;
            dgv2.Location = new Point(63, 67);
            dgv2.Name = "dgv2";
            dgv2.ReadOnly = true;
            dgv2.RowHeadersWidth = 51;
            dgv2.Size = new Size(751, 414);
            dgv2.TabIndex = 17;
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top;
            btnbuscar.BackColor = Color.White;
            btnbuscar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.Image = Properties.Resources.BUSCAR;
            btnbuscar.Location = new Point(487, 497);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(115, 29);
            btnbuscar.TabIndex = 16;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // comBox
            // 
            comBox.AllowDrop = true;
            comBox.Anchor = AnchorStyles.Top;
            comBox.BackColor = Color.FromArgb(255, 224, 192);
            comBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comBox.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comBox.FormattingEnabled = true;
            comBox.Items.AddRange(new object[] { "Culturales", "Deportivos", "Tecnologicos ", "Cinematograficos ", "Networinkg ", "Todos Los Eventos" });
            comBox.Location = new Point(164, 498);
            comBox.Name = "comBox";
            comBox.Size = new Size(317, 28);
            comBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(264, 21);
            label1.Name = "label1";
            label1.Size = new Size(360, 28);
            label1.TabIndex = 12;
            label1.Text = "Busqueda Por Tipo De Evento";
            // 
            // FormularioGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.download;
            ClientSize = new Size(838, 753);
            Controls.Add(btneliminar);
            Controls.Add(dgv2);
            Controls.Add(btnbuscar);
            Controls.Add(comBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(838, 753);
            MinimumSize = new Size(838, 753);
            Name = "FormularioGestion";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTION";
            Load += frmGestionEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btneliminar;
        private DataGridView dgv2;
        private Button btnbuscar;
        private ComboBox comBox;
        private Label label1;
    }
}