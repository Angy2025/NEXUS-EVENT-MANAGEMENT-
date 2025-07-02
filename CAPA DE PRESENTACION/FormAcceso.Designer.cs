namespace CAPA_DE_PRESENTACION
{
    partial class FormAcceso
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
            PanelMenuLateral = new Panel();
            btnLogin = new Button();
            PanelDetalles = new Panel();
            btnEditar = new Button();
            btnMod2 = new Button();
            btnExit = new Button();
            btnAdd = new Button();
            PanelSubMenuMedios = new Panel();
            b = new Button();
            btnMedia = new Button();
            PanelLogo = new Panel();
            PanelHerencia = new Panel();
            pictureBox1 = new PictureBox();
            PanelMenuLateral.SuspendLayout();
            PanelDetalles.SuspendLayout();
            PanelSubMenuMedios.SuspendLayout();
            PanelHerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.FromArgb(255, 224, 192);
            PanelMenuLateral.Controls.Add(btnLogin);
            PanelMenuLateral.Controls.Add(PanelDetalles);
            PanelMenuLateral.Controls.Add(btnExit);
            PanelMenuLateral.Controls.Add(btnAdd);
            PanelMenuLateral.Controls.Add(PanelSubMenuMedios);
            PanelMenuLateral.Controls.Add(btnMedia);
            PanelMenuLateral.Controls.Add(PanelLogo);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 0);
            PanelMenuLateral.Margin = new Padding(4, 3, 4, 3);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(281, 753);
            PanelMenuLateral.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Dock = DockStyle.Bottom;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(0, 677);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(11, 0, 0, 0);
            btnLogin.Size = new Size(281, 38);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // PanelDetalles
            // 
            PanelDetalles.BackColor = Color.FromArgb(91, 186, 100);
            PanelDetalles.Controls.Add(btnEditar);
            PanelDetalles.Controls.Add(btnMod2);
            PanelDetalles.Dock = DockStyle.Top;
            PanelDetalles.Location = new Point(0, 403);
            PanelDetalles.Margin = new Padding(4, 3, 4, 3);
            PanelDetalles.Name = "PanelDetalles";
            PanelDetalles.Size = new Size(281, 93);
            PanelDetalles.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Top;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(0, 34);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(40, 0, 0, 0);
            btnEditar.Size = new Size(281, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Modificar Evento Existente";
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseMnemonic = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button1_Click;
            // 
            // btnMod2
            // 
            btnMod2.Dock = DockStyle.Top;
            btnMod2.FlatAppearance.BorderSize = 0;
            btnMod2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMod2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMod2.FlatStyle = FlatStyle.Flat;
            btnMod2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMod2.ForeColor = Color.White;
            btnMod2.Location = new Point(0, 0);
            btnMod2.Margin = new Padding(4, 3, 4, 3);
            btnMod2.Name = "btnMod2";
            btnMod2.Padding = new Padding(40, 0, 0, 0);
            btnMod2.Size = new Size(281, 34);
            btnMod2.TabIndex = 1;
            btnMod2.Text = "Agregar Evento Nuevo";
            btnMod2.TextAlign = ContentAlignment.TopCenter;
            btnMod2.UseVisualStyleBackColor = true;
            btnMod2.Click += btnMod2_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.BackgroundImage = Properties.Resources.icons8_logout_24;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 715);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(11, 0, 0, 0);
            btnExit.Size = new Size(281, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Cerrar Sesion";
            btnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(0, 365);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(11, 0, 0, 0);
            btnAdd.Size = new Size(281, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Detalles de Eventos";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // PanelSubMenuMedios
            // 
            PanelSubMenuMedios.BackColor = Color.FromArgb(91, 186, 100);
            PanelSubMenuMedios.Controls.Add(b);
            PanelSubMenuMedios.Dock = DockStyle.Top;
            PanelSubMenuMedios.Location = new Point(0, 272);
            PanelSubMenuMedios.Margin = new Padding(4, 3, 4, 3);
            PanelSubMenuMedios.Name = "PanelSubMenuMedios";
            PanelSubMenuMedios.Size = new Size(281, 93);
            PanelSubMenuMedios.TabIndex = 1;
            // 
            // b
            // 
            b.Dock = DockStyle.Top;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseDownBackColor = Color.Transparent;
            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b.FlatStyle = FlatStyle.Flat;
            b.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b.ForeColor = Color.White;
            b.Location = new Point(0, 0);
            b.Margin = new Padding(4, 3, 4, 3);
            b.Name = "b";
            b.Padding = new Padding(40, 0, 0, 0);
            b.Size = new Size(281, 34);
            b.TabIndex = 0;
            b.Text = "Generalidades De Eventos";
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.UseVisualStyleBackColor = true;
            b.Click += b_Click;
            // 
            // btnMedia
            // 
            btnMedia.BackColor = Color.White;
            btnMedia.Dock = DockStyle.Top;
            btnMedia.FlatAppearance.BorderSize = 0;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMedia.ForeColor = Color.Black;
            btnMedia.Location = new Point(0, 234);
            btnMedia.Margin = new Padding(4, 3, 4, 3);
            btnMedia.Name = "btnMedia";
            btnMedia.Padding = new Padding(11, 0, 0, 0);
            btnMedia.Size = new Size(281, 38);
            btnMedia.TabIndex = 0;
            btnMedia.Text = "Gestionar Eventos";
            btnMedia.TextAlign = ContentAlignment.MiddleLeft;
            btnMedia.UseVisualStyleBackColor = false;
            btnMedia.Click += btnMedia_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(255, 224, 192);
            PanelLogo.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            PanelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(4, 3, 4, 3);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(281, 234);
            PanelLogo.TabIndex = 0;
            // 
            // PanelHerencia
            // 
            PanelHerencia.BackColor = Color.FromArgb(229, 85, 7);
            PanelHerencia.Controls.Add(pictureBox1);
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(281, 0);
            PanelHerencia.MaximumSize = new Size(901, 753);
            PanelHerencia.MinimumSize = new Size(901, 753);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(901, 753);
            PanelHerencia.TabIndex = 2;
            PanelHerencia.Paint += PanelHerencia_Paint;
            PanelHerencia.MouseDown += PanelHerencia_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(255, 224, 192);
            pictureBox1.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(273, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 288);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAcceso
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1182, 753);
            Controls.Add(PanelHerencia);
            Controls.Add(PanelMenuLateral);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 800);
            Name = "FormAcceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            PanelMenuLateral.ResumeLayout(false);
            PanelDetalles.ResumeLayout(false);
            PanelSubMenuMedios.ResumeLayout(false);
            PanelHerencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuLateral;
        private Panel PanelLogo;
        private Button btnMedia;
        private Panel PanelSubMenuMedios;
        private Button b;
        private Panel panel2;
        private Panel PanelManagement;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnAdd;
        private Button btnExit;
        private Panel PanelHerencia;
        private PictureBox pictureBox1;
        private Panel PanelDetalles;
        private Button btnMod2;
        private Panel panel1;
        private Button button2;
        private Button btnLogin;
        private Button btnEditar;
    }
}