namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    partial class CAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAgregarCliente));
            panel1 = new Panel();
            iconAtrasU = new FontAwesome.Sharp.IconButton();
            lbAgregarCliente = new Label();
            panel2 = new Panel();
            btnConfirmar = new Button();
            panel3 = new Panel();
            lbErrorModificar = new Label();
            panel4 = new Panel();
            tbDomicilioAgCliente = new TextBox();
            label1 = new Label();
            tbTelefonoAgCliente = new TextBox();
            label3 = new Label();
            checkBoxNo = new CheckBox();
            checkBoxSi = new CheckBox();
            label2 = new Label();
            txDNIAgCliente = new TextBox();
            txNombreAgCliente = new TextBox();
            txApellidoAgCliente = new TextBox();
            dTBithAgCliente = new DateTimePicker();
            txMailAgCliente = new TextBox();
            lbNombre = new Label();
            lbDNI = new Label();
            lbApellido = new Label();
            lbFechaN = new Label();
            lbMail = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 72, 107);
            panel1.Controls.Add(iconAtrasU);
            panel1.Controls.Add(lbAgregarCliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 50);
            panel1.TabIndex = 0;
            // 
            // iconAtrasU
            // 
            iconAtrasU.BackColor = Color.Transparent;
            iconAtrasU.Cursor = Cursors.Hand;
            iconAtrasU.Dock = DockStyle.Left;
            iconAtrasU.FlatAppearance.BorderSize = 0;
            iconAtrasU.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 131, 116);
            iconAtrasU.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 177, 166);
            iconAtrasU.FlatStyle = FlatStyle.Flat;
            iconAtrasU.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconAtrasU.IconColor = Color.FromArgb(175, 211, 226);
            iconAtrasU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAtrasU.IconSize = 30;
            iconAtrasU.ImageAlign = ContentAlignment.BottomCenter;
            iconAtrasU.Location = new Point(0, 0);
            iconAtrasU.Name = "iconAtrasU";
            iconAtrasU.Size = new Size(53, 50);
            iconAtrasU.TabIndex = 76;
            iconAtrasU.UseVisualStyleBackColor = false;
            iconAtrasU.Click += iconAtrasU_Click;
            // 
            // lbAgregarCliente
            // 
            lbAgregarCliente.Anchor = AnchorStyles.Top;
            lbAgregarCliente.AutoSize = true;
            lbAgregarCliente.BackColor = Color.Transparent;
            lbAgregarCliente.FlatStyle = FlatStyle.Flat;
            lbAgregarCliente.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbAgregarCliente.ForeColor = Color.Gainsboro;
            lbAgregarCliente.Location = new Point(210, 9);
            lbAgregarCliente.Name = "lbAgregarCliente";
            lbAgregarCliente.Size = new Size(217, 31);
            lbAgregarCliente.TabIndex = 3;
            lbAgregarCliente.Text = "Agregar Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 90, 120);
            panel2.Controls.Add(btnConfirmar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 470);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 48);
            panel2.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(18, 72, 107);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Gainsboro;
            btnConfirmar.Location = new Point(235, 0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(171, 35);
            btnConfirmar.TabIndex = 38;
            btnConfirmar.Text = "Confimar Venta";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 90, 120);
            panel3.Controls.Add(lbErrorModificar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 30);
            panel3.TabIndex = 2;
            // 
            // lbErrorModificar
            // 
            lbErrorModificar.Anchor = AnchorStyles.Top;
            lbErrorModificar.AutoSize = true;
            lbErrorModificar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorModificar.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorModificar.Image = (Image)resources.GetObject("lbErrorModificar.Image");
            lbErrorModificar.ImageAlign = ContentAlignment.MiddleLeft;
            lbErrorModificar.Location = new Point(168, 3);
            lbErrorModificar.Name = "lbErrorModificar";
            lbErrorModificar.Size = new Size(35, 20);
            lbErrorModificar.TabIndex = 37;
            lbErrorModificar.Text = "Error";
            lbErrorModificar.TextAlign = ContentAlignment.MiddleCenter;
            lbErrorModificar.UseCompatibleTextRendering = true;
            lbErrorModificar.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(22, 90, 120);
            panel4.Controls.Add(tbDomicilioAgCliente);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(tbTelefonoAgCliente);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(checkBoxNo);
            panel4.Controls.Add(checkBoxSi);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txDNIAgCliente);
            panel4.Controls.Add(txNombreAgCliente);
            panel4.Controls.Add(txApellidoAgCliente);
            panel4.Controls.Add(dTBithAgCliente);
            panel4.Controls.Add(txMailAgCliente);
            panel4.Controls.Add(lbNombre);
            panel4.Controls.Add(lbDNI);
            panel4.Controls.Add(lbApellido);
            panel4.Controls.Add(lbFechaN);
            panel4.Controls.Add(lbMail);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(634, 390);
            panel4.TabIndex = 3;
            // 
            // tbDomicilioAgCliente
            // 
            tbDomicilioAgCliente.BackColor = SystemColors.Window;
            tbDomicilioAgCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDomicilioAgCliente.ForeColor = SystemColors.WindowFrame;
            tbDomicilioAgCliente.Location = new Point(108, 308);
            tbDomicilioAgCliente.Name = "tbDomicilioAgCliente";
            tbDomicilioAgCliente.PlaceholderText = "Domicilio";
            tbDomicilioAgCliente.Size = new Size(176, 22);
            tbDomicilioAgCliente.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(108, 279);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 70;
            label1.Text = "Domicilio";
            // 
            // tbTelefonoAgCliente
            // 
            tbTelefonoAgCliente.BackColor = SystemColors.Window;
            tbTelefonoAgCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefonoAgCliente.ForeColor = SystemColors.WindowFrame;
            tbTelefonoAgCliente.Location = new Point(358, 227);
            tbTelefonoAgCliente.Name = "tbTelefonoAgCliente";
            tbTelefonoAgCliente.PlaceholderText = "Telefono";
            tbTelefonoAgCliente.Size = new Size(178, 22);
            tbTelefonoAgCliente.TabIndex = 69;
            tbTelefonoAgCliente.KeyPress += tbTelefonoAgCliente_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(358, 194);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 68;
            label3.Text = "Telefono";
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNo.ForeColor = Color.Gainsboro;
            checkBoxNo.Location = new Point(464, 308);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(48, 24);
            checkBoxNo.TabIndex = 67;
            checkBoxNo.Text = "No";
            checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // checkBoxSi
            // 
            checkBoxSi.AutoSize = true;
            checkBoxSi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSi.ForeColor = Color.Gainsboro;
            checkBoxSi.Location = new Point(402, 308);
            checkBoxSi.Name = "checkBoxSi";
            checkBoxSi.Size = new Size(42, 24);
            checkBoxSi.TabIndex = 66;
            checkBoxSi.Text = "Si";
            checkBoxSi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(435, 279);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 65;
            label2.Text = "Baja";
            // 
            // txDNIAgCliente
            // 
            txDNIAgCliente.BackColor = SystemColors.Window;
            txDNIAgCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txDNIAgCliente.ForeColor = SystemColors.WindowFrame;
            txDNIAgCliente.Location = new Point(358, 150);
            txDNIAgCliente.Name = "txDNIAgCliente";
            txDNIAgCliente.PlaceholderText = "DNI";
            txDNIAgCliente.Size = new Size(176, 22);
            txDNIAgCliente.TabIndex = 64;
            txDNIAgCliente.KeyPress += txDNIAgCliente_KeyPress;
            // 
            // txNombreAgCliente
            // 
            txNombreAgCliente.Cursor = Cursors.IBeam;
            txNombreAgCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txNombreAgCliente.ForeColor = SystemColors.WindowFrame;
            txNombreAgCliente.Location = new Point(108, 75);
            txNombreAgCliente.Name = "txNombreAgCliente";
            txNombreAgCliente.PlaceholderText = "Nombre";
            txNombreAgCliente.Size = new Size(175, 22);
            txNombreAgCliente.TabIndex = 58;
            txNombreAgCliente.KeyPress += txNombreAgCliente_KeyPress;
            // 
            // txApellidoAgCliente
            // 
            txApellidoAgCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txApellidoAgCliente.ForeColor = SystemColors.WindowFrame;
            txApellidoAgCliente.Location = new Point(358, 75);
            txApellidoAgCliente.Name = "txApellidoAgCliente";
            txApellidoAgCliente.PlaceholderText = "Apellido";
            txApellidoAgCliente.Size = new Size(176, 22);
            txApellidoAgCliente.TabIndex = 59;
            txApellidoAgCliente.KeyPress += txApellidoAgCliente_KeyPress;
            // 
            // dTBithAgCliente
            // 
            dTBithAgCliente.CalendarForeColor = SystemColors.WindowFrame;
            dTBithAgCliente.CalendarTitleForeColor = SystemColors.WindowFrame;
            dTBithAgCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dTBithAgCliente.Location = new Point(108, 148);
            dTBithAgCliente.Name = "dTBithAgCliente";
            dTBithAgCliente.Size = new Size(175, 22);
            dTBithAgCliente.TabIndex = 62;
            // 
            // txMailAgCliente
            // 
            txMailAgCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txMailAgCliente.ForeColor = SystemColors.WindowFrame;
            txMailAgCliente.Location = new Point(108, 227);
            txMailAgCliente.Name = "txMailAgCliente";
            txMailAgCliente.PlaceholderText = "Correo Electronico";
            txMailAgCliente.Size = new Size(175, 22);
            txMailAgCliente.TabIndex = 60;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.Transparent;
            lbNombre.FlatStyle = FlatStyle.Popup;
            lbNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.ForeColor = Color.Gainsboro;
            lbNombre.Location = new Point(108, 44);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(68, 18);
            lbNombre.TabIndex = 51;
            lbNombre.Text = "Nombre";
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.BackColor = Color.Transparent;
            lbDNI.FlatStyle = FlatStyle.Flat;
            lbDNI.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDNI.ForeColor = Color.Gainsboro;
            lbDNI.Location = new Point(358, 120);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(36, 18);
            lbDNI.TabIndex = 57;
            lbDNI.Text = "DNI";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.BackColor = Color.Transparent;
            lbApellido.FlatStyle = FlatStyle.Popup;
            lbApellido.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbApellido.ForeColor = Color.Gainsboro;
            lbApellido.Location = new Point(358, 44);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(67, 18);
            lbApellido.TabIndex = 52;
            lbApellido.Text = "Apellido";
            // 
            // lbFechaN
            // 
            lbFechaN.AutoSize = true;
            lbFechaN.BackColor = Color.Transparent;
            lbFechaN.FlatStyle = FlatStyle.Popup;
            lbFechaN.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbFechaN.ForeColor = Color.Gainsboro;
            lbFechaN.Location = new Point(108, 120);
            lbFechaN.Name = "lbFechaN";
            lbFechaN.Size = new Size(144, 18);
            lbFechaN.TabIndex = 54;
            lbFechaN.Text = "Fecha Nacimiento";
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.BackColor = Color.Transparent;
            lbMail.FlatStyle = FlatStyle.Popup;
            lbMail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMail.ForeColor = Color.Gainsboro;
            lbMail.Location = new Point(108, 194);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(152, 18);
            lbMail.TabIndex = 56;
            lbMail.Text = "Correo Electronico";
            // 
            // CAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 518);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CAgregarCliente";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAgregarCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxSi;
        private Label label2;
        private TextBox txDNIAgCliente;
        private TextBox txNombreAgCliente;
        private TextBox txApellidoAgCliente;
        private DateTimePicker dTBithAgCliente;
        private TextBox txMailAgCliente;
        private Label lbNombre;
        private Label lbDNI;
        private Label lbApellido;
        private Label lbFechaN;
        private Label lbMail;
        private Label lbErrorModificar;
        private Button btnConfirmar;
        private Label lbAgregarCliente;
        private TextBox tbDomicilioAgCliente;
        private Label label1;
        private TextBox tbTelefonoAgCliente;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconAtrasU;
    }
}