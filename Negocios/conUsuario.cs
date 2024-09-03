using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conUsuario
    {
        private modUsuarios usuario = new modUsuarios();
        public DataTable Mostrar_Usuarios()
        {
            DataTable tabla = new DataTable();
            tabla = usuario.Mostrar_Usuarios();
            return tabla;
        }
        public void Insertar_Usuario(string nombre, string contraseña, string email, string rol)
        {
            usuario.Insertar_Usuarios(nombre, contraseña, email, rol);
        }
        public void Editar_Usuario(string nombre, string contraseña, string email, string rol, string id)
        {
            usuario.Editar_Usuario(nombre, contraseña, email, rol, Convert.ToInt32(id));
        }
        public void Eliminar_Usuario(string id)
        {
            usuario.Eliminar_Usuario(Convert.ToInt32(id));
        }

        public string getNombre(int id)
        {
            return usuario.getNombre(id);
        }
    }
}
