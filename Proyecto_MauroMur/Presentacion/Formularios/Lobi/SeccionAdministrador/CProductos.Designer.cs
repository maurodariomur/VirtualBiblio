namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    partial class CProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CProductos));
            panel1 = new Panel();
            lbTitleProductos = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btRegistrarProd = new Button();
            panel6 = new Panel();
            txAutor = new TextBox();
            lbAutor = new Label();
            txStock = new TextBox();
            lbStock = new Label();
            lbLimite = new Label();
            panel3 = new Panel();
            btTablaProductos = new FontAwesome.Sharp.IconButton();
            pProducts = new PictureBox();
            lbPathTittleP = new Label();
            iconImagen = new FontAwesome.Sharp.IconButton();
            rtbDescripcion = new RichTextBox();
            panel5 = new Panel();
            lbErrorProd = new Label();
            lbNombre = new Label();
            txEditorial = new TextBox();
            lbEditorial = new Label();
            txNameProducto = new TextBox();
            lbImagen = new Label();
            lbCategoria = new Label();
            txCategoria = new ComboBox();
            lbDescripcion = new Label();
            lbPrecio = new Label();
            txPrecio = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pProducts).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTitleProductos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 51);
            panel1.TabIndex = 39;
            // 
            // lbTitleProductos
            // 
            lbTitleProductos.Anchor = AnchorStyles.Top;
            lbTitleProductos.AutoSize = true;
            lbTitleProductos.BackColor = Color.Transparent;
            lbTitleProductos.FlatStyle = FlatStyle.Flat;
            lbTitleProductos.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitleProductos.ForeColor = Color.Gainsboro;
            lbTitleProductos.Location = new Point(426, 9);
            lbTitleProductos.Name = "lbTitleProductos";
            lbTitleProductos.Size = new Size(260, 33);
            lbTitleProductos.TabIndex = 0;
            lbTitleProductos.Text = "Agregar Productos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 79, 79);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(1076, 51);
            panel2.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(221, 230, 237);
            panel4.Controls.Add(btRegistrarProd);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 587);
            panel4.Name = "panel4";
            panel4.Size = new Size(1076, 50);
            panel4.TabIndex = 42;
            // 
            // btRegistrarProd
            // 
            btRegistrarProd.Anchor = AnchorStyles.Top;
            btRegistrarProd.BackColor = Color.FromArgb(24, 61, 61);
            btRegistrarProd.Cursor = Cursors.Hand;
            btRegistrarProd.FlatStyle = FlatStyle.Popup;
            btRegistrarProd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btRegistrarProd.ForeColor = SystemColors.ButtonFace;
            btRegistrarProd.Location = new Point(426, 0);
            btRegistrarProd.Name = "btRegistrarProd";
            btRegistrarProd.Size = new Size(270, 43);
            btRegistrarProd.TabIndex = 32;
            btRegistrarProd.Text = "Guardar";
            btRegistrarProd.UseVisualStyleBackColor = false;
            btRegistrarProd.Click += btRegistrarProd_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(221, 230, 237);
            panel6.Controls.Add(txAutor);
            panel6.Controls.Add(lbAutor);
            panel6.Controls.Add(txStock);
            panel6.Controls.Add(lbStock);
            panel6.Controls.Add(lbLimite);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(pProducts);
            panel6.Controls.Add(lbPathTittleP);
            panel6.Controls.Add(iconImagen);
            panel6.Controls.Add(rtbDescripcion);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(lbNombre);
            panel6.Controls.Add(txEditorial);
            panel6.Controls.Add(lbEditorial);
            panel6.Controls.Add(txNameProducto);
            panel6.Controls.Add(lbImagen);
            panel6.Controls.Add(lbCategoria);
            panel6.Controls.Add(txCategoria);
            panel6.Controls.Add(lbDescripcion);
            panel6.Controls.Add(lbPrecio);
            panel6.Controls.Add(txPrecio);
            panel6.Dock = DockStyle.Top;
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(0, 51);
            panel6.Name = "panel6";
            panel6.Size = new Size(1076, 536);
            panel6.TabIndex = 44;
            panel6.Paint += panel6_Paint;
            // 
            // txAutor
            // 
            txAutor.Anchor = AnchorStyles.None;
            txAutor.BorderStyle = BorderStyle.FixedSingle;
            txAutor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txAutor.ForeColor = SystemColors.WindowFrame;
            txAutor.Location = new Point(331, 248);
            txAutor.Name = "txAutor";
            txAutor.Size = new Size(213, 27);
            txAutor.TabIndex = 55;
            txAutor.Text = "Autor";
            txAutor.TextChanged += txAutor_TextChanged;
            txAutor.Enter += txAutor_Enter;
            txAutor.Leave += txAutor_Leave;
            // 
            // lbAutor
            // 
            lbAutor.Anchor = AnchorStyles.None;
            lbAutor.AutoSize = true;
            lbAutor.BackColor = Color.Transparent;
            lbAutor.FlatStyle = FlatStyle.Popup;
            lbAutor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAutor.Location = new Point(331, 210);
            lbAutor.Name = "lbAutor";
            lbAutor.Size = new Size(50, 19);
            lbAutor.TabIndex = 54;
            lbAutor.Text = "Autor";
            // 
            // txStock
            // 
            txStock.Anchor = AnchorStyles.None;
            txStock.BorderStyle = BorderStyle.FixedSingle;
            txStock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txStock.ForeColor = SystemColors.WindowFrame;
            txStock.Location = new Point(604, 248);
            txStock.Name = "txStock";
            txStock.Size = new Size(213, 27);
            txStock.TabIndex = 53;
            txStock.Text = "Stock";
            txStock.Enter += txStock_Enter;
            txStock.KeyPress += txStock_KeyPress;
            txStock.Leave += txStock_Leave;
            // 
            // lbStock
            // 
            lbStock.Anchor = AnchorStyles.None;
            lbStock.AutoSize = true;
            lbStock.BackColor = Color.Transparent;
            lbStock.FlatStyle = FlatStyle.Popup;
            lbStock.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbStock.Location = new Point(604, 210);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(50, 19);
            lbStock.TabIndex = 52;
            lbStock.Text = "Stock";
            // 
            // lbLimite
            // 
            lbLimite.Anchor = AnchorStyles.None;
            lbLimite.AutoSize = true;
            lbLimite.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbLimite.ForeColor = Color.RosyBrown;
            lbLimite.Location = new Point(333, 457);
            lbLimite.Name = "lbLimite";
            lbLimite.Size = new Size(44, 16);
            lbLimite.TabIndex = 51;
            lbLimite.Text = "label1";
            lbLimite.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btTablaProductos);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1076, 30);
            panel3.TabIndex = 50;
            // 
            // btTablaProductos
            // 
            btTablaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btTablaProductos.BackColor = Color.FromArgb(24, 61, 61);
            btTablaProductos.FlatAppearance.BorderSize = 0;
            btTablaProductos.FlatStyle = FlatStyle.Flat;
            btTablaProductos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btTablaProductos.ForeColor = SystemColors.ButtonFace;
            btTablaProductos.IconChar = FontAwesome.Sharp.IconChar.Book;
            btTablaProductos.IconColor = Color.Gainsboro;
            btTablaProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btTablaProductos.IconSize = 27;
            btTablaProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btTablaProductos.Location = new Point(948, 0);
            btTablaProductos.Name = "btTablaProductos";
            btTablaProductos.Size = new Size(128, 30);
            btTablaProductos.TabIndex = 51;
            btTablaProductos.Text = "Productos ";
            btTablaProductos.TextAlign = ContentAlignment.MiddleRight;
            btTablaProductos.UseVisualStyleBackColor = false;
            btTablaProductos.Click += btTablaProductos_Click;
            // 
            // pProducts
            // 
            pProducts.Anchor = AnchorStyles.None;
            pProducts.Location = new Point(654, 325);
            pProducts.Name = "pProducts";
            pProducts.Size = new Size(120, 122);
            pProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            pProducts.TabIndex = 48;
            pProducts.TabStop = false;
            // 
            // lbPathTittleP
            // 
            lbPathTittleP.Anchor = AnchorStyles.None;
            lbPathTittleP.AutoSize = true;
            lbPathTittleP.BackColor = Color.Transparent;
            lbPathTittleP.FlatStyle = FlatStyle.Popup;
            lbPathTittleP.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPathTittleP.Location = new Point(654, 457);
            lbPathTittleP.Name = "lbPathTittleP";
            lbPathTittleP.Size = new Size(78, 19);
            lbPathTittleP.TabIndex = 46;
            lbPathTittleP.Text = "Producto";
            // 
            // iconImagen
            // 
            iconImagen.Anchor = AnchorStyles.None;
            iconImagen.BackColor = Color.Transparent;
            iconImagen.Cursor = Cursors.Hand;
            iconImagen.FlatAppearance.BorderSize = 0;
            iconImagen.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 131, 116);
            iconImagen.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 177, 166);
            iconImagen.FlatStyle = FlatStyle.Flat;
            iconImagen.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            iconImagen.IconColor = Color.Black;
            iconImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconImagen.IconSize = 25;
            iconImagen.ImageAlign = ContentAlignment.BottomCenter;
            iconImagen.Location = new Point(617, 444);
            iconImagen.Name = "iconImagen";
            iconImagen.Size = new Size(31, 37);
            iconImagen.TabIndex = 49;
            iconImagen.UseVisualStyleBackColor = false;
            iconImagen.Click += iconImagen_Click;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Anchor = AnchorStyles.None;
            rtbDescripcion.BackColor = SystemColors.Window;
            rtbDescripcion.BorderStyle = BorderStyle.FixedSingle;
            rtbDescripcion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDescripcion.Location = new Point(332, 325);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(213, 116);
            rtbDescripcion.TabIndex = 47;
            rtbDescripcion.Text = "";
            rtbDescripcion.TextChanged += rtbDescripcion_TextChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbErrorProd);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 487);
            panel5.Name = "panel5";
            panel5.Size = new Size(1076, 49);
            panel5.TabIndex = 43;
            // 
            // lbErrorProd
            // 
            lbErrorProd.Anchor = AnchorStyles.Top;
            lbErrorProd.AutoSize = true;
            lbErrorProd.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorProd.ForeColor = Color.Brown;
            lbErrorProd.Image = (Image)resources.GetObject("lbErrorProd.Image");
            lbErrorProd.ImageAlign = ContentAlignment.MiddleLeft;
            lbErrorProd.Location = new Point(408, 9);
            lbErrorProd.Name = "lbErrorProd";
            lbErrorProd.Size = new Size(40, 25);
            lbErrorProd.TabIndex = 34;
            lbErrorProd.Text = "Error";
            lbErrorProd.TextAlign = ContentAlignment.MiddleCenter;
            lbErrorProd.UseCompatibleTextRendering = true;
            lbErrorProd.Visible = false;
            // 
            // lbNombre
            // 
            lbNombre.Anchor = AnchorStyles.None;
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.Transparent;
            lbNombre.FlatStyle = FlatStyle.Popup;
            lbNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.Location = new Point(332, 50);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(48, 19);
            lbNombre.TabIndex = 17;
            lbNombre.Text = "Titulo";
            // 
            // txEditorial
            // 
            txEditorial.Anchor = AnchorStyles.None;
            txEditorial.AutoCompleteMode = AutoCompleteMode.Suggest;
            txEditorial.BackColor = SystemColors.Window;
            txEditorial.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txEditorial.ForeColor = SystemColors.WindowFrame;
            txEditorial.Location = new Point(331, 164);
            txEditorial.Name = "txEditorial";
            txEditorial.Size = new Size(213, 27);
            txEditorial.TabIndex = 31;
            txEditorial.Text = "Editorial";
            txEditorial.TextChanged += txEditorial_TextChanged;
            txEditorial.Enter += txEditorial_Enter;
            txEditorial.Leave += txEditorial_Leave;
            // 
            // lbEditorial
            // 
            lbEditorial.Anchor = AnchorStyles.None;
            lbEditorial.AutoSize = true;
            lbEditorial.BackColor = Color.Transparent;
            lbEditorial.FlatStyle = FlatStyle.Flat;
            lbEditorial.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditorial.Location = new Point(331, 131);
            lbEditorial.Name = "lbEditorial";
            lbEditorial.Size = new Size(70, 19);
            lbEditorial.TabIndex = 33;
            lbEditorial.Text = "Editorial";
            // 
            // txNameProducto
            // 
            txNameProducto.Anchor = AnchorStyles.None;
            txNameProducto.Cursor = Cursors.IBeam;
            txNameProducto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txNameProducto.ForeColor = SystemColors.WindowFrame;
            txNameProducto.Location = new Point(331, 83);
            txNameProducto.Name = "txNameProducto";
            txNameProducto.Size = new Size(213, 27);
            txNameProducto.TabIndex = 24;
            txNameProducto.Text = "Titulo";
            txNameProducto.Enter += txNameProducto_Enter;
            txNameProducto.Leave += txNameProducto_Leave;
            // 
            // lbImagen
            // 
            lbImagen.Anchor = AnchorStyles.None;
            lbImagen.AutoSize = true;
            lbImagen.BackColor = Color.Transparent;
            lbImagen.FlatStyle = FlatStyle.Popup;
            lbImagen.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbImagen.Location = new Point(678, 293);
            lbImagen.Name = "lbImagen";
            lbImagen.Size = new Size(71, 19);
            lbImagen.TabIndex = 18;
            lbImagen.Text = "Imagen";
            // 
            // lbCategoria
            // 
            lbCategoria.Anchor = AnchorStyles.None;
            lbCategoria.AutoSize = true;
            lbCategoria.BackColor = Color.Transparent;
            lbCategoria.FlatStyle = FlatStyle.Flat;
            lbCategoria.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategoria.Location = new Point(604, 50);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(87, 19);
            lbCategoria.TabIndex = 21;
            lbCategoria.Text = "Categoria";
            // 
            // txCategoria
            // 
            txCategoria.Anchor = AnchorStyles.None;
            txCategoria.BackColor = SystemColors.Window;
            txCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            txCategoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txCategoria.ForeColor = SystemColors.WindowFrame;
            txCategoria.FormattingEnabled = true;
            txCategoria.Location = new Point(604, 83);
            txCategoria.Name = "txCategoria";
            txCategoria.Size = new Size(213, 29);
            txCategoria.TabIndex = 30;
            // 
            // lbDescripcion
            // 
            lbDescripcion.Anchor = AnchorStyles.None;
            lbDescripcion.AutoSize = true;
            lbDescripcion.BackColor = Color.Transparent;
            lbDescripcion.FlatStyle = FlatStyle.Popup;
            lbDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDescripcion.Location = new Point(333, 293);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(100, 19);
            lbDescripcion.TabIndex = 22;
            lbDescripcion.Text = "Descripcion";
            // 
            // lbPrecio
            // 
            lbPrecio.Anchor = AnchorStyles.None;
            lbPrecio.AutoSize = true;
            lbPrecio.BackColor = Color.Transparent;
            lbPrecio.FlatStyle = FlatStyle.Popup;
            lbPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrecio.Location = new Point(604, 137);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(57, 19);
            lbPrecio.TabIndex = 19;
            lbPrecio.Text = "Precio";
            // 
            // txPrecio
            // 
            txPrecio.Anchor = AnchorStyles.None;
            txPrecio.BorderStyle = BorderStyle.FixedSingle;
            txPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txPrecio.ForeColor = SystemColors.WindowFrame;
            txPrecio.Location = new Point(604, 165);
            txPrecio.Name = "txPrecio";
            txPrecio.Size = new Size(213, 27);
            txPrecio.TabIndex = 27;
            txPrecio.Text = "$ Precio";
            txPrecio.Enter += txPrecio_Enter;
            txPrecio.KeyPress += txPrecio_KeyPress;
            txPrecio.Leave += txPrecio_Leave;
            // 
            // CProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1076, 688);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CProductos";
            Text = "Productos";
            Load += CProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pProducts).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTitleProductos;
        private Panel panel2;
        private Panel panel4;
        private Button btRegistrarProd;
        private Panel panel6;
        private TextBox txPassword;
        private Label lbNombre;
        private TextBox txEditorial;
        private Label lbEditorial;
        private TextBox txNameProducto;
        private Label lbImagen;
        private Label lbCategoria;
        private ComboBox txCategoria;
        private Label lbDescripcion;
        private Label lbPrecio;
        private TextBox txPrecio;
        private Panel panel5;
        private Label lbErrorProd;
        private Label lbPathTittleP;
        private PictureBox pProducts;
        private RichTextBox rtbDescripcion;
        private FontAwesome.Sharp.IconButton iconImagen;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btTablaProductos;
        private Label lbLimite;
        private Label lbStock;
        private TextBox txStock;
        private TextBox txAutor;
        private Label lbAutor;
    }
}