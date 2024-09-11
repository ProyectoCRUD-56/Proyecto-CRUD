using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class conLogin
    {
        private int idUsuario, idRol;
        private modLogin login = new modLogin();
        public (int, int) Verificar_Usuario(string usuario, string contraseña)
        {
            idUsuario = login.Verificar_Usuario(usuario, contraseña).Item1;
            idRol = login.Verificar_Usuario(usuario, contraseña).Item2;
            return (idUsuario, idRol);
        }
    }
}