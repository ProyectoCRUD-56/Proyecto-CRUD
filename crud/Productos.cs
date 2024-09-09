using Negocios;
using Presentacion;

namespace crud
{
    public partial class frmMain : Form
    {
        private conProducto Producto = new conProducto();
        private string idProducto = null;
        private bool Editar = false;
        Validaciones valid = new Validaciones();

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            conProducto objeto = new conProducto();
            dataGridView1.DataSource = objeto.MostrarProd();
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
                        Producto.InsertarPRod(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                        MessageBox.Show("se inserto correctamente");
                        MostrarProductos();
                        limpiarForm();
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
                    if (valid.Validar_campos_vacios($"{txtNombre.Text}, {txtDesc.Text}, {txtMarca.Text}, {txtPrecio.Text}, {txtStock.Text}")
                        && valid.Validar_solo_numero($"{txtPrecio.Text}, {txtStock.Text}", "Precio,Stock"))
                    {
                        Producto.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                        MessageBox.Show("se edito correctamente");
                        MostrarProductos();
                        limpiarForm();
                        Editar = false;
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
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id_producto"].Value.ToString();
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
