namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    partial class CCatalogo
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lbTittleCatalogo = new Label();
            panel2 = new Panel();
            cBCatalogoEditorial = new ComboBox();
            catalogoEditorial = new Label();
            cBCatalogoAutor = new ComboBox();
            cBCatalogoCategoria = new ComboBox();
            txCatalogoTitulo = new TextBox();
            CatalogoTitulo = new Label();
            catalogoAutor = new Label();
            catalogoCategoria = new Label();
            panel3 = new Panel();
            lbContador = new Label();
            iconCatalogo = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(44, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(712, 322);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTittleCatalogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 39;
            // 
            // lbTittleCatalogo
            // 
            lbTittleCatalogo.Anchor = AnchorStyles.Top;
            lbTittleCatalogo.AutoSize = true;
            lbTittleCatalogo.BackColor = Color.Transparent;
            lbTittleCatalogo.FlatStyle = FlatStyle.Flat;
            lbTittleCatalogo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTittleCatalogo.ForeColor = Color.Gainsboro;
            lbTittleCatalogo.Location = new Point(301, 9);
            lbTittleCatalogo.Name = "lbTittleCatalogo";
            lbTittleCatalogo.Size = new Size(262, 31);
            lbTittleCatalogo.TabIndex = 0;
            lbTittleCatalogo.Text = "Libros Disponibles ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(147, 177, 166);
            panel2.Controls.Add(cBCatalogoEditorial);
            panel2.Controls.Add(catalogoEditorial);
            panel2.Controls.Add(cBCatalogoAutor);
            panel2.Controls.Add(cBCatalogoCategoria);
            panel2.Controls.Add(txCatalogoTitulo);
            panel2.Controls.Add(CatalogoTitulo);
            panel2.Controls.Add(catalogoAutor);
            panel2.Controls.Add(catalogoCategoria);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 34);
            panel2.TabIndex = 40;
            // 
            // cBCatalogoEditorial
            // 
            cBCatalogoEditorial.Anchor = AnchorStyles.Top;
            cBCatalogoEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCatalogoEditorial.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBCatalogoEditorial.ForeColor = SystemColors.WindowFrame;
            cBCatalogoEditorial.FormattingEnabled = true;
            cBCatalogoEditorial.Location = new Point(444, 7);
            cBCatalogoEditorial.Name = "cBCatalogoEditorial";
            cBCatalogoEditorial.Size = new Size(116, 21);
            cBCatalogoEditorial.TabIndex = 26;
            cBCatalogoEditorial.SelectedIndexChanged += cBCatalogoEditorial_SelectedIndexChanged;
            // 
            // catalogoEditorial
            // 
            catalogoEditorial.Anchor = AnchorStyles.Top;
            catalogoEditorial.AutoSize = true;
            catalogoEditorial.BackColor = Color.Transparent;
            catalogoEditorial.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            catalogoEditorial.ForeColor = SystemColors.Window;
            catalogoEditorial.Location = new Point(377, 8);
            catalogoEditorial.Name = "catalogoEditorial";
            catalogoEditorial.Size = new Size(61, 15);
            catalogoEditorial.TabIndex = 25;
            catalogoEditorial.Text = "Editorial";
            // 
            // cBCatalogoAutor
            // 
            cBCatalogoAutor.Anchor = AnchorStyles.Top;
            cBCatalogoAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCatalogoAutor.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBCatalogoAutor.ForeColor = SystemColors.WindowFrame;
            cBCatalogoAutor.FormattingEnabled = true;
            cBCatalogoAutor.Location = new Point(249, 7);
            cBCatalogoAutor.Name = "cBCatalogoAutor";
            cBCatalogoAutor.Size = new Size(113, 21);
            cBCatalogoAutor.TabIndex = 24;
            cBCatalogoAutor.SelectedIndexChanged += cBCatalogoAutor_SelectedIndexChanged;
            // 
            // cBCatalogoCategoria
            // 
            cBCatalogoCategoria.Anchor = AnchorStyles.Top;
            cBCatalogoCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCatalogoCategoria.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBCatalogoCategoria.ForeColor = SystemColors.WindowFrame;
            cBCatalogoCategoria.FormattingEnabled = true;
            cBCatalogoCategoria.Location = new Point(641, 6);
            cBCatalogoCategoria.Name = "cBCatalogoCategoria";
            cBCatalogoCategoria.Size = new Size(115, 21);
            cBCatalogoCategoria.TabIndex = 23;
            cBCatalogoCategoria.SelectedIndexChanged += cBCatalogoCategoria_SelectedIndexChanged;
            // 
            // txCatalogoTitulo
            // 
            txCatalogoTitulo.Anchor = AnchorStyles.None;
            txCatalogoTitulo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txCatalogoTitulo.ForeColor = SystemColors.WindowFrame;
            txCatalogoTitulo.Location = new Point(92, 7);
            txCatalogoTitulo.Name = "txCatalogoTitulo";
            txCatalogoTitulo.PlaceholderText = "Titulo";
            txCatalogoTitulo.Size = new Size(104, 20);
            txCatalogoTitulo.TabIndex = 19;
            txCatalogoTitulo.TextChanged += txCatalogoTitulo_TextChanged;
            // 
            // CatalogoTitulo
            // 
            CatalogoTitulo.Anchor = AnchorStyles.Top;
            CatalogoTitulo.AutoSize = true;
            CatalogoTitulo.BackColor = Color.Transparent;
            CatalogoTitulo.FlatStyle = FlatStyle.Flat;
            CatalogoTitulo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CatalogoTitulo.ForeColor = Color.White;
            CatalogoTitulo.Location = new Point(44, 8);
            CatalogoTitulo.Name = "CatalogoTitulo";
            CatalogoTitulo.Size = new Size(43, 15);
            CatalogoTitulo.TabIndex = 20;
            CatalogoTitulo.Text = "Titulo";
            // 
            // catalogoAutor
            // 
            catalogoAutor.Anchor = AnchorStyles.Top;
            catalogoAutor.AutoSize = true;
            catalogoAutor.BackColor = Color.Transparent;
            catalogoAutor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            catalogoAutor.ForeColor = SystemColors.Window;
            catalogoAutor.Location = new Point(203, 8);
            catalogoAutor.Name = "catalogoAutor";
            catalogoAutor.Size = new Size(40, 15);
            catalogoAutor.TabIndex = 21;
            catalogoAutor.Text = "Autor";
            // 
            // catalogoCategoria
            // 
            catalogoCategoria.Anchor = AnchorStyles.Top;
            catalogoCategoria.AutoSize = true;
            catalogoCategoria.BackColor = Color.Transparent;
            catalogoCategoria.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            catalogoCategoria.ForeColor = SystemColors.Window;
            catalogoCategoria.Location = new Point(566, 8);
            catalogoCategoria.Name = "catalogoCategoria";
            catalogoCategoria.Size = new Size(69, 15);
            catalogoCategoria.TabIndex = 22;
            catalogoCategoria.Text = "Categoria";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbContador);
            panel3.Controls.Add(iconCatalogo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 40);
            panel3.TabIndex = 41;
            // 
            // lbContador
            // 
            lbContador.AutoSize = true;
            lbContador.BackColor = Color.Transparent;
            lbContador.FlatStyle = FlatStyle.Flat;
            lbContador.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbContador.Location = new Point(41, 5);
            lbContador.Margin = new Padding(0);
            lbContador.Name = "lbContador";
            lbContador.Size = new Size(21, 24);
            lbContador.TabIndex = 75;
            lbContador.Text = "0";
            lbContador.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconCatalogo
            // 
            iconCatalogo.BackColor = Color.Transparent;
            iconCatalogo.Cursor = Cursors.Hand;
            iconCatalogo.Dock = DockStyle.Left;
            iconCatalogo.FlatAppearance.BorderSize = 0;
            iconCatalogo.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 131, 116);
            iconCatalogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 177, 166);
            iconCatalogo.FlatStyle = FlatStyle.Flat;
            iconCatalogo.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconCatalogo.IconColor = Color.FromArgb(46, 79, 79);
            iconCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCatalogo.IconSize = 30;
            iconCatalogo.ImageAlign = ContentAlignment.BottomCenter;
            iconCatalogo.Location = new Point(0, 0);
            iconCatalogo.Name = "iconCatalogo";
            iconCatalogo.Size = new Size(38, 40);
            iconCatalogo.TabIndex = 74;
            iconCatalogo.UseVisualStyleBackColor = false;
            iconCatalogo.Click += iconCatalogo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(41, 325);
            panel4.TabIndex = 42;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.FromArgb(221, 230, 237);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(41, 125);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(759, 325);
            flowLayoutPanel.TabIndex = 44;
            // 
            // CCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "CCatalogo";
            Text = "Catalogo";
            Load += CCatalogo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lbTittleCatalogo;
        private Panel panel2;
        private ComboBox cBCatalogoEditorial;
        private Label catalogoEditorial;
        private ComboBox cBCatalogoAutor;
        private ComboBox cBCatalogoCategoria;
        private TextBox txCatalogoTitulo;
        private Label CatalogoTitulo;
        private Label catalogoAutor;
        private Label catalogoCategoria;
        private Panel panel3;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel;
        private FontAwesome.Sharp.IconButton iconCatalogo;
        private Label lbContador;
    }
}