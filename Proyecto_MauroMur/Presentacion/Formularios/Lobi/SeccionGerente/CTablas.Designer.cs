namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    partial class CTablas
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
            lbTitleTable = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            buscadorNombre = new Label();
            buscadorApellido = new Label();
            txBuscadorNombre = new TextBox();
            txBuscadorApellido = new TextBox();
            buscadorDni = new Label();
            buscadorRoles = new Label();
            txBuscadorDni = new TextBox();
            cBBuscadorPerfil = new ComboBox();
            panel4 = new Panel();
            checkBoxAZ = new CheckBox();
            dataGridUsuarios = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTitleTable);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 51);
            panel1.TabIndex = 0;
            // 
            // lbTitleTable
            // 
            lbTitleTable.Anchor = AnchorStyles.Top;
            lbTitleTable.AutoSize = true;
            lbTitleTable.BackColor = Color.Transparent;
            lbTitleTable.FlatStyle = FlatStyle.Flat;
            lbTitleTable.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitleTable.ForeColor = Color.Gainsboro;
            lbTitleTable.Location = new Point(452, 9);
            lbTitleTable.Name = "lbTitleTable";
            lbTitleTable.Size = new Size(269, 31);
            lbTitleTable.TabIndex = 1;
            lbTitleTable.Text = "Lista de Empleados";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(147, 177, 166);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 51);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(buscadorNombre);
            panel3.Controls.Add(buscadorApellido);
            panel3.Controls.Add(txBuscadorNombre);
            panel3.Controls.Add(txBuscadorApellido);
            panel3.Controls.Add(buscadorDni);
            panel3.Controls.Add(buscadorRoles);
            panel3.Controls.Add(txBuscadorDni);
            panel3.Controls.Add(cBBuscadorPerfil);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1122, 36);
            panel3.TabIndex = 8;
            // 
            // buscadorNombre
            // 
            buscadorNombre.Anchor = AnchorStyles.Top;
            buscadorNombre.AutoSize = true;
            buscadorNombre.BackColor = Color.Transparent;
            buscadorNombre.FlatStyle = FlatStyle.Flat;
            buscadorNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorNombre.ForeColor = Color.White;
            buscadorNombre.Location = new Point(221, 8);
            buscadorNombre.Name = "buscadorNombre";
            buscadorNombre.Size = new Size(50, 13);
            buscadorNombre.TabIndex = 1;
            buscadorNombre.Text = "Nombre";
            // 
            // buscadorApellido
            // 
            buscadorApellido.Anchor = AnchorStyles.Top;
            buscadorApellido.AutoSize = true;
            buscadorApellido.BackColor = Color.Transparent;
            buscadorApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorApellido.ForeColor = SystemColors.Window;
            buscadorApellido.Location = new Point(387, 9);
            buscadorApellido.Name = "buscadorApellido";
            buscadorApellido.Size = new Size(52, 13);
            buscadorApellido.TabIndex = 2;
            buscadorApellido.Text = "Apellido";
            // 
            // txBuscadorNombre
            // 
            txBuscadorNombre.Anchor = AnchorStyles.None;
            txBuscadorNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorNombre.ForeColor = SystemColors.WindowFrame;
            txBuscadorNombre.Location = new Point(277, 7);
            txBuscadorNombre.Name = "txBuscadorNombre";
            txBuscadorNombre.PlaceholderText = "Nombre";
            txBuscadorNombre.Size = new Size(104, 20);
            txBuscadorNombre.TabIndex = 0;
            txBuscadorNombre.TextChanged += txBuscadorNombre_TextChanged;
            txBuscadorNombre.KeyPress += txBuscadorNombre_KeyPress;
            // 
            // txBuscadorApellido
            // 
            txBuscadorApellido.Anchor = AnchorStyles.Top;
            txBuscadorApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorApellido.ForeColor = SystemColors.WindowFrame;
            txBuscadorApellido.Location = new Point(443, 7);
            txBuscadorApellido.Name = "txBuscadorApellido";
            txBuscadorApellido.PlaceholderText = "Apellido";
            txBuscadorApellido.Size = new Size(110, 20);
            txBuscadorApellido.TabIndex = 3;
            txBuscadorApellido.TextChanged += txBuscadorApellido_TextChanged;
            txBuscadorApellido.KeyPress += txBuscadorApellido_KeyPress;
            // 
            // buscadorDni
            // 
            buscadorDni.Anchor = AnchorStyles.Top;
            buscadorDni.AutoSize = true;
            buscadorDni.BackColor = Color.Transparent;
            buscadorDni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorDni.ForeColor = SystemColors.Window;
            buscadorDni.Location = new Point(559, 10);
            buscadorDni.Name = "buscadorDni";
            buscadorDni.Size = new Size(29, 13);
            buscadorDni.TabIndex = 5;
            buscadorDni.Text = "DNI";
            // 
            // buscadorRoles
            // 
            buscadorRoles.Anchor = AnchorStyles.Top;
            buscadorRoles.AutoSize = true;
            buscadorRoles.BackColor = Color.Transparent;
            buscadorRoles.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buscadorRoles.ForeColor = SystemColors.Window;
            buscadorRoles.Location = new Point(700, 10);
            buscadorRoles.Name = "buscadorRoles";
            buscadorRoles.Size = new Size(65, 13);
            buscadorRoles.TabIndex = 6;
            buscadorRoles.Text = "Tipo Perfil";
            // 
            // txBuscadorDni
            // 
            txBuscadorDni.Anchor = AnchorStyles.Top;
            txBuscadorDni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txBuscadorDni.ForeColor = SystemColors.WindowFrame;
            txBuscadorDni.Location = new Point(591, 8);
            txBuscadorDni.Name = "txBuscadorDni";
            txBuscadorDni.PlaceholderText = "DNI";
            txBuscadorDni.Size = new Size(103, 20);
            txBuscadorDni.TabIndex = 4;
            txBuscadorDni.TextChanged += txBuscadorDni_TextChanged;
            txBuscadorDni.KeyPress += txBuscadorDni_KeyPress;
            // 
            // cBBuscadorPerfil
            // 
            cBBuscadorPerfil.Anchor = AnchorStyles.Top;
            cBBuscadorPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cBBuscadorPerfil.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBBuscadorPerfil.ForeColor = SystemColors.WindowFrame;
            cBBuscadorPerfil.FormattingEnabled = true;
            cBBuscadorPerfil.Items.AddRange(new object[] { "Gerente", "Administrador", "Vendedor" });
            cBBuscadorPerfil.Location = new Point(771, 6);
            cBBuscadorPerfil.Name = "cBBuscadorPerfil";
            cBBuscadorPerfil.Size = new Size(129, 21);
            cBBuscadorPerfil.TabIndex = 7;
            cBBuscadorPerfil.SelectedIndexChanged += cBBuscadorPerfil_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(221, 230, 237);
            panel4.Controls.Add(checkBoxAZ);
            panel4.Controls.Add(dataGridUsuarios);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(1122, 384);
            panel4.TabIndex = 3;
            // 
            // checkBoxAZ
            // 
            checkBoxAZ.AutoSize = true;
            checkBoxAZ.BackColor = Color.Transparent;
            checkBoxAZ.FlatAppearance.BorderSize = 0;
            checkBoxAZ.FlatStyle = FlatStyle.Flat;
            checkBoxAZ.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxAZ.ForeColor = Color.FromArgb(57, 91, 100);
            checkBoxAZ.Location = new Point(163, 13);
            checkBoxAZ.Name = "checkBoxAZ";
            checkBoxAZ.Size = new Size(135, 22);
            checkBoxAZ.TabIndex = 1;
            checkBoxAZ.Text = "A-Z.(Apellidos)";
            checkBoxAZ.UseVisualStyleBackColor = false;
            checkBoxAZ.CheckedChanged += checkBoxAZ_CheckedChanged;
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.AllowUserToAddRows = false;
            dataGridUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuarios.BackgroundColor = Color.FromArgb(221, 230, 237);
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(147, 177, 166);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridUsuarios.ColumnHeadersHeight = 30;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridUsuarios.EnableHeadersVisualStyles = false;
            dataGridUsuarios.GridColor = Color.FromArgb(165, 201, 202);
            dataGridUsuarios.Location = new Point(163, 38);
            dataGridUsuarios.MultiSelect = false;
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.ReadOnly = true;
            dataGridUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(221, 230, 237);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 79, 79);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridUsuarios.RowTemplate.Height = 25;
            dataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsuarios.Size = new Size(811, 313);
            dataGridUsuarios.TabIndex = 0;
            dataGridUsuarios.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // CTablas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 486);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CTablas";
            Text = "Tablas Usuarios";
            Load += CTablas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTitleTable;
        private Panel panel2;
        private Panel panel4;
        private DataGridView dataGridUsuarios;
        private TextBox txBuscadorApellido;
        private Label buscadorApellido;
        private Label buscadorNombre;
        private TextBox txBuscadorNombre;
        private Label buscadorRoles;
        private Label buscadorDni;
        private TextBox txBuscadorDni;
        private ComboBox cBBuscadorPerfil;
        private Panel panel3;
        private CheckBox checkBoxAZ;
    }
}