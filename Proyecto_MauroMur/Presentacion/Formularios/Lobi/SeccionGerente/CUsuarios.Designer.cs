namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    partial class CUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUsuarios));
            lbTipoU = new Label();
            lbU = new Label();
            lbFechaN = new Label();
            lbApellido = new Label();
            lbNombre = new Label();
            txEmpleado = new TextBox();
            dTBith = new DateTimePicker();
            lbMail = new Label();
            txLastName = new TextBox();
            txName = new TextBox();
            txMail = new TextBox();
            lbContraseña = new Label();
            txcPerfil = new ComboBox();
            txPassword = new TextBox();
            btRegistrar = new Button();
            lbDNI = new Label();
            txDNI = new TextBox();
            lbError = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contraVisible = new FontAwesome.Sharp.IconButton();
            lbTitleRegister = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btTablaUsuarios = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lbTipoU
            // 
            lbTipoU.AutoSize = true;
            lbTipoU.BackColor = Color.Transparent;
            lbTipoU.FlatStyle = FlatStyle.Flat;
            lbTipoU.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTipoU.Location = new Point(584, 210);
            lbTipoU.Name = "lbTipoU";
            lbTipoU.Size = new Size(105, 19);
            lbTipoU.TabIndex = 21;
            lbTipoU.Text = "Perfil Usuario";
            // 
            // lbU
            // 
            lbU.AutoSize = true;
            lbU.BackColor = Color.Transparent;
            lbU.FlatStyle = FlatStyle.Popup;
            lbU.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbU.Location = new Point(239, 300);
            lbU.Name = "lbU";
            lbU.Size = new Size(65, 19);
            lbU.TabIndex = 19;
            lbU.Text = "Usuario";
            // 
            // lbFechaN
            // 
            lbFechaN.AutoSize = true;
            lbFechaN.BackColor = Color.Transparent;
            lbFechaN.FlatStyle = FlatStyle.Popup;
            lbFechaN.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFechaN.Location = new Point(239, 108);
            lbFechaN.Name = "lbFechaN";
            lbFechaN.Size = new Size(153, 19);
            lbFechaN.TabIndex = 20;
            lbFechaN.Text = "Fecha Nacimiento";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.BackColor = Color.Transparent;
            lbApellido.FlatStyle = FlatStyle.Popup;
            lbApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbApellido.Location = new Point(584, 18);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(75, 19);
            lbApellido.TabIndex = 18;
            lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.Transparent;
            lbNombre.FlatStyle = FlatStyle.Popup;
            lbNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.Location = new Point(239, 18);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(73, 19);
            lbNombre.TabIndex = 17;
            lbNombre.Text = "Nombre";
            // 
            // txEmpleado
            // 
            txEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txEmpleado.ForeColor = SystemColors.WindowFrame;
            txEmpleado.Location = new Point(239, 345);
            txEmpleado.Name = "txEmpleado";
            txEmpleado.Size = new Size(296, 27);
            txEmpleado.TabIndex = 27;
            txEmpleado.Text = "Usuario";
            txEmpleado.Enter += txEmpleado_Enter_1;
            txEmpleado.Leave += txEmpleado_Leave_1;
            // 
            // dTBith
            // 
            dTBith.CalendarForeColor = SystemColors.WindowFrame;
            dTBith.CalendarTitleForeColor = SystemColors.WindowFrame;
            dTBith.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dTBith.Location = new Point(239, 148);
            dTBith.Name = "dTBith";
            dTBith.Size = new Size(296, 27);
            dTBith.TabIndex = 29;
            dTBith.ValueChanged += dTBith_ValueChanged;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.BackColor = Color.Transparent;
            lbMail.FlatStyle = FlatStyle.Popup;
            lbMail.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbMail.Location = new Point(239, 210);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(150, 19);
            lbMail.TabIndex = 22;
            lbMail.Text = "Correo Electronico";
            // 
            // txLastName
            // 
            txLastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txLastName.ForeColor = SystemColors.WindowFrame;
            txLastName.Location = new Point(584, 51);
            txLastName.Name = "txLastName";
            txLastName.Size = new Size(297, 27);
            txLastName.TabIndex = 25;
            txLastName.Text = "Apellido";
            txLastName.Enter += txLastName_Enter_1;
            txLastName.KeyPress += txLastName_KeyPress_1;
            txLastName.Leave += txLastName_Leave_1;
            // 
            // txName
            // 
            txName.Cursor = Cursors.IBeam;
            txName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txName.ForeColor = SystemColors.WindowFrame;
            txName.Location = new Point(239, 51);
            txName.Name = "txName";
            txName.Size = new Size(296, 27);
            txName.TabIndex = 24;
            txName.Text = "Nombre";
            txName.TextChanged += txName_TextChanged;
            txName.Enter += txName_Enter_1;
            txName.KeyPress += txName_KeyPress_1;
            txName.Leave += txName_Leave_1;
            // 
            // txMail
            // 
            txMail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txMail.ForeColor = SystemColors.WindowFrame;
            txMail.Location = new Point(239, 245);
            txMail.Name = "txMail";
            txMail.Size = new Size(296, 27);
            txMail.TabIndex = 26;
            txMail.Text = "Correo Electronico";
            txMail.Enter += txMail_Enter_1;
            txMail.Leave += txMail_Leave_1;
            // 
            // lbContraseña
            // 
            lbContraseña.AutoSize = true;
            lbContraseña.BackColor = Color.Transparent;
            lbContraseña.FlatStyle = FlatStyle.Flat;
            lbContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbContraseña.Location = new Point(584, 300);
            lbContraseña.Name = "lbContraseña";
            lbContraseña.Size = new Size(98, 19);
            lbContraseña.TabIndex = 23;
            lbContraseña.Text = "Contraseña";
            lbContraseña.Click += lbContraseña_Click;
            // 
            // txcPerfil
            // 
            txcPerfil.BackColor = SystemColors.Window;
            txcPerfil.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txcPerfil.ForeColor = SystemColors.WindowFrame;
            txcPerfil.FormattingEnabled = true;
            txcPerfil.Items.AddRange(new object[] { "Gerente", "Administrador", "Vendedor" });
            txcPerfil.Location = new Point(584, 245);
            txcPerfil.Name = "txcPerfil";
            txcPerfil.Size = new Size(297, 29);
            txcPerfil.TabIndex = 30;
            txcPerfil.Text = "Seleccione Usuario";
            txcPerfil.SelectedIndexChanged += txcPerfil_SelectedIndexChanged;
            // 
            // txPassword
            // 
            txPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txPassword.ForeColor = SystemColors.WindowFrame;
            txPassword.Location = new Point(584, 345);
            txPassword.Name = "txPassword";
            txPassword.Size = new Size(297, 27);
            txPassword.TabIndex = 28;
            txPassword.Text = "Contraseña";
            txPassword.UseSystemPasswordChar = true;
            txPassword.TextChanged += txPassword_TextChanged;
            txPassword.Enter += txPassword_Enter_1;
            txPassword.Leave += txPassword_Leave_1;
            // 
            // btRegistrar
            // 
            btRegistrar.Anchor = AnchorStyles.Top;
            btRegistrar.BackColor = Color.FromArgb(24, 61, 61);
            btRegistrar.FlatStyle = FlatStyle.Popup;
            btRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btRegistrar.ForeColor = SystemColors.ButtonFace;
            btRegistrar.Location = new Point(430, 0);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(270, 43);
            btRegistrar.TabIndex = 32;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click_1;
            btRegistrar.MouseEnter += btRegistrar_MouseEnter;
            btRegistrar.MouseLeave += btRegistrar_MouseLeave;
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.BackColor = Color.Transparent;
            lbDNI.FlatStyle = FlatStyle.Flat;
            lbDNI.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDNI.Location = new Point(584, 108);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(36, 19);
            lbDNI.TabIndex = 33;
            lbDNI.Text = "DNI";
            // 
            // txDNI
            // 
            txDNI.BackColor = SystemColors.Window;
            txDNI.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txDNI.ForeColor = SystemColors.WindowFrame;
            txDNI.Location = new Point(584, 148);
            txDNI.Name = "txDNI";
            txDNI.Size = new Size(297, 27);
            txDNI.TabIndex = 31;
            txDNI.Text = "DNI";
            txDNI.Enter += txDNI_Enter_1;
            txDNI.KeyPress += txDNI_KeyPress_1;
            txDNI.Leave += txDNI_Leave_1;
            // 
            // lbError
            // 
            lbError.Anchor = AnchorStyles.Top;
            lbError.AutoSize = true;
            lbError.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbError.ForeColor = Color.Brown;
            lbError.Image = (Image)resources.GetObject("lbError.Image");
            lbError.ImageAlign = ContentAlignment.MiddleLeft;
            lbError.Location = new Point(415, 3);
            lbError.Name = "lbError";
            lbError.Size = new Size(40, 25);
            lbError.TabIndex = 34;
            lbError.Text = "Error";
            lbError.TextAlign = ContentAlignment.MiddleCenter;
            lbError.UseCompatibleTextRendering = true;
            lbError.Visible = false;
            lbError.Click += lbError_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contraVisible
            // 
            contraVisible.BackColor = Color.White;
            contraVisible.FlatStyle = FlatStyle.Flat;
            contraVisible.ForeColor = Color.DimGray;
            contraVisible.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            contraVisible.IconColor = Color.Gray;
            contraVisible.IconFont = FontAwesome.Sharp.IconFont.Auto;
            contraVisible.IconSize = 26;
            contraVisible.Location = new Point(844, 345);
            contraVisible.Name = "contraVisible";
            contraVisible.Size = new Size(37, 27);
            contraVisible.TabIndex = 37;
            contraVisible.TextAlign = ContentAlignment.MiddleRight;
            contraVisible.UseVisualStyleBackColor = false;
            contraVisible.Visible = false;
            contraVisible.Click += contraVisible_Click;
            // 
            // lbTitleRegister
            // 
            lbTitleRegister.Anchor = AnchorStyles.Top;
            lbTitleRegister.AutoSize = true;
            lbTitleRegister.BackColor = Color.Transparent;
            lbTitleRegister.FlatStyle = FlatStyle.Flat;
            lbTitleRegister.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitleRegister.ForeColor = Color.Gainsboro;
            lbTitleRegister.Location = new Point(431, 9);
            lbTitleRegister.Name = "lbTitleRegister";
            lbTitleRegister.Size = new Size(269, 33);
            lbTitleRegister.TabIndex = 0;
            lbTitleRegister.Text = "Registrar Empleado";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTitleRegister);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 51);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 79, 79);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(1076, 51);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btTablaUsuarios);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1076, 30);
            panel3.TabIndex = 40;
            // 
            // btTablaUsuarios
            // 
            btTablaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btTablaUsuarios.BackColor = Color.FromArgb(24, 61, 61);
            btTablaUsuarios.FlatAppearance.BorderSize = 0;
            btTablaUsuarios.FlatStyle = FlatStyle.Flat;
            btTablaUsuarios.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btTablaUsuarios.ForeColor = SystemColors.ButtonFace;
            btTablaUsuarios.IconChar = FontAwesome.Sharp.IconChar.TableList;
            btTablaUsuarios.IconColor = Color.Gainsboro;
            btTablaUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btTablaUsuarios.IconSize = 27;
            btTablaUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btTablaUsuarios.Location = new Point(948, 0);
            btTablaUsuarios.Name = "btTablaUsuarios";
            btTablaUsuarios.Size = new Size(128, 30);
            btTablaUsuarios.TabIndex = 0;
            btTablaUsuarios.Text = "Empleados";
            btTablaUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btTablaUsuarios.UseVisualStyleBackColor = false;
            btTablaUsuarios.Click += btTablaUsuarios_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btRegistrar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 587);
            panel4.Name = "panel4";
            panel4.Size = new Size(1076, 50);
            panel4.TabIndex = 41;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbError);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 538);
            panel5.Name = "panel5";
            panel5.Size = new Size(1076, 49);
            panel5.TabIndex = 42;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.BackColor = Color.FromArgb(221, 230, 237);
            panel6.Controls.Add(contraVisible);
            panel6.Controls.Add(txPassword);
            panel6.Controls.Add(lbNombre);
            panel6.Controls.Add(txDNI);
            panel6.Controls.Add(lbDNI);
            panel6.Controls.Add(txName);
            panel6.Controls.Add(lbApellido);
            panel6.Controls.Add(lbTipoU);
            panel6.Controls.Add(txLastName);
            panel6.Controls.Add(lbFechaN);
            panel6.Controls.Add(txcPerfil);
            panel6.Controls.Add(dTBith);
            panel6.Controls.Add(lbMail);
            panel6.Controls.Add(lbU);
            panel6.Controls.Add(lbContraseña);
            panel6.Controls.Add(txEmpleado);
            panel6.Controls.Add(txMail);
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(0, 81);
            panel6.Name = "panel6";
            panel6.Size = new Size(1076, 457);
            panel6.TabIndex = 43;
            // 
            // CUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1076, 688);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += CUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbTipoU;
        private Label lbU;
        private Label lbFechaN;
        private Label lbApellido;
        private Label lbNombre;
        private TextBox txEmpleado;
        private DateTimePicker dTBith;
        private Label lbMail;
        private TextBox txLastName;
        private TextBox txName;
        private TextBox txMail;
        private Label lbContraseña;
        private ComboBox txcPerfil;
        private TextBox txPassword;
        private Button btRegistrar;
        private Label lbDNI;
        private TextBox txDNI;
        private Label lbError;
        private NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton contraVisible;
        private Label lbTitleRegister;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btTablaUsuarios;
    }
}