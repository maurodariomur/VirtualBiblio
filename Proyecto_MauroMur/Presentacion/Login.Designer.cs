﻿namespace Proyecto_MauroMur
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            TUsuario = new TextBox();
            TContraseña = new TextBox();
            LTitlelogin = new Label();
            BLogin = new Button();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            iconEye = new FontAwesome.Sharp.IconButton();
            lbErrorMenssage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(160, 81, 232);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(24, 61, 61);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 330);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // TUsuario
            // 
            TUsuario.BackColor = Color.FromArgb(249, 249, 249);
            TUsuario.BorderStyle = BorderStyle.None;
            TUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TUsuario.ForeColor = SystemColors.ControlText;
            TUsuario.Location = new Point(294, 93);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(421, 19);
            TUsuario.TabIndex = 1;
            TUsuario.Text = "Usuario";
            TUsuario.Enter += TUsuario_Enter;
            TUsuario.Leave += TUsuario_Leave;
            // 
            // TContraseña
            // 
            TContraseña.BackColor = Color.FromArgb(249, 249, 249);
            TContraseña.BorderStyle = BorderStyle.None;
            TContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TContraseña.ForeColor = SystemColors.ControlText;
            TContraseña.Location = new Point(294, 158);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(405, 19);
            TContraseña.TabIndex = 2;
            TContraseña.Text = "Contraseña";
            TContraseña.TextChanged += TContraseña_TextChanged;
            TContraseña.Enter += TContraseña_Enter;
            TContraseña.Leave += TContraseña_Leave;
            // 
            // LTitlelogin
            // 
            LTitlelogin.AutoSize = true;
            LTitlelogin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LTitlelogin.Location = new Point(472, 9);
            LTitlelogin.Name = "LTitlelogin";
            LTitlelogin.Size = new Size(76, 25);
            LTitlelogin.TabIndex = 3;
            LTitlelogin.Text = "LOGIN";
            // 
            // BLogin
            // 
            BLogin.BackColor = Color.DarkGray;
            BLogin.Cursor = Cursors.Hand;
            BLogin.FlatAppearance.BorderSize = 0;
            BLogin.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BLogin.FlatAppearance.MouseOverBackColor = Color.LightGray;
            BLogin.FlatStyle = FlatStyle.Flat;
            BLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BLogin.ForeColor = SystemColors.ControlText;
            BLogin.Location = new Point(307, 252);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(408, 40);
            BLogin.TabIndex = 3;
            BLogin.Text = "Iniciar Sesion";
            BLogin.UseVisualStyleBackColor = false;
            BLogin.Click += BLogin_Click;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(750, 0);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(30, 27);
            btncerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btncerrar.TabIndex = 6;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.BackColor = Color.Transparent;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(724, 0);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(30, 27);
            btnminimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnminimizar.TabIndex = 7;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 61, 61);
            pictureBox1.Location = new Point(294, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 3);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(24, 61, 61);
            pictureBox2.Location = new Point(294, 184);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(435, 3);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // iconEye
            // 
            iconEye.BackColor = Color.Transparent;
            iconEye.FlatAppearance.BorderSize = 0;
            iconEye.FlatStyle = FlatStyle.Flat;
            iconEye.ForeColor = SystemColors.ControlDark;
            iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconEye.IconColor = Color.DarkGray;
            iconEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEye.IconSize = 23;
            iconEye.Location = new Point(705, 158);
            iconEye.Name = "iconEye";
            iconEye.Size = new Size(24, 23);
            iconEye.TabIndex = 10;
            iconEye.UseVisualStyleBackColor = false;
            iconEye.Visible = false;
            iconEye.Click += iconEye_Click;
            // 
            // lbErrorMenssage
            // 
            lbErrorMenssage.AutoSize = true;
            lbErrorMenssage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbErrorMenssage.ForeColor = Color.RosyBrown;
            lbErrorMenssage.Image = (Image)resources.GetObject("lbErrorMenssage.Image");
            lbErrorMenssage.ImageAlign = ContentAlignment.MiddleLeft;
            lbErrorMenssage.Location = new Point(294, 211);
            lbErrorMenssage.Name = "lbErrorMenssage";
            lbErrorMenssage.Size = new Size(88, 15);
            lbErrorMenssage.TabIndex = 11;
            lbErrorMenssage.Text = "Error Message";
            lbErrorMenssage.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            ClientSize = new Size(780, 330);
            Controls.Add(lbErrorMenssage);
            Controls.Add(iconEye);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(BLogin);
            Controls.Add(LTitlelogin);
            Controls.Add(TContraseña);
            Controls.Add(TUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Login_KeyDown;
            MouseDown += Login_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox TUsuario;
        private TextBox TContraseña;
        private Label LTitlelogin;
        private Button BLogin;
        private PictureBox btncerrar;
        private PictureBox pictureBox3;
        private PictureBox btnminimizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconEye;
        private Label lbErrorMenssage;
    }
}