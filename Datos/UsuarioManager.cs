using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioManager
    {
        private Conexion conexion = new Conexion();

        public bool RegistrarUsuario(string nombreUsuario, string contraseña, string email, string rol)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    string checkUserQuery = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Usuario ya existe
                            return false;
                        }
                    }

                    string insertQuery = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Email, Rol, Activo) VALUES (@NombreUsuario, @Contraseña, @Email, @Rol, 1)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        insertCmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Rol", rol);
                        insertCmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al registrar el usuario: " + ex.Message);
            }
        }

        public bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    string authQuery = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña AND Activo = 1";
                    using (SqlCommand authCmd = new SqlCommand(authQuery, conn))
                    {
                        authCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        authCmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        int userCount = (int)authCmd.ExecuteScalar();

                        return userCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }
        }
    }
}