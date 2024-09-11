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

        public DataTable Mostrar_Roles()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Roles";
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
            {
                adapter.Fill(tabla);
            }
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar_Usuarios(int idRol,string nombre, string apellido, string contraseña, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            //comando.CommandText = "insert into Usuarios values (@idRol,@nombre,@apellido,@contraseña,@email,1)";
            comando.CommandText = "RegistrarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_Usuario", nombre);
            comando.Parameters.AddWithValue("@Apellido_usuario", apellido);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@IdRol", idRol);
            comando.Parameters.AddWithValue("@Activo", 1);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar_Usuario(int idRol, string nombre, string contraseña, string apellido, string email,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Usuarios set Id_Rol=@rol, Nombre_Usuario=@nombre, Apellido_usuario=@apellido Contraseña=@contraseña, Email=@email where Id_usuario=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@rol", idRol);
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
