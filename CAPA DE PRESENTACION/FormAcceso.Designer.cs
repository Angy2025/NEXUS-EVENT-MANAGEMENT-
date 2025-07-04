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
            PanelDetalles = new Panel();
            btnEditar = new Button();
            btnMod2 = new Button();
            btnExit = new Button();
            btnAdd = new Button();
            PanelSubMenuMedios = new Panel();
            b = new Button();
            btnMedia = new Button();
            PanelLogo = new Panel();
            pictureBox2 = new PictureBox();
            lblEmail = new Label();
            lblnom = new Label();
            lblposicion = new Label();
            PBuser = new PictureBox();
            PanelHerencia = new Panel();
            pictureBox1 = new PictureBox();
            PanelMenuLateral.SuspendLayout();
            PanelDetalles.SuspendLayout();
            PanelSubMenuMedios.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            PanelHerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.Black;
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
            PanelMenuLateral.Size = new Size(344, 753);
            PanelMenuLateral.TabIndex = 0;
            PanelMenuLateral.Paint += PanelMenuLateral_Paint;
            // 
            // PanelDetalles
            // 
            PanelDetalles.BackColor = Color.FromArgb(91, 186, 100);
            PanelDetalles.Controls.Add(btnEditar);
            PanelDetalles.Controls.Add(btnMod2);
            PanelDetalles.Dock = DockStyle.Top;
            PanelDetalles.Location = new Point(0, 291);
            PanelDetalles.Margin = new Padding(4, 3, 4, 3);
            PanelDetalles.Name = "PanelDetalles";
            PanelDetalles.Size = new Size(344, 93);
            PanelDetalles.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Dock = DockStyle.Top;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(0, 48);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(40, 0, 0, 0);
            btnEditar.Size = new Size(344, 56);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Modificar Evento Existente";
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseMnemonic = false;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button1_Click;
            // 
            // btnMod2
            // 
            btnMod2.BackColor = Color.White;
            btnMod2.Dock = DockStyle.Top;
            btnMod2.FlatAppearance.BorderSize = 0;
            btnMod2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMod2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMod2.FlatStyle = FlatStyle.Flat;
            btnMod2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMod2.ForeColor = Color.Black;
            btnMod2.Location = new Point(0, 0);
            btnMod2.Margin = new Padding(4, 3, 4, 3);
            btnMod2.Name = "btnMod2";
            btnMod2.Padding = new Padding(40, 0, 0, 0);
            btnMod2.Size = new Size(344, 48);
            btnMod2.TabIndex = 1;
            btnMod2.Text = "Agregar Evento Nuevo";
            btnMod2.TextAlign = ContentAlignment.TopCenter;
            btnMod2.UseVisualStyleBackColor = false;
            btnMod2.Click += btnMod2_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 153, 22);
            btnExit.BackgroundImage = Properties.Resources.icons8_logout_24;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(0, 715);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(11, 0, 0, 0);
            btnExit.Size = new Size(344, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Cerrar Sesion";
            btnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 153, 22);
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(0, 253);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(11, 0, 0, 0);
            btnAdd.Size = new Size(344, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Detalles de Eventos";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // PanelSubMenuMedios
            // 
            PanelSubMenuMedios.BackColor = Color.White;
            PanelSubMenuMedios.Controls.Add(b);
            PanelSubMenuMedios.Dock = DockStyle.Top;
            PanelSubMenuMedios.Location = new Point(0, 210);
            PanelSubMenuMedios.Margin = new Padding(4, 3, 4, 3);
            PanelSubMenuMedios.Name = "PanelSubMenuMedios";
            PanelSubMenuMedios.Size = new Size(344, 43);
            PanelSubMenuMedios.TabIndex = 1;
            // 
            // b
            // 
            b.BackColor = Color.White;
            b.Dock = DockStyle.Top;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseDownBackColor = Color.Transparent;
            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b.FlatStyle = FlatStyle.Flat;
            b.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b.ForeColor = Color.Black;
            b.Location = new Point(0, 0);
            b.Margin = new Padding(4, 3, 4, 3);
            b.Name = "b";
            b.Padding = new Padding(40, 0, 0, 0);
            b.Size = new Size(344, 34);
            b.TabIndex = 0;
            b.Text = "Generalidades De Eventos";
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.UseVisualStyleBackColor = false;
            b.Click += b_Click;
            // 
            // btnMedia
            // 
            btnMedia.BackColor = Color.FromArgb(255, 153, 22);
            btnMedia.Dock = DockStyle.Top;
            btnMedia.FlatAppearance.BorderSize = 0;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedia.ForeColor = Color.Black;
            btnMedia.Location = new Point(0, 172);
            btnMedia.Margin = new Padding(4, 3, 4, 3);
            btnMedia.Name = "btnMedia";
            btnMedia.Padding = new Padding(11, 0, 0, 0);
            btnMedia.Size = new Size(344, 38);
            btnMedia.TabIndex = 0;
            btnMedia.Text = "Gestionar Eventos";
            btnMedia.TextAlign = ContentAlignment.MiddleLeft;
            btnMedia.UseVisualStyleBackColor = false;
            btnMedia.Click += btnMedia_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.Black;
            PanelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PanelLogo.Controls.Add(pictureBox2);
            PanelLogo.Controls.Add(lblEmail);
            PanelLogo.Controls.Add(lblnom);
            PanelLogo.Controls.Add(lblposicion);
            PanelLogo.Controls.Add(PBuser);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.ForeColor = Color.White;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(4, 3, 4, 3);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(344, 172);
            PanelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.icons8_slider_24;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(239, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 27);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(109, 93);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 18);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Font = new Font("Century", 9F, FontStyle.Bold);
            lblnom.Location = new Point(109, 56);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(70, 18);
            lblnom.TabIndex = 2;
            lblnom.Text = "Nombre";
            // 
            // lblposicion
            // 
            lblposicion.AutoSize = true;
            lblposicion.Font = new Font("Century", 9F, FontStyle.Bold);
            lblposicion.Location = new Point(109, 21);
            lblposicion.Name = "lblposicion";
            lblposicion.Size = new Size(75, 18);
            lblposicion.TabIndex = 1;
            lblposicion.Text = "Posicion";
            lblposicion.Click += label1_Click;
            // 
            // PBuser
            // 
            PBuser.BackColor = Color.White;
            PBuser.BackgroundImage = Properties.Resources.icons8_profile_96_removebg_preview;
            PBuser.BackgroundImageLayout = ImageLayout.Zoom;
            PBuser.Location = new Point(3, 12);
            PBuser.Name = "PBuser";
            PBuser.Size = new Size(100, 99);
            PBuser.TabIndex = 0;
            PBuser.TabStop = false;
            // 
            // PanelHerencia
            // 
            PanelHerencia.BackColor = Color.White;
            PanelHerencia.Controls.Add(pictureBox1);
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(344, 0);
            PanelHerencia.MaximumSize = new Size(901, 753);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(838, 753);
            PanelHerencia.TabIndex = 2;
            PanelHerencia.Paint += PanelHerencia_Paint;
            PanelHerencia.MouseDown += PanelHerencia_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(242, 200);
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
            Load += FormAcceso_Load;
            PanelMenuLateral.ResumeLayout(false);
            PanelDetalles.ResumeLayout(false);
            PanelSubMenuMedios.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBuser).EndInit();
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
        private Button btnEditar;
        private PictureBox PBuser;
        private Label lblEmail;
        private Label lblnom;
        private Label lblposicion;
        private PictureBox pictureBox2;
    }
}