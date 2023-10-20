namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    partial class CMisVentas
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lbTittleMisVentas = new Label();
            dataGridMisVentas = new DataGridView();
            panel2 = new Panel();
            buscadorNombre = new Label();
            buscadorApellido = new Label();
            txBuscadorNombre = new TextBox();
            txBuscadorApellido = new TextBox();
            buscadorDni = new Label();
            txBuscadorDni = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerHasta = new DateTimePicker();
            dateTimePickerDesde = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMisVentas).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTittleMisVentas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 40;
            // 
            // lbTittleMisVentas
            // 
            lbTittleMisVentas.Anchor = AnchorStyles.Top;
            lbTittleMisVentas.AutoSize = true;
            lbTittleMisVentas.BackColor = Color.Transparent;
            lbTittleMisVentas.FlatStyle = FlatStyle.Flat;
            lbTittleMisVentas.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTittleMisVentas.ForeColor = Color.Gainsboro;
            lbTittleMisVentas.Location = new Point(321, 9);
            lbTittleMisVentas.Name = "lbTittleMisVentas";
            lbTittleMisVentas.Size = new Size(158, 31);
            lbTittleMisVentas.TabIndex = 0;
            lbTittleMisVentas.Text = "Mis Ventas";
            // 
            // dataGridMisVentas
            // 
            dataGridMisVentas.AllowUserToAddRows = false;
            dataGridMisVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMisVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridMisVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridMisVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridMisVentas.BackgroundColor = Color.FromArgb(221, 230, 237);
            dataGridMisVentas.BorderStyle = BorderStyle.None;
            dataGridMisVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridMisVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(147, 177, 166);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridMisVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridMisVentas.ColumnHeadersHeight = 30;
            dataGridMisVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridMisVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridMisVentas.EnableHeadersVisualStyles = false;
            dataGridMisVentas.GridColor = Color.FromArgb(165, 201, 202);
            dataGridMisVentas.Location = new Point(344, 143);
            dataGridMisVentas.MultiSelect = false;
            dataGridMisVentas.Name = "dataGridMisVentas";
            dataGridMisVentas.ReadOnly = true;
            dataGridMisVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridMisVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridMisVentas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridMisVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridMisVentas.RowTemplate.Height = 25;
            dataGridMisVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMisVentas.Size = new Size(444, 267);
            dataGridMisVentas.TabIndex = 41;
            dataGridMisVentas.CellContentClick += dataGridMisVentas_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(147, 177, 166);
            panel2.Controls.Add(buscadorNombre);
            panel2.Controls.Add(buscadorApellido);
            panel2.Controls.Add(txBuscadorNombre);
            panel2.Controls.Add(txBuscadorApellido);
            panel2.Controls.Add(buscadorDni);
            panel2.Controls.Add(txBuscadorDni);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 38);
            panel2.TabIndex = 42;
            // 
            // buscadorNombre
            // 
            buscadorNombre.Anchor = AnchorStyles.Top;
            buscadorNombre.AutoSize = true;
            buscadorNombre.BackColor = Color.Transparent;
            buscadorNombre.FlatStyle = FlatStyle.Flat;
            buscadorNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorNombre.ForeColor = Color.White;
            buscadorNombre.Location = new Point(130, 10);
            buscadorNombre.Name = "buscadorNombre";
            buscadorNombre.Size = new Size(50, 13);
            buscadorNombre.TabIndex = 7;
            buscadorNombre.Text = "Nombre";
            // 
            // buscadorApellido
            // 
            buscadorApellido.Anchor = AnchorStyles.Top;
            buscadorApellido.AutoSize = true;
            buscadorApellido.BackColor = Color.Transparent;
            buscadorApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorApellido.ForeColor = SystemColors.Window;
            buscadorApellido.Location = new Point(296, 11);
            buscadorApellido.Name = "buscadorApellido";
            buscadorApellido.Size = new Size(52, 13);
            buscadorApellido.TabIndex = 8;
            buscadorApellido.Text = "Apellido";
            // 
            // txBuscadorNombre
            // 
            txBuscadorNombre.Anchor = AnchorStyles.None;
            txBuscadorNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorNombre.ForeColor = SystemColors.WindowFrame;
            txBuscadorNombre.Location = new Point(186, 7);
            txBuscadorNombre.Name = "txBuscadorNombre";
            txBuscadorNombre.PlaceholderText = "Nombre";
            txBuscadorNombre.Size = new Size(104, 20);
            txBuscadorNombre.TabIndex = 6;
            txBuscadorNombre.TextChanged += txBuscadorNombre_TextChanged;
            // 
            // txBuscadorApellido
            // 
            txBuscadorApellido.Anchor = AnchorStyles.Top;
            txBuscadorApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorApellido.ForeColor = SystemColors.WindowFrame;
            txBuscadorApellido.Location = new Point(352, 8);
            txBuscadorApellido.Name = "txBuscadorApellido";
            txBuscadorApellido.PlaceholderText = "Apellido";
            txBuscadorApellido.Size = new Size(110, 20);
            txBuscadorApellido.TabIndex = 9;
            txBuscadorApellido.TextChanged += txBuscadorApellido_TextChanged;
            // 
            // buscadorDni
            // 
            buscadorDni.Anchor = AnchorStyles.Top;
            buscadorDni.AutoSize = true;
            buscadorDni.BackColor = Color.Transparent;
            buscadorDni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorDni.ForeColor = SystemColors.Window;
            buscadorDni.Location = new Point(468, 11);
            buscadorDni.Name = "buscadorDni";
            buscadorDni.Size = new Size(29, 13);
            buscadorDni.TabIndex = 11;
            buscadorDni.Text = "DNI";
            // 
            // txBuscadorDni
            // 
            txBuscadorDni.Anchor = AnchorStyles.Top;
            txBuscadorDni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorDni.ForeColor = SystemColors.WindowFrame;
            txBuscadorDni.Location = new Point(503, 8);
            txBuscadorDni.Name = "txBuscadorDni";
            txBuscadorDni.PlaceholderText = "DNI";
            txBuscadorDni.Size = new Size(103, 20);
            txBuscadorDni.TabIndex = 10;
            txBuscadorDni.TextChanged += txBuscadorDni_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dataGridMisVentas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 43;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dateTimePickerHasta);
            panel4.Controls.Add(dateTimePickerDesde);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 121);
            panel4.TabIndex = 42;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(411, 99);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 51;
            label2.Text = "Hasta";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(233, 100);
            label1.Name = "label1";
            label1.Size = new Size(53, 16);
            label1.TabIndex = 48;
            label1.Text = "Desde";
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Anchor = AnchorStyles.Top;
            dateTimePickerHasta.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.CalendarForeColor = Color.IndianRed;
            dateTimePickerHasta.CalendarMonthBackground = SystemColors.MenuHighlight;
            dateTimePickerHasta.CalendarTitleBackColor = Color.DarkSlateGray;
            dateTimePickerHasta.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePickerHasta.CalendarTrailingForeColor = Color.CadetBlue;
            dateTimePickerHasta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.Location = new Point(461, 95);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(109, 21);
            dateTimePickerHasta.TabIndex = 50;
            dateTimePickerHasta.ValueChanged += dateTimePickerHasta_ValueChanged;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Anchor = AnchorStyles.Top;
            dateTimePickerDesde.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Location = new Point(286, 95);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(109, 21);
            dateTimePickerDesde.TabIndex = 49;
            dateTimePickerDesde.ValueChanged += dateTimePickerDesde_ValueChanged;
            // 
            // CMisVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "CMisVentas";
            Text = "Mis Ventas";
            Load += CMisVentas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMisVentas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTittleMisVentas;
        private DataGridView dataGridMisVentas;
        private Panel panel2;
        private Label buscadorNombre;
        private Label buscadorApellido;
        private TextBox txBuscadorNombre;
        private TextBox txBuscadorApellido;
        private Label buscadorDni;
        private TextBox txBuscadorDni;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerHasta;
        private DateTimePicker dateTimePickerDesde;
    }
}