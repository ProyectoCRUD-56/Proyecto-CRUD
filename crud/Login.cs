using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using Negocios;
using System.Text;

namespace Presentacion
{
    public partial class Login : Form
    {
        private conLogin login = new conLogin();
        private bool valido = false;
        Validaciones valid = new Validaciones();
        private int idUsuario, idRol;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (valido == false)
            {
                try
                {
                    if (valid.Validar_campos_vacios($"{txtUsuario.Text},{txtContraseña.Text}"))
                    {
                        string contraseña = ConvertirASha256(txtContraseña.Text);
                        idUsuario = login.Verificar_Usuario(txtUsuario.Text, contraseña).Item1;
                        idRol = login.Verificar_Usuario(txtUsuario.Text, contraseña).Item2;

                        if (idRol == 1)
                        {
                            MessageBox.Show("Inicio de sesion satisfactorio.");
                            Menu menu = new Menu(idUsuario);
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo iniciar sesión por: " + ex.Message);
                }
            }
        }

        private string ConvertirASha256(string texto)
        {
            // Crear una instancia de SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir el texto a bytes
                byte[] bytes = Encoding.Unicode.GetBytes(texto);

                // Aplicar el algoritmo SHA256
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convertir el hash a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                // Devolver la cadena de hash
                return sb.ToString();
            }
        }
    }
}
