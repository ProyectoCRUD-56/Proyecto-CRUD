using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conCategoria_Prod
    {
        private modCategoria_Prod categoria = new modCategoria_Prod();

        public DataTable MostrarCategoria()
        {
            DataTable tabla = new DataTable();
            tabla = categoria.Mostrar();
            return tabla;
        }
        public void Insertar_Categoria(string nombre, string desc)
        {
            categoria.Insertar(nombre, desc);
        }
        public void Editar_Categoria(string nombre, string desc, string id)
        {
            categoria.Editar(nombre, desc, Convert.ToInt32(id));
        }
        public void Eliminar_Categoria(string id)
        {
            categoria.Eliminar(Convert.ToInt32(id));
        }
    }
}
