namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    partial class CRespaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRespaldo));
            panel1 = new Panel();
            lbTitleRespaldo = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxRuta = new TextBox();
            iconSeleccionar = new FontAwesome.Sharp.IconButton();
            iconBackup = new FontAwesome.Sharp.IconButton();
            lbNameDataBase = new Label();
            lbErrorModificar = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(lbTitleRespaldo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 39;
            // 
            // lbTitleRespaldo
            // 
            lbTitleRespaldo.Anchor = AnchorStyles.Top;
            lbTitleRespaldo.AutoSize = true;
            lbTitleRespaldo.BackColor = Color.Transparent;
            lbTitleRespaldo.FlatStyle = FlatStyle.Flat;
            lbTitleRespaldo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitleRespaldo.ForeColor = Color.Gainsboro;
            lbTitleRespaldo.Location = new Point(307, 9);
            lbTitleRespaldo.Name = "lbTitleRespaldo";
            lbTitleRespaldo.Size = new Size(247, 31);
            lbTitleRespaldo.TabIndex = 0;
            lbTitleRespaldo.Text = "Backup DataBase";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(290, 74);
            label1.Name = "label1";
            label1.Size = new Size(271, 22);
            label1.TabIndex = 41;
            label1.Text = "Nombre de la Base de Datos";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(307, 160);
            label2.Name = "label2";
            label2.Size = new Size(236, 22);
            label2.TabIndex = 42;
            label2.Text = "Ubicacion de Guardado";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Anchor = AnchorStyles.None;
            textBoxRuta.Enabled = false;
            textBoxRuta.Location = new Point(290, 185);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(271, 23);
            textBoxRuta.TabIndex = 43;
            // 
            // iconSeleccionar
            // 
            iconSeleccionar.Anchor = AnchorStyles.None;
            iconSeleccionar.BackColor = Color.FromArgb(18, 72, 107);
            iconSeleccionar.FlatAppearance.BorderSize = 0;
            iconSeleccionar.FlatStyle = FlatStyle.Flat;
            iconSeleccionar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconSeleccionar.ForeColor = Color.Gainsboro;
            iconSeleccionar.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            iconSeleccionar.IconColor = Color.Gainsboro;
            iconSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSeleccionar.IconSize = 20;
            iconSeleccionar.ImageAlign = ContentAlignment.MiddleLeft;
            iconSeleccionar.Location = new Point(244, 237);
            iconSeleccionar.Name = "iconSeleccionar";
            iconSeleccionar.Size = new Size(158, 35);
            iconSeleccionar.TabIndex = 44;
            iconSeleccionar.Text = "Seccione Carpeta";
            iconSeleccionar.TextAlign = ContentAlignment.MiddleRight;
            iconSeleccionar.UseVisualStyleBackColor = false;
            iconSeleccionar.Click += iconSeleccionar_Click;
            // 
            // iconBackup
            // 
            iconBackup.Anchor = AnchorStyles.None;
            iconBackup.BackColor = Color.FromArgb(65, 145, 151);
            iconBackup.FlatAppearance.BorderSize = 0;
            iconBackup.FlatStyle = FlatStyle.Flat;
            iconBackup.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconBackup.ForeColor = Color.Gainsboro;
            iconBackup.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            iconBackup.IconColor = Color.Gainsboro;
            iconBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBackup.IconSize = 20;
            iconBackup.ImageAlign = ContentAlignment.MiddleLeft;
            iconBackup.Location = new Point(441, 237);
            iconBackup.Name = "iconBackup";
            iconBackup.Size = new Size(158, 35);
            iconBackup.TabIndex = 45;
            iconBackup.Text = "      Realizar BackUp";
            iconBackup.UseVisualStyleBackColor = false;
            iconBackup.Click += iconBackup_Click;
            // 
            // lbNameDataBase
            // 
            lbNameDataBase.Anchor = AnchorStyles.None;
            lbNameDataBase.AutoSize = true;
            lbNameDataBase.BackColor = Color.FromArgb(221, 230, 237);
            lbNameDataBase.FlatStyle = FlatStyle.Flat;
            lbNameDataBase.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNameDataBase.ForeColor = Color.FromArgb(18, 72, 107);
            lbNameDataBase.Location = new Point(345, 107);
            lbNameDataBase.Name = "lbNameDataBase";
            lbNameDataBase.Size = new Size(167, 25);
            lbNameDataBase.TabIndex = 46;
            lbNameDataBase.Text = "bd_virtualBiblio";
            // 
            // lbErrorModificar
            // 
            lbErrorModificar.Anchor = AnchorStyles.None;
            lbErrorModificar.AutoSize = true;
            lbErrorModificar.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorModificar.ForeColor = Color.Brown;
            lbErrorModificar.Image = (Image)resources.GetObject("lbErrorModificar.Image");
            lbErrorModificar.ImageAlign = ContentAlignment.MiddleLeft;
            lbErrorModificar.Location = new Point(192, 301);
            lbErrorModificar.Name = "lbErrorModificar";
            lbErrorModificar.Size = new Size(38, 23);
            lbErrorModificar.TabIndex = 47;
            lbErrorModificar.Text = "Error";
            lbErrorModificar.TextAlign = ContentAlignment.MiddleCenter;
            lbErrorModificar.UseCompatibleTextRendering = true;
            lbErrorModificar.Visible = false;
            // 
            // CRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(lbErrorModificar);
            Controls.Add(lbNameDataBase);
            Controls.Add(iconBackup);
            Controls.Add(iconSeleccionar);
            Controls.Add(textBoxRuta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CRespaldo";
            Text = "Respaldo";
            Load += CRespaldo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbTitleRespaldo;
        private Label label1;
        private Label label2;
        private TextBox textBoxRuta;
        private FontAwesome.Sharp.IconButton iconSeleccionar;
        private FontAwesome.Sharp.IconButton iconBackup;
        private Label lbNameDataBase;
        private Label lbErrorModificar;
    }
}