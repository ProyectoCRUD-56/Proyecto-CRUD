using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modMedios_Pago
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_MedioPago()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from MediosPago where Activo = 1";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }

        public string getNombre(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Metodo from MediosPago where Id_mediospago = @id";
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["Metodo"].ToString();
            else
                nombre = "No encontrado";
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }

        public void Insertar_MedioPago(string metodo, string detalles)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into MediosPago values (@metodo,@detalles,1)";
            comando.Parameters.AddWithValue("@metodo", metodo);
            comando.Parameters.AddWithValue("@detalles", detalles);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar_MedioPago(string metodo, string detalles, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update MediosPago set Metodo=@metodo, Detalles=@detalles where Id_mediospago=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@metodo", metodo);
            comando.Parameters.AddWithValue("@detalles", detalles);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar_MedioPago(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE MediosPago  SET Activo = 0  WHERE Id_mediospago = @id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
