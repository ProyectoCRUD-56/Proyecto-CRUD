using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class Login : Form
    {
        private conLogin login = new conLogin();
        private bool valido = false;
        Validaciones valid = new Validaciones();
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
                    if (valid.Validar_campos_vacios($"{txtUsuario.Text},{ txtContraseña.Text}"))
                    {
                        if (login.Verificar_Usuario(txtUsuario.Text, txtContraseña.Text))
                        {
                            MessageBox.Show("Inicio de sesion satisfactorio.");
                            Menu menu = new Menu();
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
                    MessageBox.Show("No se pudo iniciar sesion por: " + ex);
                }
            }
        }
    }
}
