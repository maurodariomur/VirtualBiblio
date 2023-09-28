namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    partial class CMisDetalles
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lbTittleMisDetalles = new Label();
            panel2 = new Panel();
            btnVolverDetalles = new Button();
            panel3 = new Panel();
            dataGridMisVentas = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMisVentas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTittleMisDetalles);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 51);
            panel1.TabIndex = 41;
            // 
            // lbTittleMisDetalles
            // 
            lbTittleMisDetalles.Anchor = AnchorStyles.Top;
            lbTittleMisDetalles.AutoSize = true;
            lbTittleMisDetalles.BackColor = Color.Transparent;
            lbTittleMisDetalles.FlatStyle = FlatStyle.Flat;
            lbTittleMisDetalles.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTittleMisDetalles.ForeColor = Color.Gainsboro;
            lbTittleMisDetalles.Location = new Point(286, 9);
            lbTittleMisDetalles.Name = "lbTittleMisDetalles";
            lbTittleMisDetalles.Size = new Size(214, 31);
            lbTittleMisDetalles.TabIndex = 0;
            lbTittleMisDetalles.Text = "Detalle Factura";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 79, 79);
            panel2.Controls.Add(btnVolverDetalles);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 51);
            panel2.TabIndex = 42;
            // 
            // btnVolverDetalles
            // 
            btnVolverDetalles.Anchor = AnchorStyles.Right;
            btnVolverDetalles.BackColor = Color.BurlyWood;
            btnVolverDetalles.Cursor = Cursors.Hand;
            btnVolverDetalles.FlatAppearance.BorderSize = 0;
            btnVolverDetalles.FlatStyle = FlatStyle.Flat;
            btnVolverDetalles.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverDetalles.ForeColor = SystemColors.ButtonFace;
            btnVolverDetalles.Location = new Point(306, 6);
            btnVolverDetalles.Name = "btnVolverDetalles";
            btnVolverDetalles.Size = new Size(176, 35);
            btnVolverDetalles.TabIndex = 37;
            btnVolverDetalles.Text = "Volver";
            btnVolverDetalles.UseVisualStyleBackColor = false;
            btnVolverDetalles.Click += btnVolverDetalles_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(dataGridMisVentas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 223);
            panel3.TabIndex = 43;
            // 
            // dataGridMisVentas
            // 
            dataGridMisVentas.AllowUserToAddRows = false;
            dataGridMisVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMisVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridMisVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridMisVentas.BackgroundColor = Color.FromArgb(221, 230, 237);
            dataGridMisVentas.BorderStyle = BorderStyle.None;
            dataGridMisVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridMisVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(147, 177, 166);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridMisVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridMisVentas.ColumnHeadersHeight = 30;
            dataGridMisVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridMisVentas.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridMisVentas.EnableHeadersVisualStyles = false;
            dataGridMisVentas.GridColor = Color.FromArgb(165, 201, 202);
            dataGridMisVentas.Location = new Point(109, 0);
            dataGridMisVentas.MultiSelect = false;
            dataGridMisVentas.Name = "dataGridMisVentas";
            dataGridMisVentas.ReadOnly = true;
            dataGridMisVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridMisVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridMisVentas.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle10.SelectionForeColor = Color.WhiteSmoke;
            dataGridMisVentas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridMisVentas.RowTemplate.Height = 25;
            dataGridMisVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMisVentas.Size = new Size(547, 223);
            dataGridMisVentas.TabIndex = 42;
            // 
            // CMisDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 325);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CMisDetalles";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MisDetalles";
            Load += CMisDetalles_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMisVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTittleMisDetalles;
        private Panel panel2;
        private Button btnVolverDetalles;
        private Panel panel3;
        private DataGridView dataGridMisVentas;
    }
}