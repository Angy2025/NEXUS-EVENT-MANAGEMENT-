﻿namespace CAPA_DE_PRESENTACION
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            groupBox3 = new GroupBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timerunic = new System.Windows.Forms.Timer(components);
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.BackgroundImage = Properties.Resources.unnamed_1__removebg_preview;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Century", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(645, 418);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "¡Welcome to...!";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Century", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 394);
            label1.Name = "label1";
            label1.Size = new Size(271, 21);
            label1.TabIndex = 0;
            label1.Text = "Cargando, por favor espere...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Black;
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.FromArgb(229, 85, 7);
            progressBar1.Location = new Point(0, 418);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(645, 29);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 29;
            // 
            // timerunic
            // 
            timerunic.Enabled = true;
            timerunic.Interval = 3000;
            timerunic.Tick += timerunic_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(645, 447);
            Controls.Add(groupBox3);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormPrincipal_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private ProgressBar progressBar1;
        private Label label1;
        private System.Windows.Forms.Timer timerunic;
    }
}
