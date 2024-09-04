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

namespace Presentacion
{
    public partial class Categoria_Producto : Form
    {
        private conCategoria_Prod categoria = new conCategoria_Prod();
        private string idCategoria = null;
        private bool Editar_Cate = false;

        public Categoria_Producto()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Close_Windows);
        }

        private void Categoria_Producto_Load(object sender, EventArgs e)
        {
            MostrarCategoria();
        }
        private void MostrarCategoria()
        {
            conCategoria_Prod objeto = new conCategoria_Prod();
            dataGridView1.DataSource = objeto.MostrarCategoria();
        }

        private void Close_Windows(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar_Cate == false)
            {
                try
                {
                    categoria.Insertar_Categoria(txtNombre.Text, txtDesc.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarCategoria();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar_Cate == true)
            {
                try
                {
                    categoria.Editar_Categoria(txtNombre.Text, txtDesc.Text, idCategoria);
                    MessageBox.Show("se edito correctamente");
                    MostrarCategoria();
                    limpiarForm();
                    Editar_Cate = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }
        private void limpiarForm()
        {
            txtDesc.Clear();
            txtNombre.Clear();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar_Cate = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                idCategoria = dataGridView1.CurrentRow.Cells["Id_categoria"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idCategoria = dataGridView1.CurrentRow.Cells["Id_categoria"].Value.ToString();
                categoria.Eliminar_Categoria(idCategoria);
                MessageBox.Show("Eliminado correctamente");
                MostrarCategoria();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void Buscar_Nombre_Click(object sender, EventArgs e)
        {
            txtResult.Text = categoria.getNombre((int)numericUpDown1.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Medios_Pago pago = new Medios_Pago();
            pago.Show();
            this.Hide();
        }
    }
}
