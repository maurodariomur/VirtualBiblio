namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    partial class BotonesLibros
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
            panel1 = new Panel();
            panel6 = new Panel();
            btAñadir = new Button();
            panel5 = new Panel();
            rtbDescripcionCatalogo = new RichTextBox();
            lbDescripcionCatalogo = new Label();
            panel4 = new Panel();
            lbStockCatalogo = new Label();
            lbPrecioCatalogo = new Label();
            panel3 = new Panel();
            lbTituloCatalogo = new Label();
            panel2 = new Panel();
            pbImagenCatalogo = new PictureBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenCatalogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 456);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(5, 59, 80);
            panel6.Controls.Add(btAñadir);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 411);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 45);
            panel6.TabIndex = 4;
            // 
            // btAñadir
            // 
            btAñadir.BackColor = Color.FromArgb(23, 107, 135);
            btAñadir.Cursor = Cursors.Hand;
            btAñadir.Dock = DockStyle.Bottom;
            btAñadir.FlatStyle = FlatStyle.Popup;
            btAñadir.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAñadir.ForeColor = SystemColors.ButtonFace;
            btAñadir.Location = new Point(0, 0);
            btAñadir.Name = "btAñadir";
            btAñadir.Size = new Size(231, 45);
            btAñadir.TabIndex = 33;
            btAñadir.Text = "Añadir";
            btAñadir.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(5, 59, 80);
            panel5.Controls.Add(rtbDescripcionCatalogo);
            panel5.Controls.Add(lbDescripcionCatalogo);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 305);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 108);
            panel5.TabIndex = 3;
            // 
            // rtbDescripcionCatalogo
            // 
            rtbDescripcionCatalogo.BackColor = Color.FromArgb(5, 59, 80);
            rtbDescripcionCatalogo.BorderStyle = BorderStyle.None;
            rtbDescripcionCatalogo.Dock = DockStyle.Fill;
            rtbDescripcionCatalogo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDescripcionCatalogo.ForeColor = SystemColors.Window;
            rtbDescripcionCatalogo.Location = new Point(0, 0);
            rtbDescripcionCatalogo.Name = "rtbDescripcionCatalogo";
            rtbDescripcionCatalogo.ReadOnly = true;
            rtbDescripcionCatalogo.Size = new Size(231, 108);
            rtbDescripcionCatalogo.TabIndex = 1;
            rtbDescripcionCatalogo.Text = "";
            // 
            // lbDescripcionCatalogo
            // 
            lbDescripcionCatalogo.AutoSize = true;
            lbDescripcionCatalogo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescripcionCatalogo.ForeColor = SystemColors.ControlLightLight;
            lbDescripcionCatalogo.Location = new Point(3, 3);
            lbDescripcionCatalogo.Name = "lbDescripcionCatalogo";
            lbDescripcionCatalogo.Size = new Size(0, 17);
            lbDescripcionCatalogo.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 80, 107);
            panel4.Controls.Add(lbStockCatalogo);
            panel4.Controls.Add(lbPrecioCatalogo);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 267);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 38);
            panel4.TabIndex = 2;
            // 
            // lbStockCatalogo
            // 
            lbStockCatalogo.Anchor = AnchorStyles.Right;
            lbStockCatalogo.AutoSize = true;
            lbStockCatalogo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbStockCatalogo.ForeColor = SystemColors.ControlLightLight;
            lbStockCatalogo.Location = new Point(163, 10);
            lbStockCatalogo.Name = "lbStockCatalogo";
            lbStockCatalogo.Size = new Size(43, 17);
            lbStockCatalogo.TabIndex = 3;
            lbStockCatalogo.Text = "Stock";
            // 
            // lbPrecioCatalogo
            // 
            lbPrecioCatalogo.Anchor = AnchorStyles.None;
            lbPrecioCatalogo.AutoSize = true;
            lbPrecioCatalogo.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbPrecioCatalogo.ForeColor = SystemColors.ControlLightLight;
            lbPrecioCatalogo.Location = new Point(3, 10);
            lbPrecioCatalogo.Name = "lbPrecioCatalogo";
            lbPrecioCatalogo.Size = new Size(54, 16);
            lbPrecioCatalogo.TabIndex = 2;
            lbPrecioCatalogo.Text = "$Precio";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(12, 123, 148);
            panel3.Controls.Add(lbTituloCatalogo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 31);
            panel3.TabIndex = 1;
            // 
            // lbTituloCatalogo
            // 
            lbTituloCatalogo.Anchor = AnchorStyles.None;
            lbTituloCatalogo.AutoSize = true;
            lbTituloCatalogo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloCatalogo.ForeColor = SystemColors.ControlLightLight;
            lbTituloCatalogo.Location = new Point(3, 9);
            lbTituloCatalogo.Name = "lbTituloCatalogo";
            lbTituloCatalogo.Size = new Size(48, 19);
            lbTituloCatalogo.TabIndex = 1;
            lbTituloCatalogo.Text = "Titulo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 107, 135);
            panel2.Controls.Add(pbImagenCatalogo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 236);
            panel2.TabIndex = 0;
            // 
            // pbImagenCatalogo
            // 
            pbImagenCatalogo.Dock = DockStyle.Fill;
            pbImagenCatalogo.Location = new Point(0, 0);
            pbImagenCatalogo.Name = "pbImagenCatalogo";
            pbImagenCatalogo.Size = new Size(231, 236);
            pbImagenCatalogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenCatalogo.TabIndex = 0;
            pbImagenCatalogo.TabStop = false;
            // 
            // BotonesLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "BotonesLibros";
            Size = new Size(231, 456);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImagenCatalogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lbTituloCatalogo;
        private PictureBox pbImagenCatalogo;
        private Label lbPrecioCatalogo;
        private Panel panel6;
        private Button btAñadir;
        private Label lbDescripcionCatalogo;
        private Label lbStockCatalogo;
        private RichTextBox rtbDescripcionCatalogo;
    }
}