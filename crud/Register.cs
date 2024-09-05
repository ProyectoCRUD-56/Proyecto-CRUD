using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string confirmarContraseña = txtConfirmarContraseña.Text;
            string email = txtEmail.Text;
            string rol = txtRol.Text;

            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            UsuarioManager db = new UsuarioManager();

            // Verificar si el nombre de usuario ya existe
            string checkUserQuery = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
            SqlParameter[] checkUserParams = {
        new SqlParameter("@NombreUsuario", nombreUsuario)
    };

            DataTable userTable = db.ExecuteQuery(checkUserQuery, checkUserParams);

            if (userTable.Rows[0][0].ToString() != "0")
            {
                MessageBox.Show("El nombre de usuario ya existe. Elige otro.");
                return;
            }

            // Insertar el nuevo usuario en la base de datos
            string insertQuery = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Email, Rol, Activo) VALUES (@NombreUsuario, @Contraseña, @Email, @Rol, 1)";
            SqlParameter[] insertParams = {
        new SqlParameter("@NombreUsuario", nombreUsuario),
        new SqlParameter("@Contraseña", contraseña),
        new SqlParameter("@Email", email),
        new SqlParameter("@Rol", rol)
    };

            int result = db.ExecuteNonQuery(insertQuery, insertParams);

            if (result > 0)
            {
                MessageBox.Show("Registro exitoso.");
                this.Close(); // Cierra el formulario de registro
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }

        }
    }
}
