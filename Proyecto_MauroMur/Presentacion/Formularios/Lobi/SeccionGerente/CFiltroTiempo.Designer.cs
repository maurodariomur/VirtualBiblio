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
            lbHasta = new Label();
            lbDesde = new Label();
            dateTimePickerHasta = new DateTimePicker();
            dateTimePickerDesde = new DateTimePicker();
            chBMarcador = new CheckBox();
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
            // lbHasta
            // 
            lbHasta.Anchor = AnchorStyles.None;
            lbHasta.AutoSize = true;
            lbHasta.BackColor = Color.Transparent;
            lbHasta.FlatStyle = FlatStyle.Flat;
            lbHasta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbHasta.ForeColor = Color.Gainsboro;
            lbHasta.Location = new Point(32, 75);
            lbHasta.Name = "lbHasta";
            lbHasta.Size = new Size(40, 13);
            lbHasta.TabIndex = 55;
            lbHasta.Text = "Hasta";
            lbHasta.Visible = false;
            // 
            // lbDesde
            // 
            lbDesde.Anchor = AnchorStyles.None;
            lbDesde.AutoSize = true;
            lbDesde.BackColor = Color.Transparent;
            lbDesde.FlatStyle = FlatStyle.Flat;
            lbDesde.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDesde.ForeColor = Color.Gainsboro;
            lbDesde.Location = new Point(29, 40);
            lbDesde.Name = "lbDesde";
            lbDesde.Size = new Size(43, 13);
            lbDesde.TabIndex = 52;
            lbDesde.Text = "Desde";
            lbDesde.Visible = false;
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Anchor = AnchorStyles.None;
            dateTimePickerHasta.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.CalendarForeColor = Color.IndianRed;
            dateTimePickerHasta.CalendarMonthBackground = SystemColors.MenuHighlight;
            dateTimePickerHasta.CalendarTitleBackColor = Color.DarkSlateGray;
            dateTimePickerHasta.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePickerHasta.CalendarTrailingForeColor = Color.CadetBlue;
            dateTimePickerHasta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.Location = new Point(89, 68);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(95, 20);
            dateTimePickerHasta.TabIndex = 54;
            dateTimePickerHasta.Visible = false;
            dateTimePickerHasta.ValueChanged += dateTimePickerHasta_ValueChanged;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Anchor = AnchorStyles.None;
            dateTimePickerDesde.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Location = new Point(89, 35);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(95, 20);
            dateTimePickerDesde.TabIndex = 53;
            dateTimePickerDesde.Visible = false;
            dateTimePickerDesde.ValueChanged += dateTimePickerDesde_ValueChanged;
            // 
            // chBMarcador
            // 
            chBMarcador.AutoSize = true;
            chBMarcador.Location = new Point(32, 10);
            chBMarcador.Name = "chBMarcador";
            chBMarcador.Size = new Size(135, 19);
            chBMarcador.TabIndex = 56;
            chBMarcador.Text = "Especificación Fecha";
            chBMarcador.UseVisualStyleBackColor = true;
            chBMarcador.CheckedChanged += chBMarcador_CheckedChanged;
            // 
            // CFiltroTiempo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 79, 79);
            ClientSize = new Size(356, 111);
            Controls.Add(chBMarcador);
            Controls.Add(lbHasta);
            Controls.Add(lbDesde);
            Controls.Add(dateTimePickerHasta);
            Controls.Add(dateTimePickerDesde);
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
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconImprimirChart;
        private ComboBox cbFiltroFechas;
        private FontAwesome.Sharp.IconButton iconClose;
        private Label lbHasta;
        private Label lbDesde;
        private DateTimePicker dateTimePickerHasta;
        private DateTimePicker dateTimePickerDesde;
        private CheckBox chBMarcador;
    }
}