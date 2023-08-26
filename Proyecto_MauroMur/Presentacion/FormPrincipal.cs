using System.Runtime.InteropServices;//biblioteca que permite arrastar el formulario
using Domain;
using Proyecto_MauroMur.Formularios.Lobi;

namespace Proyecto_MauroMur
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void TContraseña_Enter(object sender, EventArgs e)
        {
            if (TContraseña.Text == "Contraseña")
            {
                TContraseña.Text = "";
                TContraseña.ForeColor = Color.DimGray;
                TContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TContraseña_Leave(object sender, EventArgs e)
        {
            if (TContraseña.Text == "")
            {
                TContraseña.Text = "Contraseña";
                TContraseña.ForeColor = Color.Black;
                TContraseña.UseSystemPasswordChar = false;
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

        private void TUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            if (TUsuario.Text != "Usuario")
            {
                if (TContraseña.Text != "Contraseña")
                {
                    UserModel user=new UserModel();
                    var validLogin = user.LoginUser(TUsuario.Text, TContraseña.Text);
                    if (validLogin == true)
                    {
                        FLobi lobi = new FLobi();
                        lobi.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Datos Incorrectos.Verificarlos.");
                        TContraseña.Clear();
                        TUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Por favor ingrese Contraseña.");
                }
            }
            else
            {
                msgError("Por favor ingrese Usuario.");
            }
        }

        private void msgError(string msg)
        {
            lbErrorMenssage.Text = "        " + msg;
            lbErrorMenssage.Visible = true;
        }




        private void iconEye_Click(object sender, EventArgs e)
        {
            TContraseña.UseSystemPasswordChar = !TContraseña.UseSystemPasswordChar;
        }

        private void TContraseña_TextChanged(object sender, EventArgs e)
        {
            // Mostrar el botón IconEye solo si hay texto en el campo de contraseña
            iconEye.Visible = !string.IsNullOrEmpty(TContraseña.Text);
        }

        private void TContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}