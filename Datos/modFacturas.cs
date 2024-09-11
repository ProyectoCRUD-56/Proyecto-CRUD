using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modFacturas
    {
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();

        public DataTable Mostrar_MetodosPago()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from MediosPago where Activo = 1";
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
            {
                adapter.Fill(tabla);
            }
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar_Clientes()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Clientes where Activo = 1";
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
            {
                adapter.Fill(tabla);
            }
            /*SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                int idCategoria = (int)reader["Id_cliente"];
                string nombreCategoria = reader["Nombre"].ToString();
                categorias.Add(idCategoria, nombreCategoria);
            }*/
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar_Productos()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Producto where Activo = 1";
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
            {
                adapter.Fill(tabla);
            }
            conexion.CerrarConexion();
            return tabla;
        }

        public int Insertar_Factura(int idCliente, int idUsuario, DateTime fecha, TimeSpan hora, int idMedioPago, float total)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Factura values (@idCliente,@idUsuario,@fecha,@hora,@idMedioPago,@total,1); SELECT SCOPE_IDENTITY();";
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@hora", hora);
            comando.Parameters.AddWithValue("@idMedioPago", idMedioPago);
            comando.Parameters.AddWithValue("@total", total);
            int clienteID = Convert.ToInt32(comando.ExecuteScalar());
            //comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return clienteID;
        }

        public void Insertar_Transaccion(int idFactura, int idProducto, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Transaccion values (" +
                "@idFactura," +
                "@idProducto," +
                "(select top 1 id_historial from Historial_Precios where @idProducto = Id_producto order by id_historial desc)," +
                "@cantidad," +
                "(select Precio from Producto where @idProducto = Id_producto)," +
                "1)";
            comando.Parameters.AddWithValue("@idFactura", idFactura);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
