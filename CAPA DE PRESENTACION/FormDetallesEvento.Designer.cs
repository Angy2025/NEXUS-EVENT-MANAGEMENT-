namespace CAPA_DE_PRESENTACION
{
    partial class FormDetallesEvento
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
            label1 = new Label();
            lblname = new Label();
            lbldate = new Label();
            label4 = new Label();
            lblplace = new Label();
            btnclose = new Button();
            txtNombreEvento = new TextBox();
            txtLugarEvento = new TextBox();
            txtFechaEvento = new TextBox();
            txtTipoEvento = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(83, 34);
            label1.Name = "label1";
            label1.Size = new Size(285, 25);
            label1.TabIndex = 0;
            label1.Text = "DETALLES DEL EVENTO";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.Location = new Point(28, 103);
            lblname.Name = "lblname";
            lblname.Size = new Size(176, 23);
            lblname.TabIndex = 1;
            lblname.Text = "Nombre del evento:";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldate.Location = new Point(28, 209);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(159, 23);
            lbldate.TabIndex = 2;
            lbldate.Text = "Fecha del evento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 261);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 3;
            label4.Text = "Tipo de evento:";
            // 
            // lblplace
            // 
            lblplace.AutoSize = true;
            lblplace.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplace.Location = new Point(28, 152);
            lblplace.Name = "lblplace";
            lblplace.Size = new Size(160, 23);
            lblplace.TabIndex = 4;
            lblplace.Text = "Lugar del evento:";
            // 
            // btnclose
            // 
            btnclose.BackColor = SystemColors.ActiveCaptionText;
            btnclose.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = SystemColors.ControlLightLight;
            btnclose.Location = new Point(153, 322);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(94, 29);
            btnclose.TabIndex = 9;
            btnclose.Text = "Cerrar";
            btnclose.TextAlign = ContentAlignment.BottomCenter;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(228, 99);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.ReadOnly = true;
            txtNombreEvento.Size = new Size(197, 27);
            txtNombreEvento.TabIndex = 10;
            // 
            // txtLugarEvento
            // 
            txtLugarEvento.Location = new Point(228, 151);
            txtLugarEvento.Name = "txtLugarEvento";
            txtLugarEvento.ReadOnly = true;
            txtLugarEvento.Size = new Size(197, 27);
            txtLugarEvento.TabIndex = 11;
            txtLugarEvento.TextChanged += txtLugarEvento_TextChanged;
            // 
            // txtFechaEvento
            // 
            txtFechaEvento.Location = new Point(228, 205);
            txtFechaEvento.Name = "txtFechaEvento";
            txtFechaEvento.ReadOnly = true;
            txtFechaEvento.Size = new Size(197, 27);
            txtFechaEvento.TabIndex = 12;
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.Location = new Point(228, 257);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.ReadOnly = true;
            txtTipoEvento.Size = new Size(197, 27);
            txtTipoEvento.TabIndex = 13;
            // 
            // FormDetallesEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 390);
            Controls.Add(txtTipoEvento);
            Controls.Add(txtFechaEvento);
            Controls.Add(txtLugarEvento);
            Controls.Add(txtNombreEvento);
            Controls.Add(btnclose);
            Controls.Add(lblplace);
            Controls.Add(label4);
            Controls.Add(lbldate);
            Controls.Add(lblname);
            Controls.Add(label1);
            Name = "FormDetallesEvento";
            Text = "Form1";
            Load += FormDetallesEvento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblname;
        private Label lbldate;
        private Label label4;
        private Label lblplace;
        private Button btnclose;
        private TextBox txtNombreEvento;
        private TextBox txtLugarEvento;
        private TextBox txtFechaEvento;
        private TextBox txtTipoEvento;
    }
}