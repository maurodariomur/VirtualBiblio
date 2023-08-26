using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDatos userDatos = new UserDatos();
        public bool LoginUser(string user,string pass)
        {
            return userDatos.Login(user,pass);
        }
    }
}