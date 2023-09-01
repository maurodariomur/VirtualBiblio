using Common.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class FormEdit : Form
    {
        private int userId;


        public FormEdit(int id)
        {
            InitializeComponent();
            userId = id;
            UserModel userModel = new();
            Usuarios? usuario = userModel.ImportarUsuarios(id);

            if (usuario != null)
            {
                txNameModificar.Text = usuario.Nombre;
                txLastNameModificar.Text = usuario.Apellido;
                dTBithModificar.Value = usuario.FechaNacimiento;
                txDNIModificar.Text = usuario.DNI;
                txMailModificar.Text = usuario.Mail;
                if (usuario.TipoPerfil == 1)
                {
                    txcPerfilModificar.Text = "1-Gerente";
                }
                else if (usuario.TipoPerfil == 2)
                {
                    txcPerfilModificar.Text = "2-Administrador";
                }
                else
                {
                    txcPerfilModificar.Text = "3-Vendedor";
                }
                txEmpleadoModificar.Text = usuario.Usuario;
                if (usuario.Baja == "SI")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox2.Checked = true;
                }

            }
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            // Configura el formato personalizado para el DateTimePicker
            dTBithModificar.CustomFormat = "dd/MM/yyyy";
            // Asegúrate de que la propiedad Format esté establecida en Custom
            dTBithModificar.Format = DateTimePickerFormat.Custom;
        }


        private void msgError(string msg)
        {
            lbErrorModificar.Text = "     " + msg;
            lbErrorModificar.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
