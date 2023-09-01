using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Common.Cache;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi
{
    public partial class FLobi : Form
    {
        private IconButton currentBtn;
        private Panel leftBoderBtn;
        private Form currentChildForm;

        public FLobi()
        {
            InitializeComponent();
            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBoderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(240, 235, 206);
            public static Color color2 = Color.FromArgb(170, 139, 86);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(4, 13, 18);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBoderBtn.BackColor = color;
                leftBoderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBoderBtn.Visible = true;
                leftBoderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(24, 61, 61);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        internal void OpenChildForm(Form childForm) //internal puede manejar los formularios (hijos de)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleCurrentForm.Text = childForm.Text;
        }

        private void iconUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new SeccionGerente.CUsuarios(this));
        }

        private void iconEstadistica_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new SeccionGerente.CEstadistica());
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            DialogResult salida = MessageBox.Show("Estas seguro que desea salir", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (salida == DialogResult.OK)
            {
                this.Close();
            }


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBoderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            lbTitleCurrentForm.Text = "Inicio";
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlobiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlobiMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnlobiMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Lhora_Click(object sender, EventArgs e)
        {

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            Lhora.Text = DateTime.Now.ToLongTimeString();
            Lfecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();


        }

        private void Lfecha_Click(object sender, EventArgs e)
        {

        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {
            // Colores para el degradado
            Color color1 = Color.FromArgb(24, 61, 61);
            Color color2 = Color.Silver;

            // Crear un pincel de degradado lineal
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(0, 0),                   // Punto inicial del degradado (arriba)
                new Point(0, panelTitleBar.Height), // Punto final del degradado (abajo)
                color1,                             // Color inicial
                color2                              // Nuevo color final
            );

            // Dibujar el degradado en el panel
            e.Graphics.FillRectangle(gradientBrush, new Rectangle(0, 0, panelTitleBar.Width, panelTitleBar.Height));

            // Liberar recursos
            gradientBrush.Dispose();

        }

        private void FLobi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Image = Image.FromFile("C:\\Users\\Priscila\\source\\repos\\VirtualBiblio\\Proyecto_MauroMur\\Presentacion\\Formularios\\Pictures\\Sistema\\Bienvenidos.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void iconDatos_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            switch (UserLoginCache.TipoPerfil)
            {
                case 1:
                    lbRol.Text = "Gerente";
                    break;
                case 2:
                    lbRol.Text = "Administrador";
                    break;
                case 3:
                    lbRol.Text = "Vendedor";
                    break;
                default:
                    lbRol.Text = "Desconocido";
                    break;
            }
            lbNApe.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            lbCorreo.Text = UserLoginCache.Mail;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbNApe_Click(object sender, EventArgs e)
        {

        }
    }
}

