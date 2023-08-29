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
            lbError = new Label();
            label1 = new Label();
            txDNI = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTipoU
            // 
            lbTipoU.Anchor = AnchorStyles.Top;
            lbTipoU.AutoSize = true;
            lbTipoU.BackColor = Color.Transparent;
            lbTipoU.FlatStyle = FlatStyle.Popup;
            lbTipoU.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTipoU.Location = new Point(25, 205);
            lbTipoU.Name = "lbTipoU";
            lbTipoU.Size = new Size(91, 16);
            lbTipoU.TabIndex = 21;
            lbTipoU.Text = "Perfil Usuario";
            // 
            // lbU
            // 
            lbU.Anchor = AnchorStyles.Top;
            lbU.AutoSize = true;
            lbU.BackColor = Color.Transparent;
            lbU.FlatStyle = FlatStyle.Popup;
            lbU.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbU.Location = new Point(25, 147);
            lbU.Name = "lbU";
            lbU.Size = new Size(55, 16);
            lbU.TabIndex = 19;
            lbU.Text = "Usuario";
            // 
            // lbFechaN
            // 
            lbFechaN.Anchor = AnchorStyles.Top;
            lbFechaN.AutoSize = true;
            lbFechaN.BackColor = Color.Transparent;
            lbFechaN.FlatStyle = FlatStyle.Popup;
            lbFechaN.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbFechaN.Location = new Point(25, 85);
            lbFechaN.Name = "lbFechaN";
            lbFechaN.Size = new Size(125, 16);
            lbFechaN.TabIndex = 20;
            lbFechaN.Text = "Fecha Nacimiento";
            // 
            // lbApellido
            // 
            lbApellido.Anchor = AnchorStyles.Top;
            lbApellido.AutoSize = true;
            lbApellido.BackColor = Color.Transparent;
            lbApellido.FlatStyle = FlatStyle.Popup;
            lbApellido.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbApellido.Location = new Point(389, 25);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(63, 16);
            lbApellido.TabIndex = 18;
            lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            lbNombre.Anchor = AnchorStyles.Top;
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.Transparent;
            lbNombre.FlatStyle = FlatStyle.Popup;
            lbNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.Location = new Point(25, 25);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(59, 16);
            lbNombre.TabIndex = 17;
            lbNombre.Text = "Nombre";
            // 
            // txEmpleado
            // 
            txEmpleado.Anchor = AnchorStyles.Top;
            txEmpleado.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEmpleado.Location = new Point(25, 167);
            txEmpleado.Name = "txEmpleado";
            txEmpleado.Size = new Size(267, 23);
            txEmpleado.TabIndex = 27;
            txEmpleado.Text = "Usuario";
            txEmpleado.Enter += txEmpleado_Enter_1;
            txEmpleado.Leave += txEmpleado_Leave_1;
            // 
            // dTBith
            // 
            dTBith.Anchor = AnchorStyles.Top;
            dTBith.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dTBith.Location = new Point(25, 105);
            dTBith.Name = "dTBith";
            dTBith.Size = new Size(267, 23);
            dTBith.TabIndex = 29;
            // 
            // lbMail
            // 
            lbMail.Anchor = AnchorStyles.Top;
            lbMail.AutoSize = true;
            lbMail.BackColor = Color.Transparent;
            lbMail.FlatStyle = FlatStyle.Popup;
            lbMail.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMail.Location = new Point(389, 85);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(127, 16);
            lbMail.TabIndex = 22;
            lbMail.Text = "Correo Electronico";
            // 
            // txLastName
            // 
            txLastName.Anchor = AnchorStyles.Top;
            txLastName.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txLastName.Location = new Point(389, 45);
            txLastName.Name = "txLastName";
            txLastName.Size = new Size(267, 23);
            txLastName.TabIndex = 25;
            txLastName.Text = "Apellido";
            txLastName.Enter += txLastName_Enter_1;
            txLastName.KeyPress += txLastName_KeyPress_1;
            txLastName.Leave += txLastName_Leave_1;
            // 
            // txName
            // 
            txName.Anchor = AnchorStyles.Top;
            txName.Cursor = Cursors.IBeam;
            txName.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txName.Location = new Point(25, 45);
            txName.Name = "txName";
            txName.Size = new Size(267, 23);
            txName.TabIndex = 24;
            txName.Text = "Nombre";
            txName.Enter += txName_Enter_1;
            txName.KeyPress += txName_KeyPress_1;
            txName.Leave += txName_Leave_1;
            // 
            // txMail
            // 
            txMail.Anchor = AnchorStyles.Top;
            txMail.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txMail.Location = new Point(389, 107);
            txMail.Name = "txMail";
            txMail.Size = new Size(267, 23);
            txMail.TabIndex = 26;
            txMail.Text = "Correo Electronico";
            txMail.Enter += txMail_Enter_1;
            txMail.Leave += txMail_Leave_1;
            // 
            // lbContraseña
            // 
            lbContraseña.Anchor = AnchorStyles.Top;
            lbContraseña.AutoSize = true;
            lbContraseña.BackColor = Color.Transparent;
            lbContraseña.FlatStyle = FlatStyle.Popup;
            lbContraseña.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbContraseña.Location = new Point(389, 147);
            lbContraseña.Name = "lbContraseña";
            lbContraseña.Size = new Size(82, 16);
            lbContraseña.TabIndex = 23;
            lbContraseña.Text = "Contraseña";
            // 
            // txcPerfil
            // 
            txcPerfil.Anchor = AnchorStyles.Top;
            txcPerfil.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txcPerfil.FormattingEnabled = true;
            txcPerfil.Items.AddRange(new object[] { "1-Gerente", "2-Administrador", "3-Vendedor" });
            txcPerfil.Location = new Point(25, 225);
            txcPerfil.Name = "txcPerfil";
            txcPerfil.Size = new Size(267, 25);
            txcPerfil.TabIndex = 30;
            txcPerfil.Text = "Seleccione Usuario";
            // 
            // txPassword
            // 
            txPassword.Anchor = AnchorStyles.Top;
            txPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txPassword.Location = new Point(389, 167);
            txPassword.Name = "txPassword";
            txPassword.Size = new Size(267, 23);
            txPassword.TabIndex = 28;
            txPassword.Text = "Contraseña";
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
            btRegistrar.Location = new Point(276, 326);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(134, 43);
            btRegistrar.TabIndex = 32;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click_1;
            // 
            // lbError
            // 
            lbError.Anchor = AnchorStyles.Top;
            lbError.AutoSize = true;
            lbError.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbError.ForeColor = Color.Brown;
            lbError.Image = (Image)resources.GetObject("lbError.Image");
            lbError.ImageAlign = ContentAlignment.MiddleLeft;
            lbError.Location = new Point(190, 275);
            lbError.Name = "lbError";
            lbError.Size = new Size(38, 23);
            lbError.TabIndex = 34;
            lbError.Text = "Error";
            lbError.TextAlign = ContentAlignment.MiddleCenter;
            lbError.UseCompatibleTextRendering = true;
            lbError.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(389, 205);
            label1.Name = "label1";
            label1.Size = new Size(30, 16);
            label1.TabIndex = 33;
            label1.Text = "DNI";
            // 
            // txDNI
            // 
            txDNI.Anchor = AnchorStyles.Top;
            txDNI.BackColor = SystemColors.Window;
            txDNI.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txDNI.Location = new Point(389, 227);
            txDNI.Name = "txDNI";
            txDNI.Size = new Size(267, 23);
            txDNI.TabIndex = 31;
            txDNI.Text = "DNI";
            txDNI.Enter += txDNI_Enter_1;
            txDNI.KeyPress += txDNI_KeyPress_1;
            txDNI.Leave += txDNI_Leave_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(txDNI);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbError);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(txPassword);
            panel1.Controls.Add(txcPerfil);
            panel1.Controls.Add(lbContraseña);
            panel1.Controls.Add(txMail);
            panel1.Controls.Add(txName);
            panel1.Controls.Add(txLastName);
            panel1.Controls.Add(lbMail);
            panel1.Controls.Add(dTBith);
            panel1.Controls.Add(txEmpleado);
            panel1.Controls.Add(lbNombre);
            panel1.Controls.Add(lbApellido);
            panel1.Controls.Add(lbFechaN);
            panel1.Controls.Add(lbU);
            panel1.Controls.Add(lbTipoU);
            panel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 389);
            panel1.TabIndex = 35;
            // 
            // CUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Usuario";
            Load += CUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lbError;
        private Label label1;
        private TextBox txDNI;
        private Panel panel1;
    }
}