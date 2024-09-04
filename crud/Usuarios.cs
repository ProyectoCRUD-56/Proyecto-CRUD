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

        public Usuarios()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Close_Windows);
        }

        private void MostrarUsuarios()
        {
            conUsuario usuario = new conUsuario();
            dataGridView1.DataSource = usuario.Mostrar_Usuarios();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar_usuario == false)
            {
                try
                {
                    usuario.Insertar_Usuario(txtUsuario.Text, txtContraseña.Text, txtEmail.Text, CbRol.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarUsuarios();
                    limpiarForm();
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
                    usuario.Editar_Usuario(txtUsuario.Text, txtContraseña.Text, txtEmail.Text, CbRol.Text, idUsuario);
                    MessageBox.Show("se edito correctamente");
                    MostrarUsuarios();
                    limpiarForm();
                    Editar_usuario = false;
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
                txtUsuario.Text = dataGridView1.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                CbRol.Text = dataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
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

        private void Buscar_usuario_Click(object sender, EventArgs e)
        {
            txtResult.Text = usuario.getNombre((int)numericUpDown1.Value);
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void limpiarForm()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtEmail.Clear();
            CbRol.Text = string.Empty;
        }

        private void Close_Windows(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
