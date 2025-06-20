namespace CAPA_DE_PRESENTACION
{
    partial class FormularioPrincpal
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtTitulo2 = new TextBox();
            label1 = new Label();
            comBox = new ComboBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_6y0fnb6y0fnb6y0f1;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome to...!";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(comBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(95, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 510);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // txtTitulo2
            // 
            txtTitulo2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTitulo2.Location = new Point(262, 77);
            txtTitulo2.Name = "txtTitulo2";
            txtTitulo2.Size = new Size(376, 34);
            txtTitulo2.TabIndex = 2;
            txtTitulo2.Text = "    NEXUS EVENT MANAGEMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(91, 78);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Eventos:";
            // 
            // comBox
            // 
            comBox.AllowDrop = true;
            comBox.FormattingEnabled = true;
            comBox.Location = new Point(272, 76);
            comBox.Name = "comBox";
            comBox.Size = new Size(151, 28);
            comBox.TabIndex = 1;
            comBox.Text = "Eventos Cinematograficos ";
            // 
            // FormularioPrincpal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 778);
            Controls.Add(txtTitulo2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            ForeColor = Color.DarkBlue;
            Name = "FormularioPrincpal";
            Text = "FormularioPrincpal";
            Load += FormularioPrincpal_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTitulo2;
        private ComboBox comBox;
        private Label label1;
    }
}