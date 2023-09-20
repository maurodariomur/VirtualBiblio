namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    partial class CDetalleCatalogo
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
            btnDCSalir = new FontAwesome.Sharp.IconButton();
            lbTitleDetalleCatalogo = new Label();
            btVaciarCarrito = new Button();
            btnConfirmarCompra = new Button();
            lbProductos = new Label();
            panel2 = new Panel();
            dataGridDetalleCat = new DataGridView();
            panelMensaje = new Panel();
            lbMensaje = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDetalleCat).BeginInit();
            panelMensaje.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(btnDCSalir);
            panel1.Controls.Add(lbTitleDetalleCatalogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 51);
            panel1.TabIndex = 2;
            // 
            // btnDCSalir
            // 
            btnDCSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDCSalir.BackColor = Color.Transparent;
            btnDCSalir.FlatAppearance.BorderSize = 0;
            btnDCSalir.FlatStyle = FlatStyle.Flat;
            btnDCSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            btnDCSalir.IconColor = Color.Crimson;
            btnDCSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDCSalir.IconSize = 18;
            btnDCSalir.ImageAlign = ContentAlignment.TopCenter;
            btnDCSalir.Location = new Point(672, 0);
            btnDCSalir.Name = "btnDCSalir";
            btnDCSalir.Size = new Size(30, 31);
            btnDCSalir.TabIndex = 3;
            btnDCSalir.UseVisualStyleBackColor = false;
            btnDCSalir.Click += btnDCSalir_Click;
            // 
            // lbTitleDetalleCatalogo
            // 
            lbTitleDetalleCatalogo.Anchor = AnchorStyles.Top;
            lbTitleDetalleCatalogo.AutoSize = true;
            lbTitleDetalleCatalogo.BackColor = Color.Transparent;
            lbTitleDetalleCatalogo.FlatStyle = FlatStyle.Flat;
            lbTitleDetalleCatalogo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitleDetalleCatalogo.ForeColor = Color.Gainsboro;
            lbTitleDetalleCatalogo.Location = new Point(305, 9);
            lbTitleDetalleCatalogo.Name = "lbTitleDetalleCatalogo";
            lbTitleDetalleCatalogo.Size = new Size(106, 31);
            lbTitleDetalleCatalogo.TabIndex = 1;
            lbTitleDetalleCatalogo.Text = "Detalle";
            // 
            // btVaciarCarrito
            // 
            btVaciarCarrito.Anchor = AnchorStyles.Right;
            btVaciarCarrito.BackColor = Color.FromArgb(244, 80, 80);
            btVaciarCarrito.Cursor = Cursors.Hand;
            btVaciarCarrito.FlatStyle = FlatStyle.Popup;
            btVaciarCarrito.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btVaciarCarrito.ForeColor = SystemColors.ButtonFace;
            btVaciarCarrito.Location = new Point(196, 0);
            btVaciarCarrito.Name = "btVaciarCarrito";
            btVaciarCarrito.Size = new Size(156, 35);
            btVaciarCarrito.TabIndex = 35;
            btVaciarCarrito.Text = "Vaciar Todo";
            btVaciarCarrito.UseVisualStyleBackColor = false;
            btVaciarCarrito.Click += btVaciarCarrito_Click;
            // 
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.Anchor = AnchorStyles.Right;
            btnConfirmarCompra.BackColor = Color.FromArgb(46, 79, 79);
            btnConfirmarCompra.Cursor = Cursors.Hand;
            btnConfirmarCompra.FlatStyle = FlatStyle.Popup;
            btnConfirmarCompra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarCompra.ForeColor = SystemColors.ButtonFace;
            btnConfirmarCompra.Location = new Point(375, 0);
            btnConfirmarCompra.Name = "btnConfirmarCompra";
            btnConfirmarCompra.Size = new Size(171, 35);
            btnConfirmarCompra.TabIndex = 36;
            btnConfirmarCompra.Text = "Confimar Venta";
            btnConfirmarCompra.UseVisualStyleBackColor = false;
            // 
            // lbProductos
            // 
            lbProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbProductos.AutoSize = true;
            lbProductos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductos.ForeColor = Color.FromArgb(46, 79, 79);
            lbProductos.Location = new Point(24, 27);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(170, 20);
            lbProductos.TabIndex = 37;
            lbProductos.Text = "Productos Añadidos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnConfirmarCompra);
            panel2.Controls.Add(btVaciarCarrito);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 513);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 48);
            panel2.TabIndex = 38;
            // 
            // dataGridDetalleCat
            // 
            dataGridDetalleCat.AllowUserToAddRows = false;
            dataGridDetalleCat.AllowUserToDeleteRows = false;
            dataGridDetalleCat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDetalleCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridDetalleCat.BackgroundColor = Color.FromArgb(221, 230, 237);
            dataGridDetalleCat.BorderStyle = BorderStyle.None;
            dataGridDetalleCat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridDetalleCat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(147, 177, 166);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDetalleCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDetalleCat.ColumnHeadersHeight = 30;
            dataGridDetalleCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridDetalleCat.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridDetalleCat.EnableHeadersVisualStyles = false;
            dataGridDetalleCat.GridColor = Color.FromArgb(165, 201, 202);
            dataGridDetalleCat.Location = new Point(24, 101);
            dataGridDetalleCat.MultiSelect = false;
            dataGridDetalleCat.Name = "dataGridDetalleCat";
            dataGridDetalleCat.ReadOnly = true;
            dataGridDetalleCat.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridDetalleCat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridDetalleCat.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridDetalleCat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridDetalleCat.RowTemplate.Height = 25;
            dataGridDetalleCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDetalleCat.Size = new Size(652, 340);
            dataGridDetalleCat.TabIndex = 39;
            dataGridDetalleCat.CellContentClick += dataGridDetalleCat_CellContentClick;
            // 
            // panelMensaje
            // 
            panelMensaje.BackColor = Color.FromArgb(221, 230, 237);
            panelMensaje.Controls.Add(lbProductos);
            panelMensaje.Dock = DockStyle.Top;
            panelMensaje.Location = new Point(0, 51);
            panelMensaje.Name = "panelMensaje";
            panelMensaje.Size = new Size(702, 47);
            panelMensaje.TabIndex = 41;
            // 
            // lbMensaje
            // 
            lbMensaje.Anchor = AnchorStyles.Top;
            lbMensaje.AutoSize = true;
            lbMensaje.BackColor = Color.Transparent;
            lbMensaje.FlatStyle = FlatStyle.Flat;
            lbMensaje.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbMensaje.ForeColor = Color.DimGray;
            lbMensaje.Location = new Point(268, 277);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(184, 31);
            lbMensaje.TabIndex = 2;
            lbMensaje.Text = "Carrito Vacio";
            lbMensaje.Visible = false;
            // 
            // CDetalleCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(702, 561);
            Controls.Add(panelMensaje);
            Controls.Add(lbMensaje);
            Controls.Add(dataGridDetalleCat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CDetalleCatalogo";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Catalogo";
            Load += CDetalleCatalogo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDetalleCat).EndInit();
            panelMensaje.ResumeLayout(false);
            panelMensaje.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbTitleDetalleCatalogo;
        private FontAwesome.Sharp.IconButton btnDCSalir;
        private Button btVaciarCarrito;
        private Button btnConfirmarCompra;
        private Label lbProductos;
        private Panel panel2;
        public DataGridView dataGridDetalleCat;
        private Panel panelMensaje;
        private Label lbMensaje;
    }
}