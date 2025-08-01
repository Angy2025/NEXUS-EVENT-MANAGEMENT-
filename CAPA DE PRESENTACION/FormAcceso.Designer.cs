﻿namespace CAPA_DE_PRESENTACION
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
            Button btnGestionEventos;
            Button btnEstatus;
            PanelMenuLateral = new Panel();
            btnExit = new Button();
            PanelLogo = new Panel();
            PBuser = new PictureBox();
            lblnom = new Label();
            lblposicion = new Label();
            lblEmail = new Label();
            PanelHerencia = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelTitulo = new Panel();
            btnrestaurar = new Button();
            buttonMinimizar = new Button();
            buttonMaximizar = new Button();
            buttonCerrar = new Button();
            btnGestionEventos = new Button();
            btnEstatus = new Button();
            PanelMenuLateral.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            PanelHerencia.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnGestionEventos
            // 
            btnGestionEventos.BackColor = Color.FromArgb(38, 24, 14);
            btnGestionEventos.Dock = DockStyle.Top;
            btnGestionEventos.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionEventos.ForeColor = Color.White;
            btnGestionEventos.Image = Properties.Resources.icons8_stadium_64;
            btnGestionEventos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionEventos.Location = new Point(0, 172);
            btnGestionEventos.Name = "btnGestionEventos";
            btnGestionEventos.Size = new Size(345, 96);
            btnGestionEventos.TabIndex = 6;
            btnGestionEventos.Text = "Gestionar Eventos";
            btnGestionEventos.UseVisualStyleBackColor = false;
            btnGestionEventos.Click += btnGestionEventos_Click;
            // 
            // btnEstatus
            // 
            btnEstatus.BackColor = Color.FromArgb(38, 24, 14);
            btnEstatus.Dock = DockStyle.Top;
            btnEstatus.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstatus.ForeColor = Color.White;
            btnEstatus.Image = Properties.Resources.icons8_tear_off_calendar_50;
            btnEstatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstatus.Location = new Point(0, 268);
            btnEstatus.Name = "btnEstatus";
            btnEstatus.Size = new Size(345, 86);
            btnEstatus.TabIndex = 7;
            btnEstatus.Text = "Estatus de Eventos";
            btnEstatus.UseVisualStyleBackColor = false;
            btnEstatus.Click += btnEstatus_Click;
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.FromArgb(38, 24, 14);
            PanelMenuLateral.BackgroundImageLayout = ImageLayout.Stretch;
            PanelMenuLateral.Controls.Add(btnEstatus);
            PanelMenuLateral.Controls.Add(btnGestionEventos);
            PanelMenuLateral.Controls.Add(btnExit);
            PanelMenuLateral.Controls.Add(PanelLogo);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.ForeColor = Color.White;
            PanelMenuLateral.Location = new Point(0, 0);
            PanelMenuLateral.Margin = new Padding(4, 3, 4, 3);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(345, 800);
            PanelMenuLateral.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(38, 24, 14);
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 762);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(11, 0, 0, 0);
            btnExit.Size = new Size(345, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Cerrar Sesion";
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.Transparent;
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
            PBuser.BackColor = Color.FromArgb(38, 24, 14);
            PBuser.BackgroundImage = Properties.Resources.icons8_usuario_masculino_en_círculo_30;
            PBuser.BackgroundImageLayout = ImageLayout.Zoom;
            PBuser.Location = new Point(0, 0);
            PBuser.Name = "PBuser";
            PBuser.Size = new Size(121, 139);
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
            lblnom.Location = new Point(127, 56);
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
            lblposicion.Location = new Point(127, 10);
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
            lblEmail.Location = new Point(127, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 18);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // PanelHerencia
            // 
            PanelHerencia.BackColor = Color.Transparent;
            PanelHerencia.BackgroundImage = Properties.Resources.download__10_;
            PanelHerencia.Controls.Add(panel1);
            PanelHerencia.Controls.Add(panelTitulo);
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(345, 0);
            PanelHerencia.MinimumSize = new Size(1006, 800);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(1006, 800);
            PanelHerencia.TabIndex = 2;
            PanelHerencia.Paint += PanelMenuLateral_Paint;
            PanelHerencia.MouseDown += PanelHerencia_MouseDown;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(128, 1, 1, 1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(314, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 332);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 339);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(38, 24, 14);
            panelTitulo.Controls.Add(btnrestaurar);
            panelTitulo.Controls.Add(buttonMinimizar);
            panelTitulo.Controls.Add(buttonMaximizar);
            panelTitulo.Controls.Add(buttonCerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1006, 62);
            panelTitulo.TabIndex = 1;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // btnrestaurar
            // 
            btnrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnrestaurar.BackColor = Color.White;
            btnrestaurar.BackgroundImage = Properties.Resources.icons8_restaurar_abajo_161;
            btnrestaurar.BackgroundImageLayout = ImageLayout.Stretch;
            btnrestaurar.Cursor = Cursors.Hand;
            btnrestaurar.FlatStyle = FlatStyle.Flat;
            btnrestaurar.Location = new Point(929, 3);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(25, 25);
            btnrestaurar.TabIndex = 3;
            btnrestaurar.UseVisualStyleBackColor = false;
            btnrestaurar.Visible = false;
            btnrestaurar.Click += btnrestaurar_Click;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimizar.BackColor = Color.White;
            buttonMinimizar.BackgroundImage = Properties.Resources.icons8_menos_161;
            buttonMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMinimizar.Cursor = Cursors.Hand;
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.ForeColor = Color.White;
            buttonMinimizar.Location = new Point(898, 3);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(25, 25);
            buttonMinimizar.TabIndex = 2;
            buttonMinimizar.UseVisualStyleBackColor = false;
            buttonMinimizar.Click += buttonMinimizar_Click;
            // 
            // buttonMaximizar
            // 
            buttonMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximizar.BackColor = Color.White;
            buttonMaximizar.BackgroundImage = Properties.Resources.icons8_botón_maximizar_16;
            buttonMaximizar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMaximizar.Cursor = Cursors.Hand;
            buttonMaximizar.FlatStyle = FlatStyle.Flat;
            buttonMaximizar.Location = new Point(929, 3);
            buttonMaximizar.Name = "buttonMaximizar";
            buttonMaximizar.Size = new Size(25, 25);
            buttonMaximizar.TabIndex = 1;
            buttonMaximizar.UseVisualStyleBackColor = false;
            buttonMaximizar.Click += button9_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrar.BackColor = Color.White;
            buttonCerrar.BackgroundImage = Properties.Resources.icons8_x_16;
            buttonCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCerrar.Cursor = Cursors.Hand;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Location = new Point(962, 3);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(25, 25);
            buttonCerrar.TabIndex = 0;
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // FormAcceso
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1350, 800);
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuLateral;
        private Panel PanelManagement;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnExit;
        private Panel PanelHerencia;
        private Panel panelTitulo;
        private Button buttonMinimizar;
        private Button buttonMaximizar;
        private Button buttonCerrar;
        private Button btnGestionEventos;
        private Button btnrestaurar;
        private Panel PanelLogo;
        private PictureBox PBuser;
        private Label lblnom;
        private Label lblposicion;
        private Label lblEmail;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}