using Negocios;
using Presentacion;

namespace crud
{
    public partial class frmMain : Form
    {
        private conProducto Producto = new conProducto();
        private string idProducto = null;
        private bool Editar = false;
        

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
                    if (Validar_campos_vacios())
                    {

                        if (Validar_solo_numero())
                        {

                            Producto.InsertarPRod(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                            MessageBox.Show("se inserto correctamente");
                            MostrarProductos();
                            limpiarForm();
                        }
                        else
                        {
                            MessageBox.Show("El Precio o Stock son incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                        if (Validar_solo_numero())
                        {

                            Producto.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                            MessageBox.Show("se edito correctamente");
                            MostrarProductos();
                            limpiarForm();
                            Editar = false;
                        }
                        else
                        {
                            MessageBox.Show("El Precio o Stock son incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private bool Validar_solo_numero()
        {
            if ((System.Text.RegularExpressions.Regex.IsMatch(txtPrecio.Text, @"^\d*$") && (Convert.ToInt32(txtPrecio.Text) > 0 && Convert.ToInt32(txtPrecio.Text) < 100000000)) &&
                (System.Text.RegularExpressions.Regex.IsMatch(txtStock.Text, @"^\d*$") && (Convert.ToInt32(txtStock.Text) > 0 && Convert.ToInt32(txtStock.Text) < 5000)))
            {
                return true;
            }
            return false;
        }

        private bool Validar_campos_vacios()
        {
            if (string.IsNullOrEmpty(txtDesc.Text) || string.IsNullOrEmpty(txtMarca.Text)
                || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                || string.IsNullOrEmpty(txtStock.Text))
                //|| combo_categoria.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
    }
}
