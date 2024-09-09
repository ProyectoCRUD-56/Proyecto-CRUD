using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modLogin
    {
        private Conexion conexion = new Conexion();
        SqlDataReader buffer;
        SqlCommand comando = new SqlCommand();
        bool esValido = false;

        public bool Verificar_Usuario(string usuario, string contraseña)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE Nombre_Usuario = @usuario AND Contraseña = @contraseña AND Activo = 1";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            try
            {
                int count = (int)comando.ExecuteScalar();
                esValido = (count > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return esValido;
        }
    }
}
