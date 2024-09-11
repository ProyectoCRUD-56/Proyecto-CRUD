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

        public DataTable Mostrar_Clientes()
        {
            DataTable tabla = new DataTable();
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

        public int Insertar_Factura(int idCliente, int idUsuario, DateTime fecha, TimeSpan hora, int idMedioPago, float total)
        {
            int idFactura = factura.Insertar_Factura(idCliente, idUsuario, fecha, hora, idMedioPago, total);
            return idFactura;
        }

        public void Insertar_Transaccion(int idFactura, int idProducto, int cantidad)
        {
            factura.Insertar_Transaccion(idFactura, idProducto, cantidad);
        }
    }
}
