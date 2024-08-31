using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conCliente
    {
        private modClientes clientes = new modClientes();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = clientes.MostrarCliente();
            return tabla;
        }
        public void InsertarCliente(string nombre, string apellido, string direccion, string telefono, string email)
        {
            clientes.InsertarCliente(nombre, apellido, direccion, telefono, email);
        }
        public void EditarCliente(string nombre, string apellido, string direccion, string telefono, string email, string id)
        {
            clientes.EditarCliente(nombre, apellido, direccion, telefono, email, Convert.ToInt32(id));
        }
        /*public void EliminarCLiente(string id)
        {
            clientes.elimi(Convert.ToInt32(id));
        }*/

        public string getNombreCliente(int id)
        {
            return clientes.getNombreCliente(id);
        }

        public void EliminarCliente(string id)
        {
            clientes.EliminarCliente(Convert.ToInt32(id));
        }

        public int ContarCliente()
        {
            return clientes.contarCliente();
        }
    }
}
