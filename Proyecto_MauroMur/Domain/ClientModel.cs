using Common.Models;
using DataAccess;
using Proyecto_MauroMur.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class ClientModel
    {
        ClientDatos clienteDatos = new ClientDatos();
        public bool AgregarNuevoCliente(string telefono, string domicilio, DateTime fechaRegistro, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento)
        {
            return clienteDatos.AgregarCliente(nombre, apellido, dni, fechaNacimiento, mail,telefono,domicilio, fechaRegistro);
        }

        public List<ClienteConInformacion> MostrarClientes()
        {
            return clienteDatos.ObtenerClientes();
        }

        public ClienteConInformacion? ImportarCliente(int id)
        {
            return clienteDatos.TraerClientesId(id);
        }

        public Persona? obtenerClienteDni(string dni)
        {
            return clienteDatos.ObtenerPersonaPorDNI(dni);
        }

        public bool ActualizacionClient(int clientId, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento, string telefono, string domicilio, string baja)
        {
            return clienteDatos.ActualizarCliente(clientId, nombre, apellido, dni, mail,fechaNacimiento, telefono, domicilio, baja);
        }

        public bool IsValidDni(string dni)
        {
            return clienteDatos.ExisteDNI(dni);
        }

        public bool IsValidCorreo(string mail)
        {
            return clienteDatos.ExisteMail(mail);
        }


        public bool IsValidEdad(DateTime fechaNacimiento)
        {
            return clienteDatos.CumpleCondicionesFechaNacimiento(fechaNacimiento);
        }
    }
}
