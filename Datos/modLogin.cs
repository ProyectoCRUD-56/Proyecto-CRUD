using System;
using System.Data.SqlClient;

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
            // Generar el hash de la contraseña usando la clase Seguridad
            string hashedPassword = Seguridad.HashPassword(contraseña);

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE Nombre_Usuario = @usuario AND Contraseña = @contraseña AND Activo = 1";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", hashedPassword);  // Usar el hash calculado
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
