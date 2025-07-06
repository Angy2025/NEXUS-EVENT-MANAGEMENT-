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
            btnModificarEvento = new Button();
            btnGestionEventos = new Button();
            btnExit = new Button();
            PanelLogo = new Panel();
            PBuser = new PictureBox();
            lblnom = new Label();
            lblposicion = new Label();
            lblEmail = new Label();
            PanelHerencia = new Panel();
            panelTitulo = new Panel();
            buttonMinimizar = new Button();
            buttonMaximizar = new Button();
            buttonCerrar = new Button();
            pictureBox1 = new PictureBox();
            PanelMenuLateral.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            PanelHerencia.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.Black;
            PanelMenuLateral.Controls.Add(btnModificarEvento);
            PanelMenuLateral.Controls.Add(btnGestionEventos);
            PanelMenuLateral.Controls.Add(btnExit);
            PanelMenuLateral.Controls.Add(PanelLogo);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 0);
            PanelMenuLateral.Margin = new Padding(4, 3, 4, 3);
            PanelMenuLateral.MaximumSize = new Size(344, 800);
            PanelMenuLateral.MinimumSize = new Size(344, 800);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(344, 800);
            PanelMenuLateral.TabIndex = 0;
            PanelMenuLateral.Paint += PanelMenuLateral_Paint;
            // 
            // btnModificarEvento
            // 
            btnModificarEvento.Dock = DockStyle.Top;
            btnModificarEvento.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarEvento.Location = new Point(0, 223);
            btnModificarEvento.Name = "btnModificarEvento";
            btnModificarEvento.Size = new Size(344, 51);
            btnModificarEvento.TabIndex = 8;
            btnModificarEvento.Text = "Modificar Evento Existente";
            btnModificarEvento.UseVisualStyleBackColor = true;
            btnModificarEvento.Click += btnModificarEvento_Click;
            // 
            // btnGestionEventos
            // 
            btnGestionEventos.Dock = DockStyle.Top;
            btnGestionEventos.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionEventos.Location = new Point(0, 172);
            btnGestionEventos.Name = "btnGestionEventos";
            btnGestionEventos.Size = new Size(344, 51);
            btnGestionEventos.TabIndex = 6;
            btnGestionEventos.Text = "Gestionar Eventos";
            btnGestionEventos.UseVisualStyleBackColor = true;
            btnGestionEventos.Click += btnGestionEventos_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.BackgroundImage = Properties.Resources.icons8_logout_24;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(0, 762);
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
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.Black;
            PanelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PanelLogo.Controls.Add(PBuser);
            PanelLogo.Controls.Add(lblnom);
            PanelLogo.Controls.Add(lblposicion);
            PanelLogo.Controls.Add(lblEmail);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.ForeColor = Color.White;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(4, 3, 4, 3);
            PanelLogo.MaximumSize = new Size(344, 172);
            PanelLogo.MinimumSize = new Size(344, 172);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(344, 172);
            PanelLogo.TabIndex = 0;
            // 
            // PBuser
            // 
            PBuser.BackColor = Color.Black;
            PBuser.BackgroundImage = Properties.Resources.icons8_usuario_masculino_en_círculo_32;
            PBuser.BackgroundImageLayout = ImageLayout.Zoom;
            PBuser.Location = new Point(0, 0);
            PBuser.Name = "PBuser";
            PBuser.Size = new Size(112, 138);
            PBuser.SizeMode = PictureBoxSizeMode.Zoom;
            PBuser.TabIndex = 0;
            PBuser.TabStop = false;
            PBuser.Click += PBuser_Click;
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Font = new Font("Century", 9F, FontStyle.Bold);
            lblnom.ForeColor = Color.White;
            lblnom.Location = new Point(121, 67);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(70, 18);
            lblnom.TabIndex = 2;
            lblnom.Text = "Nombre";
            // 
            // lblposicion
            // 
            lblposicion.AutoSize = true;
            lblposicion.Font = new Font("Century", 9F, FontStyle.Bold);
            lblposicion.ForeColor = Color.White;
            lblposicion.Location = new Point(121, 21);
            lblposicion.Name = "lblposicion";
            lblposicion.Size = new Size(75, 18);
            lblposicion.TabIndex = 1;
            lblposicion.Text = "Posicion";
            lblposicion.Click += label1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(121, 115);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 18);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // PanelHerencia
            // 
            PanelHerencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelHerencia.BackColor = Color.White;
            PanelHerencia.Controls.Add(panelTitulo);
            PanelHerencia.Controls.Add(pictureBox1);
            PanelHerencia.Location = new Point(344, 0);
            PanelHerencia.MaximumSize = new Size(856, 800);
            PanelHerencia.MinimumSize = new Size(856, 800);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(856, 800);
            PanelHerencia.TabIndex = 2;
            PanelHerencia.Paint += PanelHerencia_Paint;
            PanelHerencia.MouseDown += PanelHerencia_MouseDown;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.Black;
            panelTitulo.Controls.Add(buttonMinimizar);
            panelTitulo.Controls.Add(buttonMaximizar);
            panelTitulo.Controls.Add(buttonCerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.MaximumSize = new Size(856, 39);
            panelTitulo.MinimumSize = new Size(856, 39);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(856, 39);
            panelTitulo.TabIndex = 1;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.BackColor = Color.White;
            buttonMinimizar.BackgroundImage = Properties.Resources.icons8_menos_32;
            buttonMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.Location = new Point(741, 7);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(32, 29);
            buttonMinimizar.TabIndex = 2;
            buttonMinimizar.UseVisualStyleBackColor = false;
            buttonMinimizar.Click += buttonMinimizar_Click;
            // 
            // buttonMaximizar
            // 
            buttonMaximizar.BackColor = Color.White;
            buttonMaximizar.BackgroundImage = Properties.Resources.icons8_expand_24;
            buttonMaximizar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMaximizar.FlatStyle = FlatStyle.Flat;
            buttonMaximizar.Location = new Point(779, 7);
            buttonMaximizar.Name = "buttonMaximizar";
            buttonMaximizar.Size = new Size(27, 29);
            buttonMaximizar.TabIndex = 1;
            buttonMaximizar.UseVisualStyleBackColor = false;
            buttonMaximizar.Click += button9_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.BackColor = Color.White;
            buttonCerrar.BackgroundImage = Properties.Resources.icons8_salida_30;
            buttonCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Location = new Point(812, 7);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(32, 29);
            buttonCerrar.TabIndex = 0;
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(216, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 345);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAcceso
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1200, 800);
            Controls.Add(PanelHerencia);
            Controls.Add(PanelMenuLateral);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 800);
            Name = "FormAcceso";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormAcceso_Load;
            PanelMenuLateral.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).EndInit();
            PanelHerencia.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuLateral;
        private Panel PanelLogo;
        private Panel PanelManagement;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnExit;
        private Panel PanelHerencia;
        private PictureBox pictureBox1;
        private PictureBox PBuser;
        private Label lblEmail;
        private Label lblnom;
        private Label lblposicion;
        private Panel panelTitulo;
        private Button buttonMinimizar;
        private Button buttonMaximizar;
        private Button buttonCerrar;
        private Button btnGestionEventos;
        private Button btnModificarEvento;
    }
}