using crud;
using Datos;
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
    public partial class Clientes : Form
    {
        private conCliente cliente = new conCliente();
        private string idCliente = null;
        private bool Editar = false;
        private string sexo = null;
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
                    if (Validar_campos_vacios())
                    {
                        if (Validar_solo_letras())
                        {
                            if (Validar_solo_numero())
                            {
                                if (comboBox1.Text == "Masculino")
                                {
                                    sexo = "M";
                                }
                                else if (comboBox1.Text == "Femenino")
                                {
                                    sexo = "F";
                                }
                                cliente.InsertarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtCedula.Text, sexo);
                                MessageBox.Show("se inserto correctamente");
                                MostrarClientes();
                                limpiarForm();
                            }
                            else
                            {
                                MessageBox.Show("Cedula o Telefono incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show(" Nombre o Apellido incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Porfavor llene todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

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
                    if (Validar_campos_vacios())
                    {
                        if (Validar_solo_letras())
                        {
                            if (Validar_solo_numero())
                            {
                                if (comboBox1.Text == "Masculino")
                                {
                                    sexo = "M";
                                }
                                else if (comboBox1.Text == "Femenino")
                                {
                                    sexo = "F";
                                }
                                cliente.EditarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtCedula.Text, sexo, idCliente);
                                MessageBox.Show("se edito correctamente");
                                MostrarClientes();
                                limpiarForm();
                                Editar = false;
                            }
                            else
                            {
                                MessageBox.Show("Cedula o Telefono incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show(" Nombre o Apellido incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Porfavor llene todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
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
                txtCedula.Text = dataGridView1.CurrentRow.Cells["N_Identificacion"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["Id_cliente"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString() == "M")
                {
                    comboBox1.Text = "Masculino";
                } else if (dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString() == "F")
                {
                    comboBox1.Text = "Femenino";
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain Productos = new frmMain();
            Productos.Show();
            this.Hide();
        }

        private bool Validar_campos_vacios()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
                || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtCorreo.Text)
                || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text)
                || comboBox1.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private bool Validar_solo_letras()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]*$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z]*$"))
            {
                return false;
            }
            return true;
        }

        private bool Validar_solo_numero()
        {
            if ((System.Text.RegularExpressions.Regex.IsMatch(txtCedula.Text, @"^\d*$") && (txtCedula.Text.Length > 6 && txtCedula.Text.Length <= 11)) &&
                (System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d*$") && (txtTelefono.Text.Length == 10)))
            {
                return true;
            }
            return false;
        }
    }
}
