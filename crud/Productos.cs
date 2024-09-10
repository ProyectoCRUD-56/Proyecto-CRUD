using Negocios;
using Presentacion;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace crud
{
    public partial class frmMain : Form
    {
        private conProducto Producto = new conProducto();
        private string idProducto = null;
        private bool Editar = false;
        Validaciones valid = new Validaciones();
        private int valorId;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            ListarCategorias();
        }

        private void MostrarProductos()
        {
            conProducto objeto = new conProducto();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void ListarCategorias()
        {
            conProducto objeto = new conProducto();
            combo_categoria.DataSource = objeto.Mostrar_Categoria();
            combo_categoria.DisplayMember = "Nombre";
            combo_categoria.ValueMember = "Id_categoria";
            combo_categoria.Text= "Selecciones una categoria:";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    if (valid.Validar_campos_vacios($"{txtNombre.Text}, {txtDesc.Text}, {txtMarca.Text}, {txtPrecio.Text}, {txtStock.Text}")
                        && valid.Validar_solo_numero($"{txtPrecio.Text}, {txtStock.Text}","Precio,Stock"))
                    {
                        if ((combo_categoria.SelectedValue != null))
                        {
                            Producto.InsertarPRod(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, (int)combo_categoria.SelectedValue);
                            MessageBox.Show("Se inserto correctamente");
                            MostrarProductos();
                            limpiarForm();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una categoria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    if (valid.Validar_campos_vacios($"{txtNombre.Text}, {txtDesc.Text}, {txtMarca.Text}, {txtPrecio.Text}, {txtStock.Text}")
                        && valid.Validar_solo_numero($"{txtPrecio.Text}, {txtStock.Text}", "Precio,Stock"))
                    {
                        if ((combo_categoria.SelectedValue != null))
                        {
                            Producto.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto, (int)combo_categoria.SelectedValue);
                            MessageBox.Show("Se edito correctamente");
                            MostrarProductos();
                            limpiarForm();
                            Editar = false;
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una categoria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            } 
        }
        private void limpiarForm()
        {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
            combo_categoria.Text = "Selecciones una categoria:";
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            conProducto objeto = new conProducto();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id_producto"].Value.ToString();
                valorId = (int)dataGridView1.CurrentRow.Cells["IdCategoria"].Value;
                //if()
                foreach (DataRowView valor in combo_categoria.Items)
                {
                    int valorIdcombo = (int)valor[combo_categoria.ValueMember];

                    if (valorIdcombo == valorId)
                    {
                        combo_categoria.SelectedValue = valorId;
                        break;
                    }
                    else
                    {
                        combo_categoria.Text = "Categoria Inactiva";

                    }
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id_producto"].Value.ToString();
                Producto.EliminarPRod(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Categoria_Producto categoria = new Categoria_Producto();
            categoria.Show();
            this.Hide();
        }
    }
}
