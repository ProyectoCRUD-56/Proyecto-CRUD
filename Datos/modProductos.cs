using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datos
{
    public class modProductos
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter adapter1 = new SqlDataAdapter();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Producto where Activo = 1";
            buffer = comando.ExecuteReader();
            
            tabla.Load(buffer);
            
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar_Categorias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Categoria_Producto where Activo = 1";
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
            {
                adapter.Fill(tabla);
            }
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar_Productos(string nombre, string desc, string marca, double precio, int stock, int categoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Producto values (@categoria,@nombre,@descrip,@marca,@precio,@stock,1)";
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar_Productos(string nombre, string desc, string marca, double precio, int stock, int id, int categoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Producto set IdCategoria=@categoria, Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id_producto=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }      

        
        public void Eliminar(int idpro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Producto  SET Activo = 0  WHERE Id_producto = @idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idpro", idpro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
