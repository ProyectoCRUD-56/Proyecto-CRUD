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

        public DataTable Mostrar_Roles()
        {
            DataTable tabla = new DataTable();
            tabla = usuario.Mostrar_Roles();
            return tabla;
        }
        public void Insertar_Usuario(int idRol,string nombre,string apellido, string contraseña, string email)
        {
            usuario.Insertar_Usuarios(idRol, nombre, apellido, contraseña, email);
        }
        public void Editar_Usuario(string nombre,string apellido, string contraseña, string email, int idRol, string id)
        {
            usuario.Editar_Usuario(idRol, nombre, contraseña, email, apellido, Convert.ToInt32(id));
        }
        public void Eliminar_Usuario(string id)
        {
            usuario.Eliminar_Usuario(Convert.ToInt32(id));
        }
    }
}
