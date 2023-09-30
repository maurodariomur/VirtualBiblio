namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    partial class CHistorialVentas
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
            lbTittleVentas = new Label();
            panel2 = new Panel();
            txBuscadorApellidoC = new TextBox();
            lbBuscadorApellido = new Label();
            txBuscadorNCliente = new TextBox();
            lbUsuario = new Label();
            txBuscadorNombre = new TextBox();
            buscadorDni = new Label();
            txBuscadorDni = new TextBox();
            dataGridVentas = new DataGridView();
            dateTimePickerDesde = new DateTimePicker();
            dateTimePickerHasta = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTittleVentas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 41;
            // 
            // lbTittleVentas
            // 
            lbTittleVentas.Anchor = AnchorStyles.Top;
            lbTittleVentas.AutoSize = true;
            lbTittleVentas.BackColor = Color.Transparent;
            lbTittleVentas.FlatStyle = FlatStyle.Flat;
            lbTittleVentas.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTittleVentas.ForeColor = Color.Gainsboro;
            lbTittleVentas.Location = new Point(280, 9);
            lbTittleVentas.Name = "lbTittleVentas";
            lbTittleVentas.Size = new Size(221, 31);
            lbTittleVentas.TabIndex = 0;
            lbTittleVentas.Text = "Historial Ventas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(147, 177, 166);
            panel2.Controls.Add(txBuscadorApellidoC);
            panel2.Controls.Add(lbBuscadorApellido);
            panel2.Controls.Add(txBuscadorNCliente);
            panel2.Controls.Add(lbUsuario);
            panel2.Controls.Add(txBuscadorNombre);
            panel2.Controls.Add(buscadorDni);
            panel2.Controls.Add(txBuscadorDni);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 38);
            panel2.TabIndex = 43;
            // 
            // txBuscadorApellidoC
            // 
            txBuscadorApellidoC.Anchor = AnchorStyles.None;
            txBuscadorApellidoC.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorApellidoC.ForeColor = SystemColors.WindowFrame;
            txBuscadorApellidoC.Location = new Point(321, 8);
            txBuscadorApellidoC.Name = "txBuscadorApellidoC";
            txBuscadorApellidoC.PlaceholderText = "Apellido";
            txBuscadorApellidoC.Size = new Size(104, 20);
            txBuscadorApellidoC.TabIndex = 16;
            txBuscadorApellidoC.TextChanged += txBuscadorApellidoC_TextChanged;
            // 
            // lbBuscadorApellido
            // 
            lbBuscadorApellido.Anchor = AnchorStyles.Top;
            lbBuscadorApellido.AutoSize = true;
            lbBuscadorApellido.BackColor = Color.Transparent;
            lbBuscadorApellido.FlatStyle = FlatStyle.Flat;
            lbBuscadorApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBuscadorApellido.ForeColor = Color.White;
            lbBuscadorApellido.Location = new Point(256, 11);
            lbBuscadorApellido.Name = "lbBuscadorApellido";
            lbBuscadorApellido.Size = new Size(64, 13);
            lbBuscadorApellido.TabIndex = 15;
            lbBuscadorApellido.Text = "C.Apellido";
            // 
            // txBuscadorNCliente
            // 
            txBuscadorNCliente.Anchor = AnchorStyles.None;
            txBuscadorNCliente.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorNCliente.ForeColor = SystemColors.WindowFrame;
            txBuscadorNCliente.Location = new Point(146, 8);
            txBuscadorNCliente.Name = "txBuscadorNCliente";
            txBuscadorNCliente.PlaceholderText = "Nombre";
            txBuscadorNCliente.Size = new Size(104, 20);
            txBuscadorNCliente.TabIndex = 14;
            txBuscadorNCliente.TextChanged += txBuscadorNCliente_TextChanged;
            // 
            // lbUsuario
            // 
            lbUsuario.Anchor = AnchorStyles.Top;
            lbUsuario.AutoSize = true;
            lbUsuario.BackColor = Color.Transparent;
            lbUsuario.FlatStyle = FlatStyle.Flat;
            lbUsuario.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbUsuario.ForeColor = Color.White;
            lbUsuario.Location = new Point(78, 11);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(62, 13);
            lbUsuario.TabIndex = 13;
            lbUsuario.Text = "C.Nombre";
            // 
            // txBuscadorNombre
            // 
            txBuscadorNombre.Anchor = AnchorStyles.None;
            txBuscadorNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorNombre.ForeColor = SystemColors.WindowFrame;
            txBuscadorNombre.Location = new Point(486, -20);
            txBuscadorNombre.Name = "txBuscadorNombre";
            txBuscadorNombre.PlaceholderText = "Nombre";
            txBuscadorNombre.Size = new Size(104, 20);
            txBuscadorNombre.TabIndex = 6;
            // 
            // buscadorDni
            // 
            buscadorDni.Anchor = AnchorStyles.Top;
            buscadorDni.AutoSize = true;
            buscadorDni.BackColor = Color.Transparent;
            buscadorDni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorDni.ForeColor = SystemColors.Window;
            buscadorDni.Location = new Point(434, 11);
            buscadorDni.Name = "buscadorDni";
            buscadorDni.Size = new Size(41, 13);
            buscadorDni.TabIndex = 11;
            buscadorDni.Text = "C.DNI";
            // 
            // txBuscadorDni
            // 
            txBuscadorDni.Anchor = AnchorStyles.Top;
            txBuscadorDni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorDni.ForeColor = SystemColors.WindowFrame;
            txBuscadorDni.Location = new Point(481, 6);
            txBuscadorDni.Name = "txBuscadorDni";
            txBuscadorDni.PlaceholderText = "DNI";
            txBuscadorDni.Size = new Size(103, 20);
            txBuscadorDni.TabIndex = 10;
            txBuscadorDni.TextChanged += txBuscadorDni_TextChanged;
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridVentas.BackgroundColor = Color.FromArgb(221, 230, 237);
            dataGridVentas.BorderStyle = BorderStyle.None;
            dataGridVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(147, 177, 166);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridVentas.ColumnHeadersHeight = 30;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridVentas.EnableHeadersVisualStyles = false;
            dataGridVentas.GridColor = Color.FromArgb(165, 201, 202);
            dataGridVentas.Location = new Point(202, 141);
            dataGridVentas.MultiSelect = false;
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridVentas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridVentas.RowTemplate.Height = 25;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(444, 267);
            dataGridVentas.TabIndex = 44;
            dataGridVentas.CellContentClick += dataGridVentas_CellContentClick;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Anchor = AnchorStyles.Top;
            dateTimePickerDesde.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dateTimePickerDesde.Location = new Point(239, 8);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(109, 22);
            dateTimePickerDesde.TabIndex = 45;
            dateTimePickerDesde.ValueChanged += dateTimePickerDesde_ValueChanged;
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Anchor = AnchorStyles.Top;
            dateTimePickerHasta.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.CalendarForeColor = Color.IndianRed;
            dateTimePickerHasta.CalendarMonthBackground = SystemColors.MenuHighlight;
            dateTimePickerHasta.CalendarTitleBackColor = Color.DarkSlateGray;
            dateTimePickerHasta.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePickerHasta.CalendarTrailingForeColor = Color.CadetBlue;
            dateTimePickerHasta.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dateTimePickerHasta.Location = new Point(414, 8);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(109, 22);
            dateTimePickerHasta.TabIndex = 46;
            dateTimePickerHasta.ValueChanged += dateTimePickerHasta_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(186, 13);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 17;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(364, 12);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 47;
            label2.Text = "Hasta";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(221, 230, 237);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(dateTimePickerHasta);
            panel3.Controls.Add(dateTimePickerDesde);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 38);
            panel3.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(621, -23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Apellido";
            textBox1.Size = new Size(104, 20);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(446, -23);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nombre";
            textBox2.Size = new Size(104, 20);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(786, -51);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nombre";
            textBox3.Size = new Size(104, 20);
            textBox3.TabIndex = 6;
            // 
            // CHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(dataGridVentas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CHistorialVentas";
            Text = "Historial Ventas";
            Load += CHistorialVentas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTittleVentas;
        private Panel panel2;
        private TextBox txBuscadorNombre;
        private Label buscadorDni;
        private TextBox txBuscadorDni;
        private DataGridView dataGridVentas;
        private TextBox txBuscadorNCliente;
        private Label lbUsuario;
        private DateTimePicker dateTimePickerDesde;
        private DateTimePicker dateTimePickerHasta;
        private TextBox txBuscadorApellidoC;
        private Label lbBuscadorApellido;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}