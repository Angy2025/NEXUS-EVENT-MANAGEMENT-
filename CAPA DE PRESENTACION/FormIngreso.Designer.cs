namespace CAPA_DE_PRESENTACION
{
    partial class FormIngreso
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
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            PLine1 = new Panel();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            lblLogin = new Label();
            btnAccess = new Button();
            linkPassword = new LinkLabel();
            btnC = new PictureBox();
            btnM = new PictureBox();
            lblErrorMessage = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnM).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 460);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 460);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // PLine1
            // 
            PLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PLine1.BackColor = Color.White;
            PLine1.Enabled = false;
            PLine1.Location = new Point(297, 160);
            PLine1.MaximumSize = new Size(460, 2);
            PLine1.MinimumSize = new Size(460, 2);
            PLine1.Name = "PLine1";
            PLine1.Size = new Size(460, 2);
            PLine1.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.Gray;
            txtUser.Location = new Point(297, 127);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(460, 25);
            txtUser.TabIndex = 1;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(297, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(460, 25);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Enabled = false;
            panel1.Location = new Point(297, 249);
            panel1.MaximumSize = new Size(460, 2);
            panel1.MinimumSize = new Size(460, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 2);
            panel1.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Gainsboro;
            lblLogin.Location = new Point(407, 36);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(271, 28);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "NEXUS USER LOGIN";
            // 
            // btnAccess
            // 
            btnAccess.BackColor = Color.FromArgb(40, 40, 40);
            btnAccess.FlatAppearance.BorderSize = 0;
            btnAccess.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAccess.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAccess.FlatStyle = FlatStyle.Flat;
            btnAccess.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccess.ForeColor = Color.Gainsboro;
            btnAccess.Location = new Point(328, 328);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(400, 40);
            btnAccess.TabIndex = 3;
            btnAccess.Text = "ACCEDER A NEXUS";
            btnAccess.UseVisualStyleBackColor = false;
            btnAccess.Click += btnAccess_Click;
            // 
            // linkPassword
            // 
            linkPassword.ActiveLinkColor = Color.FromArgb(91, 186, 100);
            linkPassword.AutoSize = true;
            linkPassword.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkPassword.LinkColor = Color.LightGray;
            linkPassword.Location = new Point(409, 394);
            linkPassword.Name = "linkPassword";
            linkPassword.Size = new Size(235, 21);
            linkPassword.TabIndex = 0;
            linkPassword.TabStop = true;
            linkPassword.Text = "¿Ha olvidado su contraseña?";
            linkPassword.LinkClicked += linkPassword_LinkClicked;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Silver;
            btnC.BackgroundImage = Properties.Resources.icons8_close_window_24;
            btnC.BackgroundImageLayout = ImageLayout.Stretch;
            btnC.Location = new Point(791, 12);
            btnC.Name = "btnC";
            btnC.Size = new Size(20, 20);
            btnC.TabIndex = 10;
            btnC.TabStop = false;
            btnC.Click += btnC_Click;
            // 
            // btnM
            // 
            btnM.BackColor = Color.Silver;
            btnM.BackgroundImage = Properties.Resources.icons8_menos_24;
            btnM.BackgroundImageLayout = ImageLayout.Stretch;
            btnM.Location = new Point(764, 12);
            btnM.Name = "btnM";
            btnM.Size = new Size(19, 20);
            btnM.TabIndex = 11;
            btnM.TabStop = false;
            btnM.Click += btnM_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("MS Reference Sans Serif", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Gainsboro;
            lblErrorMessage.Image = Properties.Resources.icons8_box_important_24;
            lblErrorMessage.ImageAlign = ContentAlignment.MiddleLeft;
            lblErrorMessage.Location = new Point(297, 266);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(163, 20);
            lblErrorMessage.TabIndex = 12;
            lblErrorMessage.Text = "Mensaje de Error";
            lblErrorMessage.TextAlign = ContentAlignment.MiddleRight;
            lblErrorMessage.Visible = false;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(864, 460);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnM);
            Controls.Add(btnC);
            Controls.Add(linkPassword);
            Controls.Add(btnAccess);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(panel1);
            Controls.Add(txtUser);
            Controls.Add(PLine1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIngreso";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIngreso";
            Load += FormIngreso_Load;
            MouseDown += FormIngreso_MouseDown;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel PLine1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Panel panel1;
        private Label lblLogin;
        private Button btnAccess;
        private LinkLabel linkPassword;
        private PictureBox btnC;
        private PictureBox btnM;
        private PictureBox pictureBox3;
        private Label lblErrorMessage;
    }
}