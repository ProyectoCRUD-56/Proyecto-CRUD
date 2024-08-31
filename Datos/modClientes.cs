using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class modClientes
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        
        public DataTable MostrarCliente()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Clientes";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }

        public Int32 contarCliente()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(*) as cuenta from Clientes";
            Int32 cont = (Int32)comando.ExecuteScalar();
            conexion.CerrarConexion();
            return cont;
        }

        public string getNombreCliente(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Nombre from Clientes where Id_cliente = @id";
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["Nombre"].ToString();
            else
                nombre = "No encontrado";
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }

        public void InsertarCliente(string nombre, string apellido, string direccion, string telefono, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Clientes values (@nombre,@apellido,@direccion,@telefono,@email,1)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarCliente(string nombre, string apellido, string direccion, string telefono, string email,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Clientes set Nombre=@nombre, Apellido=@apellido, Direccion=@direccion, Telefono=@telefono, Email=@email where Id_cliente=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
