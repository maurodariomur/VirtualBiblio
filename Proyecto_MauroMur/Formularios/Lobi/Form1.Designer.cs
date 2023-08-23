namespace Proyecto_MauroMur.Formularios.Lobi
{
    partial class FLobi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLobi));
            panelMenu = new Panel();
            iconVentas = new FontAwesome.Sharp.IconButton();
            iconConsultas = new FontAwesome.Sharp.IconButton();
            iconProductos = new FontAwesome.Sharp.IconButton();
            iconUsuarios = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnInicio = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            panelTitleBar = new Panel();
            btnlobiMinimizar = new FontAwesome.Sharp.IconButton();
            btnlobiMaximizar = new FontAwesome.Sharp.IconButton();
            btnlobiSalir = new FontAwesome.Sharp.IconButton();
            lbTitleCurrentForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelEscritorio = new Panel();
            Lfecha = new Label();
            Lhora = new Label();
            pictureBox1 = new PictureBox();
            horaFecha = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 23, 25);
            panelMenu.Controls.Add(iconVentas);
            panelMenu.Controls.Add(iconConsultas);
            panelMenu.Controls.Add(iconProductos);
            panelMenu.Controls.Add(iconUsuarios);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 479);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // iconVentas
            // 
            iconVentas.BackColor = Color.FromArgb(0, 23, 25);
            iconVentas.Dock = DockStyle.Top;
            iconVentas.FlatAppearance.BorderSize = 0;
            iconVentas.FlatStyle = FlatStyle.Flat;
            iconVentas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconVentas.ForeColor = Color.Gainsboro;
            iconVentas.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            iconVentas.IconColor = Color.Gainsboro;
            iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconVentas.IconSize = 32;
            iconVentas.ImageAlign = ContentAlignment.MiddleLeft;
            iconVentas.Location = new Point(0, 320);
            iconVentas.Name = "iconVentas";
            iconVentas.Padding = new Padding(10, 0, 20, 0);
            iconVentas.Size = new Size(220, 60);
            iconVentas.TabIndex = 4;
            iconVentas.Text = "Ventas";
            iconVentas.TextAlign = ContentAlignment.MiddleLeft;
            iconVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconVentas.UseVisualStyleBackColor = false;
            iconVentas.Click += iconVentas_Click;
            // 
            // iconConsultas
            // 
            iconConsultas.BackColor = Color.FromArgb(0, 23, 25);
            iconConsultas.Dock = DockStyle.Top;
            iconConsultas.FlatAppearance.BorderSize = 0;
            iconConsultas.FlatStyle = FlatStyle.Flat;
            iconConsultas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconConsultas.ForeColor = Color.Gainsboro;
            iconConsultas.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            iconConsultas.IconColor = Color.Gainsboro;
            iconConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconConsultas.IconSize = 32;
            iconConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            iconConsultas.Location = new Point(0, 260);
            iconConsultas.Name = "iconConsultas";
            iconConsultas.Padding = new Padding(10, 0, 20, 0);
            iconConsultas.Size = new Size(220, 60);
            iconConsultas.TabIndex = 3;
            iconConsultas.Text = "Consultas";
            iconConsultas.TextAlign = ContentAlignment.MiddleLeft;
            iconConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconConsultas.UseVisualStyleBackColor = false;
            iconConsultas.Click += iconConsultas_Click;
            // 
            // iconProductos
            // 
            iconProductos.BackColor = Color.FromArgb(0, 23, 25);
            iconProductos.Dock = DockStyle.Top;
            iconProductos.FlatAppearance.BorderSize = 0;
            iconProductos.FlatStyle = FlatStyle.Flat;
            iconProductos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconProductos.ForeColor = Color.Gainsboro;
            iconProductos.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            iconProductos.IconColor = Color.Gainsboro;
            iconProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProductos.IconSize = 32;
            iconProductos.ImageAlign = ContentAlignment.MiddleLeft;
            iconProductos.Location = new Point(0, 200);
            iconProductos.Name = "iconProductos";
            iconProductos.Padding = new Padding(10, 0, 20, 0);
            iconProductos.Size = new Size(220, 60);
            iconProductos.TabIndex = 2;
            iconProductos.Text = "Productos";
            iconProductos.TextAlign = ContentAlignment.MiddleLeft;
            iconProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconProductos.UseVisualStyleBackColor = false;
            iconProductos.Click += iconProductos_Click;
            // 
            // iconUsuarios
            // 
            iconUsuarios.BackColor = Color.FromArgb(0, 23, 25);
            iconUsuarios.Dock = DockStyle.Top;
            iconUsuarios.FlatAppearance.BorderSize = 0;
            iconUsuarios.FlatStyle = FlatStyle.Flat;
            iconUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconUsuarios.ForeColor = Color.Gainsboro;
            iconUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            iconUsuarios.IconColor = Color.Gainsboro;
            iconUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsuarios.IconSize = 32;
            iconUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            iconUsuarios.Location = new Point(0, 140);
            iconUsuarios.Name = "iconUsuarios";
            iconUsuarios.Padding = new Padding(10, 0, 20, 0);
            iconUsuarios.Size = new Size(220, 60);
            iconUsuarios.TabIndex = 1;
            iconUsuarios.Text = "Usuarios";
            iconUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            iconUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconUsuarios.UseVisualStyleBackColor = false;
            iconUsuarios.Click += iconUsuarios_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnInicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 1;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(214, 137);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 1;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 23, 25);
            panelTitleBar.Controls.Add(btnlobiMinimizar);
            panelTitleBar.Controls.Add(btnlobiMaximizar);
            panelTitleBar.Controls.Add(btnlobiSalir);
            panelTitleBar.Controls.Add(lbTitleCurrentForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(706, 100);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnlobiMinimizar
            // 
            btnlobiMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlobiMinimizar.BackColor = Color.Transparent;
            btnlobiMinimizar.FlatAppearance.BorderSize = 0;
            btnlobiMinimizar.FlatStyle = FlatStyle.Flat;
            btnlobiMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnlobiMinimizar.IconColor = Color.White;
            btnlobiMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlobiMinimizar.IconSize = 18;
            btnlobiMinimizar.ImageAlign = ContentAlignment.TopCenter;
            btnlobiMinimizar.Location = new Point(604, 0);
            btnlobiMinimizar.Name = "btnlobiMinimizar";
            btnlobiMinimizar.Size = new Size(30, 22);
            btnlobiMinimizar.TabIndex = 4;
            btnlobiMinimizar.UseVisualStyleBackColor = false;
            btnlobiMinimizar.Click += btnlobiMinimizar_Click;
            // 
            // btnlobiMaximizar
            // 
            btnlobiMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlobiMaximizar.BackColor = Color.Transparent;
            btnlobiMaximizar.FlatAppearance.BorderSize = 0;
            btnlobiMaximizar.FlatStyle = FlatStyle.Flat;
            btnlobiMaximizar.IconChar = FontAwesome.Sharp.IconChar.Expand;
            btnlobiMaximizar.IconColor = SystemColors.Menu;
            btnlobiMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlobiMaximizar.IconSize = 18;
            btnlobiMaximizar.ImageAlign = ContentAlignment.TopCenter;
            btnlobiMaximizar.Location = new Point(640, 0);
            btnlobiMaximizar.Name = "btnlobiMaximizar";
            btnlobiMaximizar.Size = new Size(30, 22);
            btnlobiMaximizar.TabIndex = 3;
            btnlobiMaximizar.UseVisualStyleBackColor = false;
            btnlobiMaximizar.Click += btnlobiMaximizar_Click;
            // 
            // btnlobiSalir
            // 
            btnlobiSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlobiSalir.BackColor = Color.Transparent;
            btnlobiSalir.FlatAppearance.BorderSize = 0;
            btnlobiSalir.FlatStyle = FlatStyle.Flat;
            btnlobiSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            btnlobiSalir.IconColor = Color.Crimson;
            btnlobiSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlobiSalir.IconSize = 18;
            btnlobiSalir.ImageAlign = ContentAlignment.TopCenter;
            btnlobiSalir.Location = new Point(676, 0);
            btnlobiSalir.Name = "btnlobiSalir";
            btnlobiSalir.Size = new Size(30, 31);
            btnlobiSalir.TabIndex = 2;
            btnlobiSalir.UseVisualStyleBackColor = false;
            btnlobiSalir.Click += btnlobiSalir_Click;
            // 
            // lbTitleCurrentForm
            // 
            lbTitleCurrentForm.AutoSize = true;
            lbTitleCurrentForm.BackColor = Color.Transparent;
            lbTitleCurrentForm.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleCurrentForm.ForeColor = Color.Gainsboro;
            lbTitleCurrentForm.Location = new Point(53, 35);
            lbTitleCurrentForm.Name = "lbTitleCurrentForm";
            lbTitleCurrentForm.Size = new Size(51, 21);
            lbTitleCurrentForm.TabIndex = 1;
            lbTitleCurrentForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.ForeColor = Color.Gainsboro;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(15, 24);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.Silver;
            panelEscritorio.Controls.Add(Lfecha);
            panelEscritorio.Controls.Add(Lhora);
            panelEscritorio.Controls.Add(pictureBox1);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.ForeColor = Color.Transparent;
            panelEscritorio.Location = new Point(220, 100);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(706, 379);
            panelEscritorio.TabIndex = 3;
            panelEscritorio.Paint += panelEscritorio_Paint;
            // 
            // Lfecha
            // 
            Lfecha.Anchor = AnchorStyles.None;
            Lfecha.AutoSize = true;
            Lfecha.BackColor = Color.Transparent;
            Lfecha.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Lfecha.ForeColor = Color.DimGray;
            Lfecha.Location = new Point(154, 335);
            Lfecha.Name = "Lfecha";
            Lfecha.Size = new Size(86, 28);
            Lfecha.TabIndex = 4;
            Lfecha.Text = "label1";
            Lfecha.TextAlign = ContentAlignment.MiddleCenter;
            Lfecha.Click += Lfecha_Click;
            // 
            // Lhora
            // 
            Lhora.Anchor = AnchorStyles.None;
            Lhora.AutoSize = true;
            Lhora.BackColor = Color.Transparent;
            Lhora.FlatStyle = FlatStyle.Flat;
            Lhora.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Lhora.ForeColor = Color.DimGray;
            Lhora.Location = new Point(311, 301);
            Lhora.Name = "Lhora";
            Lhora.Size = new Size(129, 38);
            Lhora.TabIndex = 3;
            Lhora.Text = "label1";
            Lhora.TextAlign = ContentAlignment.MiddleCenter;
            Lhora.Click += Lhora_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // FLobi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 479);
            Controls.Add(panelEscritorio);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FLobi";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelEscritorio.ResumeLayout(false);
            panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton iconVentas;
        private FontAwesome.Sharp.IconButton iconConsultas;
        private FontAwesome.Sharp.IconButton iconProductos;
        private FontAwesome.Sharp.IconButton iconUsuarios;
        private PictureBox btnInicio;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lbTitleCurrentForm;
        private Panel panelEscritorio;
        private FontAwesome.Sharp.IconButton btnlobiMinimizar;
        private FontAwesome.Sharp.IconButton btnlobiMaximizar;
        private FontAwesome.Sharp.IconButton btnlobiSalir;
        private PictureBox pictureBox1;
        private Label Lhora;
        private Label Lfecha;
        private System.Windows.Forms.Timer horaFecha;
    }
}