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
        public void InsertarCliente(string nombre, string apellido, string direccion, string telefono, string email, string cedula, string sexo)
        {
            clientes.InsertarCliente(nombre, apellido, direccion, telefono, email, cedula, sexo);
        }
        public void EditarCliente(string nombre, string apellido, string direccion, string telefono, string email, string cedula, string sexo, string id)
        {
            clientes.EditarCliente(nombre, apellido, direccion, telefono, email, cedula, sexo, Convert.ToInt32(id));
        }

        public void EliminarCliente(string id)
        {
            clientes.EliminarCliente(Convert.ToInt32(id));
        }
    }
}
