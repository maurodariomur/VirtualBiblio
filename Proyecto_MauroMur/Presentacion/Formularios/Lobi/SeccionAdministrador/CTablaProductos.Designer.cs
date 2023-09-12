namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    partial class CTablaProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lbEditarProducto = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            pEditarProducts = new PictureBox();
            panel7 = new Panel();
            iconLimpiar = new FontAwesome.Sharp.IconButton();
            btEditar = new Button();
            txEditarStock = new TextBox();
            label2 = new Label();
            txEditarPrecio = new TextBox();
            lbEditarPrecio = new Label();
            checkBoxNoEd = new CheckBox();
            checkBoxSiEd = new CheckBox();
            lbEditarBaja = new Label();
            iconEditarImagen = new FontAwesome.Sharp.IconButton();
            lbEditarImagen = new Label();
            lbLimite = new Label();
            rtbEditarDescripcion = new RichTextBox();
            lbEditarDescripcion = new Label();
            lbEditarCategoria = new Label();
            txEditarCategoria = new ComboBox();
            txEditarAutor = new TextBox();
            lbEditarAutor = new Label();
            lbEditarTitulo = new Label();
            txEditarEditorial = new TextBox();
            lbEditarEditorial = new Label();
            txEditarProducto = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            checkBoxAZT = new CheckBox();
            panel3 = new Panel();
            dataGridProductos = new DataGridView();
            panel4 = new Panel();
            cBBuscadorEditorial = new ComboBox();
            buscadorEditorial = new Label();
            cBBuscadorAutor = new ComboBox();
            cBBuscadorCategoria = new ComboBox();
            txBuscadorTitulo = new TextBox();
            buscadorTitulo = new Label();
            buscadorAutor = new Label();
            buscadorCategoria = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pEditarProducts).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 70, 70);
            panel1.Controls.Add(lbEditarProducto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 51);
            panel1.TabIndex = 0;
            // 
            // lbEditarProducto
            // 
            lbEditarProducto.Anchor = AnchorStyles.Top;
            lbEditarProducto.AutoSize = true;
            lbEditarProducto.BackColor = Color.Transparent;
            lbEditarProducto.FlatStyle = FlatStyle.Flat;
            lbEditarProducto.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbEditarProducto.ForeColor = Color.Gainsboro;
            lbEditarProducto.Location = new Point(396, 9);
            lbEditarProducto.Name = "lbEditarProducto";
            lbEditarProducto.Size = new Size(227, 31);
            lbEditarProducto.TabIndex = 1;
            lbEditarProducto.Text = "Tabla Productos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 61, 61);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(772, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 663);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.AutoScroll = true;
            panel6.Controls.Add(pEditarProducts);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(txEditarStock);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txEditarPrecio);
            panel6.Controls.Add(lbEditarPrecio);
            panel6.Controls.Add(checkBoxNoEd);
            panel6.Controls.Add(checkBoxSiEd);
            panel6.Controls.Add(lbEditarBaja);
            panel6.Controls.Add(iconEditarImagen);
            panel6.Controls.Add(lbEditarImagen);
            panel6.Controls.Add(lbLimite);
            panel6.Controls.Add(rtbEditarDescripcion);
            panel6.Controls.Add(lbEditarDescripcion);
            panel6.Controls.Add(lbEditarCategoria);
            panel6.Controls.Add(txEditarCategoria);
            panel6.Controls.Add(txEditarAutor);
            panel6.Controls.Add(lbEditarAutor);
            panel6.Controls.Add(lbEditarTitulo);
            panel6.Controls.Add(txEditarEditorial);
            panel6.Controls.Add(lbEditarEditorial);
            panel6.Controls.Add(txEditarProducto);
            panel6.Location = new Point(0, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 615);
            panel6.TabIndex = 4;
            // 
            // pEditarProducts
            // 
            pEditarProducts.Location = new Point(143, 429);
            pEditarProducts.Name = "pEditarProducts";
            pEditarProducts.Size = new Size(100, 128);
            pEditarProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            pEditarProducts.TabIndex = 79;
            pEditarProducts.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(iconLimpiar);
            panel7.Controls.Add(btEditar);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 569);
            panel7.Name = "panel7";
            panel7.Size = new Size(350, 46);
            panel7.TabIndex = 78;
            // 
            // iconLimpiar
            // 
            iconLimpiar.Anchor = AnchorStyles.None;
            iconLimpiar.BackColor = Color.Transparent;
            iconLimpiar.Cursor = Cursors.Hand;
            iconLimpiar.FlatAppearance.BorderSize = 0;
            iconLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 131, 116);
            iconLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 177, 166);
            iconLimpiar.FlatStyle = FlatStyle.Flat;
            iconLimpiar.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            iconLimpiar.IconColor = Color.FromArgb(175, 211, 226);
            iconLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLimpiar.IconSize = 20;
            iconLimpiar.ImageAlign = ContentAlignment.BottomCenter;
            iconLimpiar.Location = new Point(280, 3);
            iconLimpiar.Name = "iconLimpiar";
            iconLimpiar.Size = new Size(31, 35);
            iconLimpiar.TabIndex = 71;
            iconLimpiar.UseVisualStyleBackColor = false;
            iconLimpiar.Click += iconLimpiar_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.FromArgb(57, 91, 100);
            btEditar.FlatStyle = FlatStyle.Popup;
            btEditar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btEditar.ForeColor = SystemColors.ButtonFace;
            btEditar.Location = new Point(119, 3);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(155, 35);
            btEditar.TabIndex = 33;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // txEditarStock
            // 
            txEditarStock.Anchor = AnchorStyles.None;
            txEditarStock.BorderStyle = BorderStyle.FixedSingle;
            txEditarStock.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEditarStock.ForeColor = SystemColors.WindowFrame;
            txEditarStock.Location = new Point(281, 230);
            txEditarStock.Name = "txEditarStock";
            txEditarStock.PlaceholderText = "0";
            txEditarStock.Size = new Size(57, 22);
            txEditarStock.TabIndex = 77;
            txEditarStock.TextAlign = HorizontalAlignment.Center;
            txEditarStock.KeyPress += txEditarStock_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(210, 228);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 76;
            label2.Text = "Stock";
            // 
            // txEditarPrecio
            // 
            txEditarPrecio.Anchor = AnchorStyles.None;
            txEditarPrecio.BorderStyle = BorderStyle.FixedSingle;
            txEditarPrecio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEditarPrecio.ForeColor = SystemColors.WindowFrame;
            txEditarPrecio.Location = new Point(125, 228);
            txEditarPrecio.Name = "txEditarPrecio";
            txEditarPrecio.PlaceholderText = "$$$";
            txEditarPrecio.Size = new Size(57, 22);
            txEditarPrecio.TabIndex = 75;
            txEditarPrecio.TextAlign = HorizontalAlignment.Center;
            txEditarPrecio.KeyPress += txEditarPrecio_KeyPress;
            // 
            // lbEditarPrecio
            // 
            lbEditarPrecio.Anchor = AnchorStyles.None;
            lbEditarPrecio.AutoSize = true;
            lbEditarPrecio.BackColor = Color.Transparent;
            lbEditarPrecio.FlatStyle = FlatStyle.Popup;
            lbEditarPrecio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarPrecio.ForeColor = Color.Gainsboro;
            lbEditarPrecio.Location = new Point(16, 230);
            lbEditarPrecio.Name = "lbEditarPrecio";
            lbEditarPrecio.Size = new Size(52, 16);
            lbEditarPrecio.TabIndex = 74;
            lbEditarPrecio.Text = "Precio";
            // 
            // checkBoxNoEd
            // 
            checkBoxNoEd.Anchor = AnchorStyles.None;
            checkBoxNoEd.AutoSize = true;
            checkBoxNoEd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNoEd.ForeColor = Color.Gainsboro;
            checkBoxNoEd.Location = new Point(18, 474);
            checkBoxNoEd.Name = "checkBoxNoEd";
            checkBoxNoEd.Size = new Size(44, 20);
            checkBoxNoEd.TabIndex = 73;
            checkBoxNoEd.Text = "No";
            checkBoxNoEd.UseVisualStyleBackColor = true;
            checkBoxNoEd.CheckedChanged += checkBoxNoEd_CheckedChanged;
            // 
            // checkBoxSiEd
            // 
            checkBoxSiEd.Anchor = AnchorStyles.None;
            checkBoxSiEd.AutoSize = true;
            checkBoxSiEd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSiEd.ForeColor = Color.Gainsboro;
            checkBoxSiEd.Location = new Point(18, 435);
            checkBoxSiEd.Name = "checkBoxSiEd";
            checkBoxSiEd.Size = new Size(38, 20);
            checkBoxSiEd.TabIndex = 72;
            checkBoxSiEd.Text = "Si";
            checkBoxSiEd.UseVisualStyleBackColor = true;
            checkBoxSiEd.CheckedChanged += checkBoxSiEd_CheckedChanged;
            // 
            // lbEditarBaja
            // 
            lbEditarBaja.Anchor = AnchorStyles.None;
            lbEditarBaja.AutoSize = true;
            lbEditarBaja.BackColor = Color.Transparent;
            lbEditarBaja.FlatStyle = FlatStyle.Popup;
            lbEditarBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarBaja.ForeColor = Color.Gainsboro;
            lbEditarBaja.Location = new Point(16, 394);
            lbEditarBaja.Name = "lbEditarBaja";
            lbEditarBaja.Size = new Size(39, 16);
            lbEditarBaja.TabIndex = 71;
            lbEditarBaja.Text = "Baja";
            // 
            // iconEditarImagen
            // 
            iconEditarImagen.Anchor = AnchorStyles.None;
            iconEditarImagen.BackColor = Color.Transparent;
            iconEditarImagen.Cursor = Cursors.Hand;
            iconEditarImagen.FlatAppearance.BorderSize = 0;
            iconEditarImagen.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 131, 116);
            iconEditarImagen.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 177, 166);
            iconEditarImagen.FlatStyle = FlatStyle.Flat;
            iconEditarImagen.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            iconEditarImagen.IconColor = Color.Gainsboro;
            iconEditarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditarImagen.IconSize = 20;
            iconEditarImagen.ImageAlign = ContentAlignment.BottomCenter;
            iconEditarImagen.Location = new Point(249, 533);
            iconEditarImagen.Name = "iconEditarImagen";
            iconEditarImagen.Size = new Size(25, 30);
            iconEditarImagen.TabIndex = 70;
            iconEditarImagen.UseVisualStyleBackColor = false;
            iconEditarImagen.Click += iconEditarImagen_Click;
            // 
            // lbEditarImagen
            // 
            lbEditarImagen.Anchor = AnchorStyles.None;
            lbEditarImagen.AutoSize = true;
            lbEditarImagen.BackColor = Color.Transparent;
            lbEditarImagen.FlatStyle = FlatStyle.Popup;
            lbEditarImagen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarImagen.ForeColor = Color.Gainsboro;
            lbEditarImagen.Location = new Point(152, 394);
            lbEditarImagen.Name = "lbEditarImagen";
            lbEditarImagen.Size = new Size(58, 16);
            lbEditarImagen.TabIndex = 67;
            lbEditarImagen.Text = "Imagen";
            // 
            // lbLimite
            // 
            lbLimite.Anchor = AnchorStyles.None;
            lbLimite.AutoSize = true;
            lbLimite.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbLimite.ForeColor = Color.RosyBrown;
            lbLimite.Location = new Point(125, 378);
            lbLimite.Name = "lbLimite";
            lbLimite.Size = new Size(41, 13);
            lbLimite.TabIndex = 66;
            lbLimite.Text = "label1";
            lbLimite.Visible = false;
            // 
            // rtbEditarDescripcion
            // 
            rtbEditarDescripcion.Anchor = AnchorStyles.None;
            rtbEditarDescripcion.BackColor = SystemColors.Window;
            rtbEditarDescripcion.BorderStyle = BorderStyle.FixedSingle;
            rtbEditarDescripcion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtbEditarDescripcion.Location = new Point(119, 280);
            rtbEditarDescripcion.Name = "rtbEditarDescripcion";
            rtbEditarDescripcion.Size = new Size(213, 95);
            rtbEditarDescripcion.TabIndex = 65;
            rtbEditarDescripcion.Text = "";
            // 
            // lbEditarDescripcion
            // 
            lbEditarDescripcion.Anchor = AnchorStyles.None;
            lbEditarDescripcion.AutoSize = true;
            lbEditarDescripcion.BackColor = Color.Transparent;
            lbEditarDescripcion.FlatStyle = FlatStyle.Popup;
            lbEditarDescripcion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarDescripcion.ForeColor = Color.Gainsboro;
            lbEditarDescripcion.Location = new Point(16, 280);
            lbEditarDescripcion.Name = "lbEditarDescripcion";
            lbEditarDescripcion.Size = new Size(90, 16);
            lbEditarDescripcion.TabIndex = 64;
            lbEditarDescripcion.Text = "Descripcion";
            // 
            // lbEditarCategoria
            // 
            lbEditarCategoria.Anchor = AnchorStyles.None;
            lbEditarCategoria.AutoSize = true;
            lbEditarCategoria.BackColor = Color.Transparent;
            lbEditarCategoria.FlatStyle = FlatStyle.Flat;
            lbEditarCategoria.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarCategoria.ForeColor = Color.Gainsboro;
            lbEditarCategoria.Location = new Point(16, 182);
            lbEditarCategoria.Name = "lbEditarCategoria";
            lbEditarCategoria.Size = new Size(75, 16);
            lbEditarCategoria.TabIndex = 62;
            lbEditarCategoria.Text = "Categoria";
            // 
            // txEditarCategoria
            // 
            txEditarCategoria.Anchor = AnchorStyles.None;
            txEditarCategoria.BackColor = SystemColors.Window;
            txEditarCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            txEditarCategoria.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEditarCategoria.ForeColor = SystemColors.WindowFrame;
            txEditarCategoria.FormattingEnabled = true;
            txEditarCategoria.Location = new Point(125, 174);
            txEditarCategoria.Name = "txEditarCategoria";
            txEditarCategoria.Size = new Size(213, 24);
            txEditarCategoria.TabIndex = 63;
            // 
            // txEditarAutor
            // 
            txEditarAutor.Anchor = AnchorStyles.None;
            txEditarAutor.BorderStyle = BorderStyle.FixedSingle;
            txEditarAutor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEditarAutor.ForeColor = SystemColors.WindowFrame;
            txEditarAutor.Location = new Point(125, 126);
            txEditarAutor.Name = "txEditarAutor";
            txEditarAutor.PlaceholderText = "Autor";
            txEditarAutor.Size = new Size(213, 22);
            txEditarAutor.TabIndex = 61;
            txEditarAutor.TextChanged += txEditarAutor_TextChanged;
            // 
            // lbEditarAutor
            // 
            lbEditarAutor.Anchor = AnchorStyles.None;
            lbEditarAutor.AutoSize = true;
            lbEditarAutor.BackColor = Color.Transparent;
            lbEditarAutor.FlatStyle = FlatStyle.Popup;
            lbEditarAutor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarAutor.ForeColor = Color.Gainsboro;
            lbEditarAutor.Location = new Point(16, 126);
            lbEditarAutor.Name = "lbEditarAutor";
            lbEditarAutor.Size = new Size(43, 16);
            lbEditarAutor.TabIndex = 60;
            lbEditarAutor.Text = "Autor";
            // 
            // lbEditarTitulo
            // 
            lbEditarTitulo.Anchor = AnchorStyles.None;
            lbEditarTitulo.AutoSize = true;
            lbEditarTitulo.BackColor = Color.Transparent;
            lbEditarTitulo.FlatStyle = FlatStyle.Popup;
            lbEditarTitulo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarTitulo.ForeColor = Color.Gainsboro;
            lbEditarTitulo.Location = new Point(16, 31);
            lbEditarTitulo.Name = "lbEditarTitulo";
            lbEditarTitulo.Size = new Size(46, 16);
            lbEditarTitulo.TabIndex = 56;
            lbEditarTitulo.Text = "Titulo";
            // 
            // txEditarEditorial
            // 
            txEditarEditorial.Anchor = AnchorStyles.None;
            txEditarEditorial.AutoCompleteMode = AutoCompleteMode.Suggest;
            txEditarEditorial.BackColor = SystemColors.Window;
            txEditarEditorial.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEditarEditorial.ForeColor = SystemColors.WindowFrame;
            txEditarEditorial.Location = new Point(125, 79);
            txEditarEditorial.Name = "txEditarEditorial";
            txEditarEditorial.PlaceholderText = "Editorial";
            txEditarEditorial.Size = new Size(213, 22);
            txEditarEditorial.TabIndex = 58;
            txEditarEditorial.TextChanged += txEditarEditorial_TextChanged;
            // 
            // lbEditarEditorial
            // 
            lbEditarEditorial.Anchor = AnchorStyles.None;
            lbEditarEditorial.AutoSize = true;
            lbEditarEditorial.BackColor = Color.Transparent;
            lbEditarEditorial.FlatStyle = FlatStyle.Flat;
            lbEditarEditorial.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEditarEditorial.ForeColor = Color.Gainsboro;
            lbEditarEditorial.Location = new Point(16, 79);
            lbEditarEditorial.Name = "lbEditarEditorial";
            lbEditarEditorial.Size = new Size(65, 16);
            lbEditarEditorial.TabIndex = 59;
            lbEditarEditorial.Text = "Editorial";
            // 
            // txEditarProducto
            // 
            txEditarProducto.Anchor = AnchorStyles.None;
            txEditarProducto.Cursor = Cursors.IBeam;
            txEditarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txEditarProducto.ForeColor = SystemColors.WindowFrame;
            txEditarProducto.Location = new Point(125, 31);
            txEditarProducto.Name = "txEditarProducto";
            txEditarProducto.PlaceholderText = "Titulo";
            txEditarProducto.Size = new Size(213, 22);
            txEditarProducto.TabIndex = 57;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 48);
            panel5.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(83, 11);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 2;
            label1.Text = "Modificar Producto";
            // 
            // checkBoxAZT
            // 
            checkBoxAZT.AutoSize = true;
            checkBoxAZT.BackColor = Color.Transparent;
            checkBoxAZT.FlatAppearance.BorderSize = 0;
            checkBoxAZT.FlatAppearance.CheckedBackColor = Color.Black;
            checkBoxAZT.FlatStyle = FlatStyle.Flat;
            checkBoxAZT.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxAZT.ForeColor = Color.Gainsboro;
            checkBoxAZT.Location = new Point(73, 58);
            checkBoxAZT.Name = "checkBoxAZT";
            checkBoxAZT.Size = new Size(109, 22);
            checkBoxAZT.TabIndex = 2;
            checkBoxAZT.Text = "A-Z.(Titulo)";
            checkBoxAZT.UseVisualStyleBackColor = false;
            checkBoxAZT.CheckedChanged += checkBoxAZT_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(57, 91, 100);
            panel3.Controls.Add(dataGridProductos);
            panel3.Controls.Add(checkBoxAZT);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 663);
            panel3.TabIndex = 2;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridProductos.BackgroundColor = Color.FromArgb(57, 91, 100);
            dataGridProductos.BorderStyle = BorderStyle.None;
            dataGridProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(147, 177, 166);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridProductos.EnableHeadersVisualStyles = false;
            dataGridProductos.GridColor = Color.FromArgb(165, 201, 202);
            dataGridProductos.Location = new Point(58, 108);
            dataGridProductos.MultiSelect = false;
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridProductos.RowHeadersVisible = false;
            dataGridProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridProductos.RowTemplate.Height = 25;
            dataGridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProductos.Size = new Size(693, 331);
            dataGridProductos.TabIndex = 1;
            dataGridProductos.CellContentClick += dataGridProductos_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(57, 91, 100);
            panel4.Controls.Add(cBBuscadorEditorial);
            panel4.Controls.Add(buscadorEditorial);
            panel4.Controls.Add(cBBuscadorAutor);
            panel4.Controls.Add(cBBuscadorCategoria);
            panel4.Controls.Add(txBuscadorTitulo);
            panel4.Controls.Add(buscadorTitulo);
            panel4.Controls.Add(buscadorAutor);
            panel4.Controls.Add(buscadorCategoria);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(772, 48);
            panel4.TabIndex = 16;
            // 
            // cBBuscadorEditorial
            // 
            cBBuscadorEditorial.Anchor = AnchorStyles.Top;
            cBBuscadorEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cBBuscadorEditorial.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBBuscadorEditorial.ForeColor = SystemColors.WindowFrame;
            cBBuscadorEditorial.FormattingEnabled = true;
            cBBuscadorEditorial.Location = new Point(430, 14);
            cBBuscadorEditorial.Name = "cBBuscadorEditorial";
            cBBuscadorEditorial.Size = new Size(116, 21);
            cBBuscadorEditorial.TabIndex = 18;
            cBBuscadorEditorial.SelectedIndexChanged += cBBuscadorEditorial_SelectedIndexChanged;
            // 
            // buscadorEditorial
            // 
            buscadorEditorial.Anchor = AnchorStyles.Top;
            buscadorEditorial.AutoSize = true;
            buscadorEditorial.BackColor = Color.Transparent;
            buscadorEditorial.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorEditorial.ForeColor = SystemColors.Window;
            buscadorEditorial.Location = new Point(363, 15);
            buscadorEditorial.Name = "buscadorEditorial";
            buscadorEditorial.Size = new Size(61, 15);
            buscadorEditorial.TabIndex = 17;
            buscadorEditorial.Text = "Editorial";
            // 
            // cBBuscadorAutor
            // 
            cBBuscadorAutor.Anchor = AnchorStyles.Top;
            cBBuscadorAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cBBuscadorAutor.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBBuscadorAutor.ForeColor = SystemColors.WindowFrame;
            cBBuscadorAutor.FormattingEnabled = true;
            cBBuscadorAutor.Location = new Point(235, 14);
            cBBuscadorAutor.Name = "cBBuscadorAutor";
            cBBuscadorAutor.Size = new Size(113, 21);
            cBBuscadorAutor.TabIndex = 16;
            cBBuscadorAutor.SelectedIndexChanged += cBBuscadorAutor_SelectedIndexChanged;
            // 
            // cBBuscadorCategoria
            // 
            cBBuscadorCategoria.Anchor = AnchorStyles.Top;
            cBBuscadorCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cBBuscadorCategoria.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBBuscadorCategoria.ForeColor = SystemColors.WindowFrame;
            cBBuscadorCategoria.FormattingEnabled = true;
            cBBuscadorCategoria.Location = new Point(627, 13);
            cBBuscadorCategoria.Name = "cBBuscadorCategoria";
            cBBuscadorCategoria.Size = new Size(115, 21);
            cBBuscadorCategoria.TabIndex = 15;
            cBBuscadorCategoria.SelectedIndexChanged += cBBuscadorCategoria_SelectedIndexChanged;
            // 
            // txBuscadorTitulo
            // 
            txBuscadorTitulo.Anchor = AnchorStyles.None;
            txBuscadorTitulo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorTitulo.ForeColor = SystemColors.WindowFrame;
            txBuscadorTitulo.Location = new Point(78, 14);
            txBuscadorTitulo.Name = "txBuscadorTitulo";
            txBuscadorTitulo.PlaceholderText = "Titulo";
            txBuscadorTitulo.Size = new Size(104, 20);
            txBuscadorTitulo.TabIndex = 8;
            txBuscadorTitulo.TextChanged += txBuscadorTitulo_TextChanged;
            // 
            // buscadorTitulo
            // 
            buscadorTitulo.Anchor = AnchorStyles.Top;
            buscadorTitulo.AutoSize = true;
            buscadorTitulo.BackColor = Color.Transparent;
            buscadorTitulo.FlatStyle = FlatStyle.Flat;
            buscadorTitulo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorTitulo.ForeColor = Color.White;
            buscadorTitulo.Location = new Point(30, 15);
            buscadorTitulo.Name = "buscadorTitulo";
            buscadorTitulo.Size = new Size(43, 15);
            buscadorTitulo.TabIndex = 9;
            buscadorTitulo.Text = "Titulo";
            // 
            // buscadorAutor
            // 
            buscadorAutor.Anchor = AnchorStyles.Top;
            buscadorAutor.AutoSize = true;
            buscadorAutor.BackColor = Color.Transparent;
            buscadorAutor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorAutor.ForeColor = SystemColors.Window;
            buscadorAutor.Location = new Point(189, 15);
            buscadorAutor.Name = "buscadorAutor";
            buscadorAutor.Size = new Size(40, 15);
            buscadorAutor.TabIndex = 10;
            buscadorAutor.Text = "Autor";
            // 
            // buscadorCategoria
            // 
            buscadorCategoria.Anchor = AnchorStyles.Top;
            buscadorCategoria.AutoSize = true;
            buscadorCategoria.BackColor = Color.Transparent;
            buscadorCategoria.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorCategoria.ForeColor = SystemColors.Window;
            buscadorCategoria.Location = new Point(552, 15);
            buscadorCategoria.Name = "buscadorCategoria";
            buscadorCategoria.Size = new Size(69, 15);
            buscadorCategoria.TabIndex = 14;
            buscadorCategoria.Text = "Categoria";
            // 
            // CTablaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 714);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CTablaProductos";
            Text = "Tabla Productos";
            Load += CTablaProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pEditarProducts).EndInit();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbEditarProducto;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridProductos;
        private CheckBox checkBoxAZT;
        private Panel panel4;
        private TextBox txBuscadorTitulo;
        private Label buscadorTitulo;
        private ComboBox cBBuscadorCategoria;
        private Label buscadorAutor;
        private Label buscadorCategoria;
        private ComboBox cBBuscadorAutor;
        private ComboBox cBBuscadorEditorial;
        private Label buscadorEditorial;
        private Panel panel6;
        private Panel panel5;
        private Label label1;
        private TextBox txEditarAutor;
        private Label lbEditarAutor;
        private Label lbEditarTitulo;
        private TextBox txEditarEditorial;
        private Label lbEditarEditorial;
        private TextBox txEditarProducto;
        private Label lbEditarCategoria;
        private ComboBox txEditarCategoria;
        private Label lbLimite;
        private RichTextBox rtbEditarDescripcion;
        private Label lbEditarDescripcion;
        private FontAwesome.Sharp.IconButton iconEditarImagen;
        private Label lbEditarImagen;
        private CheckBox checkBoxNoEd;
        private CheckBox checkBoxSiEd;
        private Label lbEditarBaja;
        private TextBox txEditarPrecio;
        private Label lbEditarPrecio;
        private TextBox txEditarStock;
        private Label label2;
        private Panel panel7;
        private Button btEditar;
        private PictureBox pEditarProducts;
        private FontAwesome.Sharp.IconButton iconLimpiar;
    }
}