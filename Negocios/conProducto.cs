using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;

namespace Negocios
{
    public class conProducto
    {
        private modProductos Productos = new modProductos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = Productos.Mostrar();
            return tabla;
        }

        public DataTable Mostrar_Categoria()
        {
            DataTable tabla = new DataTable();
            tabla = Productos.Mostrar_Categorias();
            return tabla;
        }

        public void InsertarPRod(string nombre, string desc, string marca, string precio, string stock, int categoria)
        {
            Productos.Insertar_Productos(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), categoria);
        }
        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string id, int categoria)
        {
            Productos.Editar_Productos(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id), categoria);
        }
        public void EliminarPRod(string id)
        {
            Productos.Eliminar(Convert.ToInt32(id));
        }
    }
}
