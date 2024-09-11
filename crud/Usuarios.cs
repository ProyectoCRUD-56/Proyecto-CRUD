using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class Usuarios : Form
    {
        private conUsuario usuario = new conUsuario();
        private string idUsuario = null;
        private bool Editar_usuario = false;
        Validaciones valid = new();

        public Usuarios()
        {
            InitializeComponent();
        }
        private void MostrarUsuarios()
        {
            conUsuario usuario = new conUsuario();
            dataGridView1.DataSource = usuario.Mostrar_Usuarios();
        }

        private void ListarRoles()
        {
            conUsuario objeto = new conUsuario();
            CbRol.DataSource = objeto.Mostrar_Roles();
            CbRol.DisplayMember = "Tipo_Rol";
            CbRol.ValueMember = "Id_Rol";
            CbRol.SelectedValue = 0;
            CbRol.Text = "Selecciones una categoria:";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar_usuario == false)
            {
                try
                {   
                    if(valid.Validar_campos_vacios($"{txtNombre.Text},{txtApellido.Text},{txtContraseña.Text}, {txtEmail.Text}")
                        && valid.Validar_solo_letras($"{txtNombre.Text},{txtApellido.Text}", "Nombre,Apellido")
                        && valid.ValidarLargo($"{txtNombre.Text},{txtApellido.Text},{txtContraseña.Text}, {txtEmail.Text}", "Nombre,Apellido,Contraseña,Email","60,70,100,100"))
                    {
                        if (CbRol.SelectedValue != null)
                        {
                            usuario.Insertar_Usuario((int)CbRol.SelectedValue,txtNombre.Text,txtApellido.Text, txtContraseña.Text, txtEmail.Text);
                            MessageBox.Show("se inserto correctamente");
                            MostrarUsuarios();
                            limpiarForm();
                        } else
                        {
                            MessageBox.Show("Por favor selecciona un rol", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar_usuario == true)
            {
                try
                {
                    if (valid.Validar_campos_vacios($"{txtNombre.Text},{txtApellido.Text},{txtContraseña.Text}, {txtEmail.Text}")
                        && valid.Validar_solo_letras($"{txtNombre.Text},{txtApellido.Text}", "Nombre,Apellido")
                        && valid.ValidarLargo($"{txtNombre.Text},{txtApellido.Text},{txtContraseña.Text}, {txtEmail.Text}", "Nombre,Apellido,Contraseña,Email", "60,70,100,100"))
                    {
                        if (CbRol.SelectedValue != null)
                        {
                            usuario.Editar_Usuario(txtNombre.Text,txtApellido.Text, txtContraseña.Text, txtEmail.Text, (int)CbRol.SelectedValue, idUsuario);
                            MessageBox.Show("se edito correctamente");
                            MostrarUsuarios();
                            limpiarForm();
                            Editar_usuario = false;
                        } else
                        {
                            MessageBox.Show("Por favor selecciona un rol", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar_usuario = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre_Usuario"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido_Usuario"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                CbRol.SelectedValue = dataGridView1.CurrentRow.Cells["Id_Rol"].Value.ToString();
                idUsuario = dataGridView1.CurrentRow.Cells["Id_usuario"].Value.ToString();
                
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idUsuario = dataGridView1.CurrentRow.Cells["Id_usuario"].Value.ToString();
                usuario.Eliminar_Usuario(idUsuario);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            ListarRoles();
        }
        private void limpiarForm()
        {
            txtNombre.Clear();
            txtContraseña.Clear();
            txtEmail.Clear();
            CbRol.SelectedIndex = -1;
            CbRol.Text = "Selecciona un Rol:";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }
    }
}
