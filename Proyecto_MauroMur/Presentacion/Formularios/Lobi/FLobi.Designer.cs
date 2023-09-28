namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi
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
            panelLogo = new Panel();
            btnInicio = new PictureBox();
            iconUsuarios = new FontAwesome.Sharp.IconButton();
            iconEstadistica = new FontAwesome.Sharp.IconButton();
            iconExit = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            iconMisVentas = new FontAwesome.Sharp.IconButton();
            iconCatalogo = new FontAwesome.Sharp.IconButton();
            iconProducto = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lbNApe = new Label();
            lbRol = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(24, 61, 61);
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
            lbTitleCurrentForm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleCurrentForm.ForeColor = Color.Gainsboro;
            lbTitleCurrentForm.Location = new Point(45, 36);
            lbTitleCurrentForm.Name = "lbTitleCurrentForm";
            lbTitleCurrentForm.Size = new Size(46, 20);
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
            iconCurrentChildForm.Location = new Point(16, 24);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.FromArgb(221, 230, 237);
            panelEscritorio.Controls.Add(Lfecha);
            panelEscritorio.Controls.Add(Lhora);
            panelEscritorio.Controls.Add(pictureBox1);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.ForeColor = Color.Transparent;
            panelEscritorio.Location = new Point(220, 100);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(706, 461);
            panelEscritorio.TabIndex = 3;
            // 
            // Lfecha
            // 
            Lfecha.Anchor = AnchorStyles.None;
            Lfecha.AutoSize = true;
            Lfecha.BackColor = Color.Transparent;
            Lfecha.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Lfecha.ForeColor = Color.FromArgb(24, 61, 61);
            Lfecha.Location = new Point(96, 372);
            Lfecha.Name = "Lfecha";
            Lfecha.Size = new Size(85, 29);
            Lfecha.TabIndex = 4;
            Lfecha.Text = "label1";
            Lfecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lhora
            // 
            Lhora.Anchor = AnchorStyles.None;
            Lhora.AutoSize = true;
            Lhora.BackColor = Color.Transparent;
            Lhora.FlatStyle = FlatStyle.Flat;
            Lhora.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Lhora.ForeColor = Color.FromArgb(24, 61, 61);
            Lhora.Location = new Point(287, 333);
            Lhora.Name = "Lhora";
            Lhora.Size = new Size(100, 37);
            Lhora.TabIndex = 3;
            Lhora.Text = "label1";
            Lhora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(201, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnInicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 100);
            panelLogo.TabIndex = 1;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(214, 97);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 1;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // iconUsuarios
            // 
            iconUsuarios.BackColor = Color.FromArgb(24, 61, 61);
            iconUsuarios.Dock = DockStyle.Top;
            iconUsuarios.FlatAppearance.BorderSize = 0;
            iconUsuarios.FlatStyle = FlatStyle.Flat;
            iconUsuarios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconUsuarios.ForeColor = Color.Gainsboro;
            iconUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            iconUsuarios.IconColor = Color.Gainsboro;
            iconUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsuarios.IconSize = 32;
            iconUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            iconUsuarios.Location = new Point(0, 100);
            iconUsuarios.Name = "iconUsuarios";
            iconUsuarios.Padding = new Padding(10, 0, 20, 0);
            iconUsuarios.Size = new Size(220, 60);
            iconUsuarios.TabIndex = 1;
            iconUsuarios.Text = "Empleados";
            iconUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            iconUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconUsuarios.UseVisualStyleBackColor = false;
            iconUsuarios.Visible = false;
            iconUsuarios.Click += iconUsuarios_Click;
            // 
            // iconEstadistica
            // 
            iconEstadistica.BackColor = Color.FromArgb(24, 61, 61);
            iconEstadistica.Dock = DockStyle.Top;
            iconEstadistica.FlatAppearance.BorderSize = 0;
            iconEstadistica.FlatStyle = FlatStyle.Flat;
            iconEstadistica.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconEstadistica.ForeColor = Color.Gainsboro;
            iconEstadistica.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            iconEstadistica.IconColor = Color.Gainsboro;
            iconEstadistica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEstadistica.IconSize = 32;
            iconEstadistica.ImageAlign = ContentAlignment.MiddleLeft;
            iconEstadistica.Location = new Point(0, 160);
            iconEstadistica.Name = "iconEstadistica";
            iconEstadistica.Padding = new Padding(10, 0, 20, 0);
            iconEstadistica.Size = new Size(220, 60);
            iconEstadistica.TabIndex = 2;
            iconEstadistica.Text = "Estadisticas";
            iconEstadistica.TextAlign = ContentAlignment.MiddleLeft;
            iconEstadistica.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconEstadistica.UseVisualStyleBackColor = false;
            iconEstadistica.Visible = false;
            iconEstadistica.Click += iconEstadistica_Click;
            // 
            // iconExit
            // 
            iconExit.BackColor = Color.FromArgb(24, 61, 61);
            iconExit.Dock = DockStyle.Bottom;
            iconExit.FlatAppearance.BorderSize = 0;
            iconExit.FlatStyle = FlatStyle.Flat;
            iconExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconExit.ForeColor = Color.Gainsboro;
            iconExit.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconExit.IconColor = Color.Gainsboro;
            iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconExit.IconSize = 32;
            iconExit.ImageAlign = ContentAlignment.MiddleLeft;
            iconExit.Location = new Point(0, 501);
            iconExit.Name = "iconExit";
            iconExit.Padding = new Padding(10, 0, 20, 0);
            iconExit.Size = new Size(220, 60);
            iconExit.TabIndex = 4;
            iconExit.Text = "Cerrar Sesión";
            iconExit.TextAlign = ContentAlignment.MiddleLeft;
            iconExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconExit.UseVisualStyleBackColor = false;
            iconExit.Click += iconExit_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(24, 61, 61);
            panelMenu.Controls.Add(iconMisVentas);
            panelMenu.Controls.Add(iconCatalogo);
            panelMenu.Controls.Add(iconProducto);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(iconExit);
            panelMenu.Controls.Add(iconEstadistica);
            panelMenu.Controls.Add(iconUsuarios);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 561);
            panelMenu.TabIndex = 0;
            // 
            // iconMisVentas
            // 
            iconMisVentas.BackColor = Color.FromArgb(24, 61, 61);
            iconMisVentas.Dock = DockStyle.Top;
            iconMisVentas.FlatAppearance.BorderSize = 0;
            iconMisVentas.FlatStyle = FlatStyle.Flat;
            iconMisVentas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconMisVentas.ForeColor = Color.Gainsboro;
            iconMisVentas.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            iconMisVentas.IconColor = Color.Gainsboro;
            iconMisVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMisVentas.IconSize = 32;
            iconMisVentas.ImageAlign = ContentAlignment.MiddleLeft;
            iconMisVentas.Location = new Point(0, 340);
            iconMisVentas.Name = "iconMisVentas";
            iconMisVentas.Padding = new Padding(10, 0, 20, 0);
            iconMisVentas.Size = new Size(220, 60);
            iconMisVentas.TabIndex = 8;
            iconMisVentas.Text = "Mis Ventas";
            iconMisVentas.TextAlign = ContentAlignment.MiddleLeft;
            iconMisVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconMisVentas.UseVisualStyleBackColor = false;
            iconMisVentas.Click += iconMisVentas_Click;
            // 
            // iconCatalogo
            // 
            iconCatalogo.BackColor = Color.FromArgb(24, 61, 61);
            iconCatalogo.Dock = DockStyle.Top;
            iconCatalogo.FlatAppearance.BorderSize = 0;
            iconCatalogo.FlatStyle = FlatStyle.Flat;
            iconCatalogo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconCatalogo.ForeColor = Color.Gainsboro;
            iconCatalogo.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            iconCatalogo.IconColor = Color.Gainsboro;
            iconCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCatalogo.IconSize = 32;
            iconCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            iconCatalogo.Location = new Point(0, 280);
            iconCatalogo.Name = "iconCatalogo";
            iconCatalogo.Padding = new Padding(10, 0, 20, 0);
            iconCatalogo.Size = new Size(220, 60);
            iconCatalogo.TabIndex = 7;
            iconCatalogo.Text = "Catalogo";
            iconCatalogo.TextAlign = ContentAlignment.MiddleLeft;
            iconCatalogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconCatalogo.UseVisualStyleBackColor = false;
            iconCatalogo.Visible = false;
            iconCatalogo.Click += iconCatalogo_Click;
            // 
            // iconProducto
            // 
            iconProducto.BackColor = Color.FromArgb(24, 61, 61);
            iconProducto.Dock = DockStyle.Top;
            iconProducto.FlatAppearance.BorderSize = 0;
            iconProducto.FlatStyle = FlatStyle.Flat;
            iconProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconProducto.ForeColor = Color.Gainsboro;
            iconProducto.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            iconProducto.IconColor = Color.Gainsboro;
            iconProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProducto.IconSize = 32;
            iconProducto.ImageAlign = ContentAlignment.MiddleLeft;
            iconProducto.Location = new Point(0, 220);
            iconProducto.Name = "iconProducto";
            iconProducto.Padding = new Padding(10, 0, 20, 0);
            iconProducto.Size = new Size(220, 60);
            iconProducto.TabIndex = 6;
            iconProducto.Text = "Producto";
            iconProducto.TextAlign = ContentAlignment.MiddleLeft;
            iconProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconProducto.UseVisualStyleBackColor = false;
            iconProducto.Visible = false;
            iconProducto.Click += iconProducto_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbNApe);
            panel1.Controls.Add(lbRol);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Enabled = false;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 60);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // lbNApe
            // 
            lbNApe.AutoSize = true;
            lbNApe.BackColor = Color.Transparent;
            lbNApe.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbNApe.Location = new Point(42, 33);
            lbNApe.Name = "lbNApe";
            lbNApe.Size = new Size(107, 15);
            lbNApe.TabIndex = 6;
            lbNApe.Text = "Nombre y Apellido";
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.BackColor = Color.Transparent;
            lbRol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbRol.ForeColor = Color.Transparent;
            lbRol.Location = new Point(42, 14);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(26, 15);
            lbRol.TabIndex = 5;
            lbRol.Text = "Rol";
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(36, 60);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // FLobi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(926, 561);
            Controls.Add(panelEscritorio);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FLobi";
            Text = "Form1";
            Load += FLobi_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelEscritorio.ResumeLayout(false);
            panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnlobiMinimizar;
        private FontAwesome.Sharp.IconButton btnlobiMaximizar;
        private FontAwesome.Sharp.IconButton btnlobiSalir;
        private PictureBox pictureBox1;
        private Label Lhora;
        private Label Lfecha;
        private System.Windows.Forms.Timer horaFecha;
        private Panel panelLogo;
        private PictureBox btnInicio;
        private FontAwesome.Sharp.IconButton iconUsuarios;
        private FontAwesome.Sharp.IconButton iconEstadistica;
        private FontAwesome.Sharp.IconButton iconExit;
        private Panel panelMenu;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lbRol;
        private Label lbNApe;
        private FontAwesome.Sharp.IconButton iconProducto;
        private FontAwesome.Sharp.IconButton iconCatalogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Panel panelEscritorio;
        public Label lbTitleCurrentForm;
        private FontAwesome.Sharp.IconButton iconMisVentas;
    }
}