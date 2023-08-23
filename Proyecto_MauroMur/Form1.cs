using Proyecto_MauroMur.Peticiones;
using System.Runtime.InteropServices;//biblioteca que permite arrastar el formulario

namespace Proyecto_MauroMur
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PeticionUsuarios usuarios = new();
            usuarios.obtenerUsuarios();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TUsuario_Enter(object sender, EventArgs e)
        {
            if (TUsuario.Text == "Usuario")
            {
                TUsuario.Text = "";
                TUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TUsuario_Leave(object sender, EventArgs e)
        {
            if (TUsuario.Text == "")
            {
                TUsuario.Text = "Usuario";
                TUsuario.ForeColor = Color.Black;
            }
        }

        private void TContrase�a_Enter(object sender, EventArgs e)
        {
            if (TContrase�a.Text == "Contrase�a")
            {
                TContrase�a.Text = "";
                TContrase�a.ForeColor = Color.DimGray;
                TContrase�a.UseSystemPasswordChar = true;
            }
        }

        private void TContrase�a_Leave(object sender, EventArgs e)
        {
            if (TContrase�a.Text == "")
            {
                TContrase�a.Text = "Contrase�a";
                TContrase�a.ForeColor = Color.Black;
                TContrase�a.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}