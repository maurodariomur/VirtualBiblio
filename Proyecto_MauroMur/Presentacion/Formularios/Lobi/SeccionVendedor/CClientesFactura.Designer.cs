namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    partial class CClientesFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CClientesFactura));
            panel1 = new Panel();
            iconAtrasDet = new FontAwesome.Sharp.IconButton();
            lbTitleDetalle = new Label();
            panel2 = new Panel();
            btnConfirmar = new Button();
            panel3 = new Panel();
            lbError = new Label();
            cbTipoFactura = new ComboBox();
            lbTipoFactura = new Label();
            tbMP = new TextBox();
            tbNumeroTarjeta = new TextBox();
            rbMercadoPago = new RadioButton();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            lbFormaPago = new Label();
            lbCliente = new Label();
            lbDNI = new Label();
            ibAgregarCliente = new FontAwesome.Sharp.IconButton();
            lbNombreApellido = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 72, 107);
            panel1.Controls.Add(iconAtrasDet);
            panel1.Controls.Add(lbTitleDetalle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 47);
            panel1.TabIndex = 0;
            // 
            // iconAtrasDet
            // 
            iconAtrasDet.BackColor = Color.Transparent;
            iconAtrasDet.Cursor = Cursors.Hand;
            iconAtrasDet.Dock = DockStyle.Left;
            iconAtrasDet.FlatAppearance.BorderSize = 0;
            iconAtrasDet.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 131, 116);
            iconAtrasDet.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 177, 166);
            iconAtrasDet.FlatStyle = FlatStyle.Flat;
            iconAtrasDet.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconAtrasDet.IconColor = Color.FromArgb(175, 211, 226);
            iconAtrasDet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAtrasDet.IconSize = 30;
            iconAtrasDet.ImageAlign = ContentAlignment.BottomCenter;
            iconAtrasDet.Location = new Point(0, 0);
            iconAtrasDet.Name = "iconAtrasDet";
            iconAtrasDet.Size = new Size(40, 47);
            iconAtrasDet.TabIndex = 75;
            iconAtrasDet.UseVisualStyleBackColor = false;
            iconAtrasDet.Click += iconAtrasDet_Click;
            // 
            // lbTitleDetalle
            // 
            lbTitleDetalle.Anchor = AnchorStyles.Top;
            lbTitleDetalle.AutoSize = true;
            lbTitleDetalle.BackColor = Color.Transparent;
            lbTitleDetalle.FlatStyle = FlatStyle.Flat;
            lbTitleDetalle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitleDetalle.ForeColor = Color.Gainsboro;
            lbTitleDetalle.Location = new Point(162, 9);
            lbTitleDetalle.Name = "lbTitleDetalle";
            lbTitleDetalle.Size = new Size(239, 31);
            lbTitleDetalle.TabIndex = 2;
            lbTitleDetalle.Text = "Portal de Detalle ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 145, 151);
            panel2.Controls.Add(btnConfirmar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 54);
            panel2.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(18, 72, 107);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = SystemColors.ButtonFace;
            btnConfirmar.Location = new Point(186, 0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(171, 35);
            btnConfirmar.TabIndex = 37;
            btnConfirmar.Text = "Confimar Venta";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(65, 145, 151);
            panel3.Controls.Add(lbError);
            panel3.Controls.Add(cbTipoFactura);
            panel3.Controls.Add(lbTipoFactura);
            panel3.Controls.Add(tbMP);
            panel3.Controls.Add(tbNumeroTarjeta);
            panel3.Controls.Add(rbMercadoPago);
            panel3.Controls.Add(rbTarjeta);
            panel3.Controls.Add(rbEfectivo);
            panel3.Controls.Add(lbFormaPago);
            panel3.Controls.Add(lbCliente);
            panel3.Controls.Add(lbDNI);
            panel3.Controls.Add(ibAgregarCliente);
            panel3.Controls.Add(lbNombreApellido);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 412);
            panel3.TabIndex = 2;
            // 
            // lbError
            // 
            lbError.Anchor = AnchorStyles.Top;
            lbError.AutoSize = true;
            lbError.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbError.ForeColor = Color.Brown;
            lbError.Image = (Image)resources.GetObject("lbError.Image");
            lbError.ImageAlign = ContentAlignment.MiddleLeft;
            lbError.Location = new Point(225, 384);
            lbError.Name = "lbError";
            lbError.Size = new Size(40, 25);
            lbError.TabIndex = 35;
            lbError.Text = "Error";
            lbError.TextAlign = ContentAlignment.MiddleCenter;
            lbError.UseCompatibleTextRendering = true;
            lbError.Visible = false;
            // 
            // cbTipoFactura
            // 
            cbTipoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoFactura.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoFactura.FormattingEnabled = true;
            cbTipoFactura.Location = new Point(257, 300);
            cbTipoFactura.Name = "cbTipoFactura";
            cbTipoFactura.Size = new Size(161, 25);
            cbTipoFactura.TabIndex = 24;
            // 
            // lbTipoFactura
            // 
            lbTipoFactura.AutoSize = true;
            lbTipoFactura.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbTipoFactura.Location = new Point(93, 300);
            lbTipoFactura.Name = "lbTipoFactura";
            lbTipoFactura.Size = new Size(153, 23);
            lbTipoFactura.TabIndex = 18;
            lbTipoFactura.Text = "Tipo de Factura";
            // 
            // tbMP
            // 
            tbMP.Location = new Point(257, 244);
            tbMP.Name = "tbMP";
            tbMP.PlaceholderText = "CBU,CVU o Alias";
            tbMP.Size = new Size(161, 23);
            tbMP.TabIndex = 23;
            tbMP.Visible = false;
            // 
            // tbNumeroTarjeta
            // 
            tbNumeroTarjeta.Location = new Point(257, 205);
            tbNumeroTarjeta.Name = "tbNumeroTarjeta";
            tbNumeroTarjeta.PlaceholderText = "XXXX-XXXX-XXXX-XXXX";
            tbNumeroTarjeta.Size = new Size(161, 23);
            tbNumeroTarjeta.TabIndex = 22;
            tbNumeroTarjeta.Visible = false;
            // 
            // rbMercadoPago
            // 
            rbMercadoPago.AutoSize = true;
            rbMercadoPago.Location = new Point(93, 244);
            rbMercadoPago.Name = "rbMercadoPago";
            rbMercadoPago.Size = new Size(102, 19);
            rbMercadoPago.TabIndex = 21;
            rbMercadoPago.TabStop = true;
            rbMercadoPago.Text = "Mercado Pago";
            rbMercadoPago.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(93, 205);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(141, 19);
            rbTarjeta.TabIndex = 20;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta Credito/Debito";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(93, 170);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 19;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lbFormaPago
            // 
            lbFormaPago.AutoSize = true;
            lbFormaPago.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbFormaPago.Location = new Point(186, 120);
            lbFormaPago.Name = "lbFormaPago";
            lbFormaPago.Size = new Size(154, 23);
            lbFormaPago.TabIndex = 17;
            lbFormaPago.Text = "Forma de pago";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCliente.Location = new Point(225, 23);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(76, 23);
            lbCliente.TabIndex = 16;
            lbCliente.Text = "Cliente";
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDNI.Location = new Point(375, 67);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(43, 22);
            lbDNI.TabIndex = 15;
            lbDNI.Text = "DNI";
            // 
            // ibAgregarCliente
            // 
            ibAgregarCliente.BackColor = Color.Transparent;
            ibAgregarCliente.Cursor = Cursors.Hand;
            ibAgregarCliente.FlatAppearance.BorderSize = 0;
            ibAgregarCliente.FlatStyle = FlatStyle.Flat;
            ibAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ibAgregarCliente.IconColor = Color.Black;
            ibAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibAgregarCliente.IconSize = 40;
            ibAgregarCliente.Location = new Point(93, 64);
            ibAgregarCliente.Name = "ibAgregarCliente";
            ibAgregarCliente.Size = new Size(48, 33);
            ibAgregarCliente.TabIndex = 14;
            ibAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // lbNombreApellido
            // 
            lbNombreApellido.AutoSize = true;
            lbNombreApellido.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombreApellido.Location = new Point(147, 65);
            lbNombreApellido.Name = "lbNombreApellido";
            lbNombreApellido.Size = new Size(0, 22);
            lbNombreApellido.TabIndex = 13;
            lbNombreApellido.Text = "Nombre y Apellido";
            // 
            // CClientesFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(530, 513);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CClientesFactura";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CClientesFactura";
            Load += CClientesFactura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTitleDetalle;
        private FontAwesome.Sharp.IconButton iconAtrasDet;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbTipoFactura;
        private Label lbTipoFactura;
        private TextBox tbMP;
        private TextBox tbNumeroTarjeta;
        private RadioButton rbMercadoPago;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private Label lbFormaPago;
        private Label lbCliente;
        private Label lbDNI;
        private FontAwesome.Sharp.IconButton ibAgregarCliente;
        private Label lbNombreApellido;
        private Button btnConfirmar;
        private Label lbError;
    }
}