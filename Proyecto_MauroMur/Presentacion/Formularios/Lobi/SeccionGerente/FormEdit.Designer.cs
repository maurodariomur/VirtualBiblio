namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            label1 = new Label();
            panel1 = new Panel();
            lbTitleEditar = new Label();
            panel2 = new Panel();
            button1 = new Button();
            btGuardarDatos = new Button();
            panel3 = new Panel();
            lbErrorModificar = new Label();
            lbNombre = new Label();
            lbDNI = new Label();
            lbApellido = new Label();
            lbTipoU = new Label();
            lbFechaN = new Label();
            lbMail = new Label();
            lbU = new Label();
            txDNIModificar = new TextBox();
            txNameModificar = new TextBox();
            txLastNameModificar = new TextBox();
            txcPerfilModificar = new ComboBox();
            dTBithModificar = new DateTimePicker();
            txEmpleadoModificar = new TextBox();
            txMailModificar = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTitleEditar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 51);
            panel1.TabIndex = 1;
            // 
            // lbTitleEditar
            // 
            lbTitleEditar.Anchor = AnchorStyles.Top;
            lbTitleEditar.AutoSize = true;
            lbTitleEditar.BackColor = Color.Transparent;
            lbTitleEditar.FlatStyle = FlatStyle.Flat;
            lbTitleEditar.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitleEditar.ForeColor = Color.Gainsboro;
            lbTitleEditar.Location = new Point(155, 9);
            lbTitleEditar.Name = "lbTitleEditar";
            lbTitleEditar.Size = new Size(311, 33);
            lbTitleEditar.TabIndex = 1;
            lbTitleEditar.Text = "Editar Datos Empleado";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btGuardarDatos);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 423);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 50);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(335, 0);
            button1.Name = "button1";
            button1.Size = new Size(176, 38);
            button1.TabIndex = 34;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btGuardarDatos
            // 
            btGuardarDatos.Anchor = AnchorStyles.Top;
            btGuardarDatos.BackColor = Color.FromArgb(24, 61, 61);
            btGuardarDatos.FlatStyle = FlatStyle.Popup;
            btGuardarDatos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btGuardarDatos.ForeColor = SystemColors.ButtonFace;
            btGuardarDatos.Location = new Point(85, 0);
            btGuardarDatos.Name = "btGuardarDatos";
            btGuardarDatos.Size = new Size(175, 38);
            btGuardarDatos.TabIndex = 33;
            btGuardarDatos.Text = "Modificar";
            btGuardarDatos.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbErrorModificar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 387);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 36);
            panel3.TabIndex = 3;
            // 
            // lbErrorModificar
            // 
            lbErrorModificar.Anchor = AnchorStyles.Top;
            lbErrorModificar.AutoSize = true;
            lbErrorModificar.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorModificar.ForeColor = Color.Brown;
            lbErrorModificar.Image = (Image)resources.GetObject("lbErrorModificar.Image");
            lbErrorModificar.ImageAlign = ContentAlignment.MiddleLeft;
            lbErrorModificar.Location = new Point(220, 8);
            lbErrorModificar.Name = "lbErrorModificar";
            lbErrorModificar.Size = new Size(40, 25);
            lbErrorModificar.TabIndex = 35;
            lbErrorModificar.Text = "Error";
            lbErrorModificar.TextAlign = ContentAlignment.MiddleCenter;
            lbErrorModificar.UseCompatibleTextRendering = true;
            lbErrorModificar.Visible = false;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.Transparent;
            lbNombre.FlatStyle = FlatStyle.Popup;
            lbNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.Location = new Point(85, 83);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(59, 16);
            lbNombre.TabIndex = 34;
            lbNombre.Text = "Nombre";
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.BackColor = Color.Transparent;
            lbDNI.FlatStyle = FlatStyle.Flat;
            lbDNI.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbDNI.Location = new Point(335, 153);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(30, 16);
            lbDNI.TabIndex = 40;
            lbDNI.Text = "DNI";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.BackColor = Color.Transparent;
            lbApellido.FlatStyle = FlatStyle.Popup;
            lbApellido.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbApellido.Location = new Point(335, 83);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(63, 16);
            lbApellido.TabIndex = 35;
            lbApellido.Text = "Apellido";
            // 
            // lbTipoU
            // 
            lbTipoU.AutoSize = true;
            lbTipoU.BackColor = Color.Transparent;
            lbTipoU.FlatStyle = FlatStyle.Flat;
            lbTipoU.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTipoU.Location = new Point(335, 222);
            lbTipoU.Name = "lbTipoU";
            lbTipoU.Size = new Size(91, 16);
            lbTipoU.TabIndex = 38;
            lbTipoU.Text = "Perfil Usuario";
            // 
            // lbFechaN
            // 
            lbFechaN.AutoSize = true;
            lbFechaN.BackColor = Color.Transparent;
            lbFechaN.FlatStyle = FlatStyle.Popup;
            lbFechaN.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbFechaN.Location = new Point(85, 153);
            lbFechaN.Name = "lbFechaN";
            lbFechaN.Size = new Size(125, 16);
            lbFechaN.TabIndex = 37;
            lbFechaN.Text = "Fecha Nacimiento";
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.BackColor = Color.Transparent;
            lbMail.FlatStyle = FlatStyle.Popup;
            lbMail.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMail.Location = new Point(85, 222);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(127, 16);
            lbMail.TabIndex = 39;
            lbMail.Text = "Correo Electronico";
            // 
            // lbU
            // 
            lbU.AutoSize = true;
            lbU.BackColor = Color.Transparent;
            lbU.FlatStyle = FlatStyle.Popup;
            lbU.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbU.Location = new Point(85, 299);
            lbU.Name = "lbU";
            lbU.Size = new Size(55, 16);
            lbU.TabIndex = 36;
            lbU.Text = "Usuario";
            // 
            // txDNIModificar
            // 
            txDNIModificar.BackColor = SystemColors.Window;
            txDNIModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txDNIModificar.ForeColor = SystemColors.WindowFrame;
            txDNIModificar.Location = new Point(335, 183);
            txDNIModificar.Name = "txDNIModificar";
            txDNIModificar.Size = new Size(176, 23);
            txDNIModificar.TabIndex = 47;
            txDNIModificar.Text = "DNI";
            // 
            // txNameModificar
            // 
            txNameModificar.Cursor = Cursors.IBeam;
            txNameModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txNameModificar.ForeColor = SystemColors.WindowFrame;
            txNameModificar.Location = new Point(85, 114);
            txNameModificar.Name = "txNameModificar";
            txNameModificar.Size = new Size(175, 23);
            txNameModificar.TabIndex = 41;
            txNameModificar.Text = "Nombre";
            // 
            // txLastNameModificar
            // 
            txLastNameModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txLastNameModificar.ForeColor = SystemColors.WindowFrame;
            txLastNameModificar.Location = new Point(335, 114);
            txLastNameModificar.Name = "txLastNameModificar";
            txLastNameModificar.Size = new Size(176, 23);
            txLastNameModificar.TabIndex = 42;
            txLastNameModificar.Text = "Apellido";
            // 
            // txcPerfilModificar
            // 
            txcPerfilModificar.BackColor = SystemColors.Window;
            txcPerfilModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txcPerfilModificar.ForeColor = SystemColors.WindowFrame;
            txcPerfilModificar.FormattingEnabled = true;
            txcPerfilModificar.Items.AddRange(new object[] { "1-Gerente", "2-Administrador", "3-Vendedor" });
            txcPerfilModificar.Location = new Point(335, 252);
            txcPerfilModificar.Name = "txcPerfilModificar";
            txcPerfilModificar.Size = new Size(176, 25);
            txcPerfilModificar.TabIndex = 46;
            txcPerfilModificar.Text = "Seleccione Usuario";
            // 
            // dTBithModificar
            // 
            dTBithModificar.CalendarForeColor = SystemColors.WindowFrame;
            dTBithModificar.CalendarTitleForeColor = SystemColors.WindowFrame;
            dTBithModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dTBithModificar.Location = new Point(85, 181);
            dTBithModificar.Name = "dTBithModificar";
            dTBithModificar.Size = new Size(175, 23);
            dTBithModificar.TabIndex = 45;
            // 
            // txEmpleadoModificar
            // 
            txEmpleadoModificar.BorderStyle = BorderStyle.FixedSingle;
            txEmpleadoModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEmpleadoModificar.ForeColor = SystemColors.WindowFrame;
            txEmpleadoModificar.Location = new Point(85, 328);
            txEmpleadoModificar.Name = "txEmpleadoModificar";
            txEmpleadoModificar.Size = new Size(175, 23);
            txEmpleadoModificar.TabIndex = 44;
            txEmpleadoModificar.Text = "Usuario";
            // 
            // txMailModificar
            // 
            txMailModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txMailModificar.ForeColor = SystemColors.WindowFrame;
            txMailModificar.Location = new Point(85, 255);
            txMailModificar.Name = "txMailModificar";
            txMailModificar.Size = new Size(175, 23);
            txMailModificar.TabIndex = 43;
            txMailModificar.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(412, 299);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 48;
            label2.Text = "Baja";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(379, 328);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(40, 25);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "Si";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(441, 328);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 25);
            checkBox2.TabIndex = 50;
            checkBox2.Text = "No";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(580, 473);
            ControlBox = false;
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(txDNIModificar);
            Controls.Add(txNameModificar);
            Controls.Add(txLastNameModificar);
            Controls.Add(txcPerfilModificar);
            Controls.Add(dTBithModificar);
            Controls.Add(txEmpleadoModificar);
            Controls.Add(txMailModificar);
            Controls.Add(lbNombre);
            Controls.Add(lbDNI);
            Controls.Add(lbApellido);
            Controls.Add(lbTipoU);
            Controls.Add(lbFechaN);
            Controls.Add(lbMail);
            Controls.Add(lbU);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEdit";
            Opacity = 0.93D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btGuardarDatos;
        private Panel panel3;
        private Label lbTitleEditar;
        private Label lbNombre;
        private Label lbDNI;
        private Label lbApellido;
        private Label lbTipoU;
        private Label lbFechaN;
        private Label lbMail;
        private Label lbU;
        private TextBox txDNIModificar;
        private TextBox txNameModificar;
        private TextBox txLastNameModificar;
        private ComboBox txcPerfilModificar;
        private DateTimePicker dTBithModificar;
        private TextBox txEmpleadoModificar;
        private TextBox txMailModificar;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Label lbErrorModificar;
    }
}