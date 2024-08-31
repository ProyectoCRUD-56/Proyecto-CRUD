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

namespace Presentacion
{
    public partial class Clientes : Form
    {
        private conCliente cliente = new conCliente();
        private string idCliente = null;
        private bool Editar = false;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void limpiarForm()
        {
            txtApellido.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            comboBox1.Text = string.Empty;
        }

        private void MostrarClientes()
        {
            conCliente cliente1 = new conCliente();
            dataGridView1.DataSource = cliente1.MostrarClientes();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    cliente.InsertarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarClientes();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    cliente.EditarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, idCliente);
                    MessageBox.Show("se edito correctamente");
                    MostrarClientes();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["Id_cliente"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idCliente = dataGridView1.CurrentRow.Cells["Id_cliente"].Value.ToString();
                cliente.EliminarCliente(idCliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarClientes();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
