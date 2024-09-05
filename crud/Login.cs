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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Consulta SQL para verificar las credenciales
            string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña AND Activo = 1";
            SqlParameter[] parameters = {
        new SqlParameter("@NombreUsuario", nombreUsuario),
        new SqlParameter("@Contraseña", contraseña)
    };

            UsuarioManager db = new UsuarioManager();
            DataTable userTable = db.ExecuteQuery(query, parameters);

            if (userTable.Rows.Count > 0)
            {
                MessageBox.Show("Login exitoso.");
                // Aquí puedes abrir el formulario principal o continuar con la aplicación
                this.Hide(); // Oculta el formulario de login
                Menu formMenu = new Menu();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de registro
            Register formRegister = new Register();

            // Mostrar el formulario de registro
            formRegister.Show();

            // Opcional: Ocultar el formulario de login si deseas que solo uno esté visible a la vez
            // this.Hide();
        }
    }
}


