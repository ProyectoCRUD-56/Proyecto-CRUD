using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection dbConexion = new SqlConnection("Server=DESKTOP-MBKNL6F\\SQLEXPRESS;DataBase=inventario;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (dbConexion.State == ConnectionState.Closed)
                dbConexion.Open();
            return dbConexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (dbConexion.State == ConnectionState.Open)
                dbConexion.Close();
            return dbConexion;
        }
    }
}
