namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    partial class CPerfil
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
            panel1 = new Panel();
            tbNombre = new TextBox();
            lbApellido = new Label();
            nombrecito = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(lbApellido);
            panel1.Controls.Add(nombrecito);
            panel1.Location = new Point(62, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 279);
            panel1.TabIndex = 0;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(100, 41);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(114, 23);
            tbNombre.TabIndex = 2;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(38, 92);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(38, 15);
            lbApellido.TabIndex = 1;
            lbApellido.Text = "label1";
            // 
            // nombrecito
            // 
            nombrecito.AutoSize = true;
            nombrecito.BackColor = SystemColors.ActiveBorder;
            nombrecito.Location = new Point(38, 44);
            nombrecito.Name = "nombrecito";
            nombrecito.Size = new Size(38, 15);
            nombrecito.TabIndex = 0;
            nombrecito.Text = "label1";
            // 
            // CPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CPerfil";
            Text = "Perfil";
            Load += CPerfil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbApellido;
        private Label nombrecito;
        private TextBox tbNombre;
    }
}