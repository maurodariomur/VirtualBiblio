using System.Runtime.InteropServices;//biblioteca que permite arrastar el formulario
using Domain;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi;

namespace Proyecto_MauroMur
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita la captura de teclas en el formulario
            this.KeyDown += new KeyEventHandler(Login_KeyDown!); // Asigna el evento KeyDown
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            if (TUsuario.Text != "Usuario")
            {
                if (TContrase�a.Text != "Contrase�a")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(TUsuario.Text, TContrase�a.Text);
                    if (validLogin == true)
                    {
                        FLobi lobi = new FLobi();
                        lobi.Show();
                        lobi.FormClosed += (s, args) =>
                        {
                            Logout(s, args); // Llama a Logout con los par�metros adecuados
                        };
                        this.Hide(); // Cierra el formulario actual
                    }
                    else
                    {
                        msgError("Datos Incorrectos. Verificarlos.");
                        TContrase�a.Text = "Contrase�a";
                        TUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Por favor ingrese Contrase�a.");
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
            TContrase�a.Text = "Contrase�a";
            TContrase�a.UseSystemPasswordChar = false;
            TUsuario.Text = "Usuario";
            lbErrorMenssage.Visible = false;

            // Cierra el formulario FLobi si est� abierto
            if (Application.OpenForms.OfType<FLobi>().Any())
            {
                Application.OpenForms.OfType<FLobi>().First().Close();
            }

            this.Show();
            TUsuario.Focus();
        }

        private void iconEye_Click(object sender, EventArgs e)
        {
            TContrase�a.UseSystemPasswordChar = !TContrase�a.UseSystemPasswordChar;
        }

        private void TContrase�a_TextChanged(object sender, EventArgs e)
        {
            // Mostrar el bot�n IconEye solo si hay texto en el campo de contrase�a
            iconEye.Visible = !string.IsNullOrEmpty(TContrase�a.Text);
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // El usuario presion� la tecla Enter, as� que intenta iniciar sesi�n
                BLogin_Click(sender, e);
            }
        }
    }
}