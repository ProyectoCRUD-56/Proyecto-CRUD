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

        public Dictionary<int, string> Mostrar_Clientes()
        {
            SqlCommand comando = new SqlCommand();
            Dictionary<int, string> categorias = new Dictionary<int, string>();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Id_cliente,Nombre from Clientes where Activo = 1";
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                int idCategoria = (int)reader["Id_cliente"];
                string nombreCategoria = reader["Nombre"].ToString();
                categorias.Add(idCategoria, nombreCategoria);
                
            }
            conexion.CerrarConexion();
            return categorias;
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
    }
}
