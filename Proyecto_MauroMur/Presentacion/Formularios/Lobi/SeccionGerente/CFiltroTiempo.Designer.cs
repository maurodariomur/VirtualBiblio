namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    partial class CFiltroTiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFiltroTiempo));
            iconImprimirChart = new FontAwesome.Sharp.IconButton();
            cbFiltroFechas = new ComboBox();
            iconClose = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // iconImprimirChart
            // 
            iconImprimirChart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconImprimirChart.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconImprimirChart.IconColor = Color.Black;
            iconImprimirChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconImprimirChart.IconSize = 30;
            iconImprimirChart.Location = new Point(251, 28);
            iconImprimirChart.Name = "iconImprimirChart";
            iconImprimirChart.Size = new Size(48, 35);
            iconImprimirChart.TabIndex = 0;
            iconImprimirChart.UseVisualStyleBackColor = true;
            iconImprimirChart.Click += iconImprimirChart_Click;
            // 
            // cbFiltroFechas
            // 
            cbFiltroFechas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroFechas.FlatStyle = FlatStyle.Flat;
            cbFiltroFechas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltroFechas.FormattingEnabled = true;
            cbFiltroFechas.Location = new Point(43, 35);
            cbFiltroFechas.Name = "cbFiltroFechas";
            cbFiltroFechas.Size = new Size(170, 23);
            cbFiltroFechas.TabIndex = 1;
            cbFiltroFechas.SelectedIndexChanged += cbFiltroFechas_SelectedIndexChanged;
            // 
            // iconClose
            // 
            iconClose.FlatAppearance.BorderSize = 0;
            iconClose.FlatStyle = FlatStyle.Flat;
            iconClose.IconChar = FontAwesome.Sharp.IconChar.X;
            iconClose.IconColor = Color.IndianRed;
            iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClose.IconSize = 20;
            iconClose.Location = new Point(332, 0);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(25, 21);
            iconClose.TabIndex = 2;
            iconClose.UseVisualStyleBackColor = true;
            iconClose.Click += iconClose_Click;
            // 
            // CFiltroTiempo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 79, 79);
            ClientSize = new Size(356, 111);
            Controls.Add(iconClose);
            Controls.Add(cbFiltroFechas);
            Controls.Add(iconImprimirChart);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CFiltroTiempo";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CFiltroTiempo";
            Load += CFiltroTiempo_Load;
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconImprimirChart;
        private ComboBox cbFiltroFechas;
        private FontAwesome.Sharp.IconButton iconClose;
    }
}