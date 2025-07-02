namespace CAPA_DE_PRESENTACION
{
    partial class FormConfirmacion
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblMensaje = new Label();
            btnIcon = new Button();
            btneliminar2 = new Button();
            btnCancelar2 = new Button();
            lbladver = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.White;
            lblMensaje.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(136, 79);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(491, 25);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "¿Esta seguro de que desea eliminar este evento?";
            // 
            // btnIcon
            // 
            btnIcon.Image = Properties.Resources.ADVERTENCIA;
            btnIcon.Location = new Point(23, 47);
            btnIcon.Name = "btnIcon";
            btnIcon.Size = new Size(94, 67);
            btnIcon.TabIndex = 1;
            btnIcon.UseVisualStyleBackColor = true;
            btnIcon.Click += button1_Click;
            // 
            // btneliminar2
            // 
            btneliminar2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar2.Image = Properties.Resources.ELIMINAR;
            btneliminar2.ImageAlign = ContentAlignment.MiddleLeft;
            btneliminar2.Location = new Point(154, 179);
            btneliminar2.Name = "btneliminar2";
            btneliminar2.Size = new Size(156, 39);
            btneliminar2.TabIndex = 2;
            btneliminar2.Text = "Si, eliminar.";
            btneliminar2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar2.UseVisualStyleBackColor = true;
            btneliminar2.Click += button2_Click;
            // 
            // btnCancelar2
            // 
            btnCancelar2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar2.Image = Properties.Resources.CERRAR;
            btnCancelar2.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar2.Location = new Point(368, 179);
            btnCancelar2.Name = "btnCancelar2";
            btnCancelar2.Size = new Size(150, 39);
            btnCancelar2.TabIndex = 3;
            btnCancelar2.Text = "No, cancelar.";
            btnCancelar2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar2.UseVisualStyleBackColor = true;
            btnCancelar2.Click += btnCancelar2_Click;
            // 
            // lbladver
            // 
            lbladver.AutoSize = true;
            lbladver.BackColor = Color.White;
            lbladver.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladver.Location = new Point(163, 127);
            lbladver.Name = "lbladver";
            lbladver.Size = new Size(273, 20);
            lbladver.TabIndex = 4;
            lbladver.Text = "Esta accion no se puede deshacer. ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 229);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Advertencia";
            // 
            // FormConfirmacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(662, 285);
            Controls.Add(lbladver);
            Controls.Add(btnCancelar2);
            Controls.Add(btneliminar2);
            Controls.Add(btnIcon);
            Controls.Add(lblMensaje);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfirmacion";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfirmacion";
            Load += FormConfirmacion_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblMensaje;
        private Button btnIcon;
        private Button btneliminar2;
        private Button btnCancelar2;
        private Label lbladver;
        private GroupBox groupBox1;
    }
}