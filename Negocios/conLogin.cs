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
        private bool validar = false;
        private modLogin login = new modLogin();
        public bool Verificar_Usuario(string usuario, string contraseña)
        {
            return login.Verificar_Usuario(usuario, contraseña);
        }
    }
}
