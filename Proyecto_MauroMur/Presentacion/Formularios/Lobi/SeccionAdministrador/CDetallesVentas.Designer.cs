namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    partial class CDetallesVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDetallesVentas));
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
            panel1.Size = new Size(681, 51);
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
            lbTittleMisDetalles.Location = new Point(225, 9);
            lbTittleMisDetalles.Name = "lbTittleMisDetalles";
            lbTittleMisDetalles.Size = new Size(214, 31);
            lbTittleMisDetalles.TabIndex = 0;
            lbTittleMisDetalles.Text = "Detalle Factura";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(147, 177, 166);
            panel2.Controls.Add(btnVolverDetalles);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 51);
            panel2.TabIndex = 42;
            // 
            // btnVolverDetalles
            // 
            btnVolverDetalles.Anchor = AnchorStyles.Right;
            btnVolverDetalles.BackColor = Color.FromArgb(57, 91, 100);
            btnVolverDetalles.Cursor = Cursors.Hand;
            btnVolverDetalles.FlatAppearance.BorderSize = 0;
            btnVolverDetalles.FlatStyle = FlatStyle.Flat;
            btnVolverDetalles.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverDetalles.ForeColor = SystemColors.ButtonFace;
            btnVolverDetalles.Location = new Point(253, 6);
            btnVolverDetalles.Name = "btnVolverDetalles";
            btnVolverDetalles.Size = new Size(176, 35);
            btnVolverDetalles.TabIndex = 37;
            btnVolverDetalles.Text = "Volver";
            btnVolverDetalles.UseVisualStyleBackColor = false;
            btnVolverDetalles.Click += btnVolverDetalles_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(221, 230, 237);
            panel3.Controls.Add(dataGridMisVentas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(681, 315);
            panel3.TabIndex = 43;
            // 
            // dataGridMisVentas
            // 
            dataGridMisVentas.AllowUserToAddRows = false;
            dataGridMisVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMisVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridMisVentas.Cursor = Cursors.Hand;
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
            dataGridMisVentas.Location = new Point(67, 24);
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
            dataGridMisVentas.Size = new Size(547, 223);
            dataGridMisVentas.TabIndex = 42;
            // 
            // CDetallesVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 417);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CDetallesVentas";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MisDetalles";
            Load += CDetallesVentas_Load;
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