using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modClientes
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        
        public DataTable MostrarCliente()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Clientes WHERE Activo = 1";
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

        public void InsertarCliente(string nombre, string apellido, string direccion, string telefono, string email, string cedula, string sexo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Clientes values (@nombre,@apellido,@cedula,@sexo,@direccion,@telefono,@email,1)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarCliente(string nombre, string apellido, string direccion, string telefono, string email, string cedula, string sexo, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Clientes set Nombre=@nombre, Apellido=@apellido,N_Identificacion=@cedula,Sexo=@sexo, Direccion=@direccion, Telefono=@telefono, Email=@email where Id_cliente=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarCliente(int idcli)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Clientes  SET Activo = 0  WHERE Id_cliente = @idcli";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idcli", idcli);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
