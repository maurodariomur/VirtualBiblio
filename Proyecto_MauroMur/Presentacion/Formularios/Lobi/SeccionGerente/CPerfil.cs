using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using static Common.Cache.UserLoginCache;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CPerfil : Form
    {
        public CPerfil()
        {
            InitializeComponent();
        }

        private void CPerfil_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {

            nombrecito.Text = UserLoginCache.Nombre;
            lbApellido.Text = UserLoginCache.Apellido;


        }
    }
}
