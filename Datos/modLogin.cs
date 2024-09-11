using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Datos
{
    public class modLogin
    {
        private Conexion conexion = new Conexion();
        SqlDataReader buffer;
        SqlCommand comando = new SqlCommand();
        bool esValido = false;
        DataTable tabla = new DataTable();
        private int idUsuario, idRol;

        public (int, int) Verificar_Usuario(string usuario, string contraseña)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "SELECT Id_usuario,Id_Rol FROM Usuarios WHERE Nombre_Usuario = @usuario AND Contraseña = @contraseña AND Activo = 1";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña",contraseña);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                idUsuario = Convert.ToInt32(reader["Id_usuario"]);
                idRol = Convert.ToInt32(reader["Id_Rol"]);
            }
            conexion.CerrarConexion();
            return (idUsuario, idRol);
        }
    }
}
