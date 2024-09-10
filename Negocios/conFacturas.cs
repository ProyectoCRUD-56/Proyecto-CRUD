using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conFacturas
    {
        private modFacturas factura = new modFacturas();

        public Dictionary<int,string> Mostrar_Clientes()
        {
            Dictionary<int,string> tabla = new Dictionary<int, string>();
            tabla = factura.Mostrar_Clientes();
            return tabla;
        }

        public DataTable Mostrar_Productos()
        {
            DataTable tabla = new DataTable();
            tabla = factura.Mostrar_Productos();
            return tabla;
        }

        public DataTable Mostrar_MetodosPago()
        {
            DataTable tabla = new DataTable();
            tabla = factura.Mostrar_MetodosPago();
            return tabla;
        }
    }
}
