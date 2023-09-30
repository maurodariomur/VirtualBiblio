using System.Runtime.InteropServices;
using Domain;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi;

namespace Proyecto_MauroMur
{
    public partial class Login : Form
    {
        private FLobi? _lobi;

        public Login(FLobi lobi)
        {
            InitializeComponent();
            _lobi = lobi;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown!); 
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            if (TUsuario.Text != "Usuario")
            {
                if (TContraseña.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(TUsuario.Text, TContraseña.Text);
                    if (validLogin == true)
                    {
                        this.Close();
                        _lobi!.Show();
                        _lobi.FormClosed += (s, args) =>
                        {
                            Logout(s, args); 
                        };
                    }
                    else
                    {
                        msgError("Datos Incorrectos. Verificarlos.");
                        TContraseña.Text = "Contraseña";
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

        private void Logout(object sender, FormClosedEventArgs e)
        {
            TContraseña.Text = "Contraseña";
            TContraseña.UseSystemPasswordChar = false;
            TUsuario.Text = "Usuario";
            lbErrorMenssage.Visible = false;

            if (Application.OpenForms.OfType<FLobi>().Any())
            {
                Application.OpenForms.OfType<FLobi>().First().Close();
            }
            FLobi lobi = new();
            Login login = new(lobi);
            login.Show();
            TUsuario.Focus();
        }

        private void iconEye_Click(object sender, EventArgs e)
        {
            TContraseña.UseSystemPasswordChar = !TContraseña.UseSystemPasswordChar;
        }

        private void TContraseña_TextChanged(object sender, EventArgs e)
        {
            iconEye.Visible = !string.IsNullOrEmpty(TContraseña.Text);
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BLogin_Click(sender, e);
            }
        }
    }
}