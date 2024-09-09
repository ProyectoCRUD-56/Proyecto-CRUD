using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modUsuarios
    {
        private Conexion conexion = new Conexion();
        SqlDataReader buffer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_Usuarios()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Usuarios where Activo = 1";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar_Usuarios(string nombre, string contraseña, string email, string rol)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Usuarios values (@nombre,@contraseña,@email,@rol,1)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar_Usuario(string nombre, string contraseña, string email, string rol, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Usuarios set NombreUsuario=@nombre, Contraseña=@contraseña, Email=@email, Rol=@rol where Id_usuario=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar_Usuario(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Usuarios  SET Activo = 0  WHERE Id_usuario = @id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
