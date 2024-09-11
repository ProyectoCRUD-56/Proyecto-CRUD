using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentacion
{
    public partial class Factura : Form
    {
        DataTable productos,clientes = new DataTable();
        private conFacturas factura = new conFacturas();
        private int idCliente,idProducto, idUsuario, numeroCantidad;
        private decimal total = 0;

        public Factura(int idUsu)
        {
            InitializeComponent();
            idUsuario = idUsu;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            //Traer informacion de la base de datos y listarla
            Listar_MetodosPago();
            clientes = factura.Mostrar_Clientes();
            Listar_Clientes(clientes, txtClientes);
            productos = factura.Mostrar_Productos();
            Listar_Productos(productos, txtProductos);

            // Agregar una columna al datagrid que sea invisible donde se almacene el id del producto
            DataGridViewTextBoxColumn IDProducto = new DataGridViewTextBoxColumn();
            IDProducto.Name = "IdProducto";
            IDProducto.HeaderText = "IdProducto";
            IDProducto.Visible = false;
            dataGridView1.Columns.Add(IDProducto);
        }
        // Metodo para sumar el subtotal de todo los productos seleccionados en el datagrid
        public void CalcularTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            txtTotal.Text = total.ToString();
        }

        //Limpiar campos del formulario
        private void Limpiar()
        {
            txtProductos.Clear();
            txtPrecio.Clear();
            NumCantidad.Value = 0;
            txtTotal.Clear();
            dataGridView1.Rows.Clear();
            cbMetodosPago.SelectedValue = 0;
            cbMetodosPago.Text = "Selecciona un metodo de pago:";
            txtClientes.Clear();
        }
        // Metodo para listar todos los datos de los medios de pago en un combobox
        private void Listar_MetodosPago()
        {
            conFacturas objeto = new conFacturas();
            cbMetodosPago.DataSource = objeto.Mostrar_MetodosPago();
            cbMetodosPago.DisplayMember = "Metodo";
            cbMetodosPago.ValueMember = "Id_mediospago";
            cbMetodosPago.SelectedValue = 0;
            cbMetodosPago.Text = "Selecciona un metodo de pago:";
        }
        // Metodo para listar los clientes en un textbox con sugerencia
        private void Listar_Clientes(DataTable listado, TextBox textBox)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            //autoCompleteCollection.AddRange(categorias.Values.ToArray());
            foreach (DataRow item in listado.Rows)
            {
                autoCompleteCollection.Add((string)item["Nombre"]+ '_' + item["Id_cliente"].ToString());
            }

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        // Metodo para listar los productos en un textbox con sugerencia
        private void Listar_Productos(DataTable tabla, TextBox textBox)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            foreach (DataRow item in tabla.Rows)
            {
                autoCompleteCollection.Add((string)item["Nombre"] + '_' + item["Descripcion"] + '_' + item["Marca"] + '_' + item["Id_producto"].ToString());
            }
            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Al hacer click en Adicionar, se valida que haya algun producto ingresado y se lista en el datagrid
        private void button1_Click(object sender, EventArgs e)
        {
            string producto = txtProductos.Text;
            string[] partes = producto.Split('_');
            int numCant = (int)NumCantidad.Value;
            productos = factura.Mostrar_Productos();

            if (partes != null && partes.Length > 1)
            {
                //Busca en toda la informacion traida de productos y compara si existe el producto ingresado
                foreach (DataRow item in productos.Rows)
                {
                    if (Convert.ToInt32(partes[partes.Length - 1]) == (int)item["Id_producto"])
                    {
                        if (numCant < (int)item["Stock"] && numCant > 0)
                        {
                            dataGridView1.Rows.Add(item["Nombre"], numCant, (double)item["Precio"], (double)item["Precio"] * numCant, item["Id_producto"]);
                            txtProductos.Clear();
                            txtPrecio.Clear();
                            NumCantidad.Value = 0;
                            CalcularTotal();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No hay suficientes existencias en stock o la cantidad es cero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Debes seleccionar un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
        }

        //Metodo para mostrar el precio del producto buscado
        private void txtProductos_Leave(object sender, EventArgs e)
        {
            string producto = txtProductos.Text;
            string[] partes = producto.Split('_');
            foreach (DataRow row in productos.Rows)
            {
                if (string.Equals(row["Id_producto"].ToString(), partes[partes.Length - 1], StringComparison.OrdinalIgnoreCase))
                {
                    // Si se encuentra coincidencia, mostrar el precio correspondiente en txtPrecio
                    txtPrecio.Text = row["Precio"].ToString();
                    break;
                } else
                {
                    txtPrecio.Text = "0";
                }
            }
        }

        //Guarda la informacion de factura y crear una transaccion por cada producto ingresado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            TimeSpan hora = DateTime.Now.TimeOfDay;
            try
            {
                if (EncontrarCliente())
                {
                    if (cbMetodosPago.SelectedValue != null)
                    {
                        if (dataGridView1.Rows.Count > 1)
                        {
                            // Inserta factura en la base de datos, si encuentra algun producto seleccionado
                            int id = factura.Insertar_Factura(idCliente, idUsuario, fecha, hora, (int)cbMetodosPago.SelectedValue, (float)total);

                            //Recorre todos los productos del data grid y los compara si existen los productos
                            //Luego insertar la transaccion con los datos correspondientes
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if ((row.Cells.Cast<DataGridViewCell>().All(cell => cell.Value != null)))
                                {
                                    numeroCantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                                    foreach (DataRow row2 in productos.Rows)
                                    {
                                        if (row.Cells["IdProducto"].Value.ToString() == row2["Id_producto"].ToString())
                                        {
                                            idProducto = Convert.ToInt32(row2["Id_producto"]);
                                            factura.Insertar_Transaccion(id, idProducto, numeroCantidad);
                                        }
                                    }
                                }
                            }
                            Limpiar();
                            MessageBox.Show("Se inserto correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se registra ningun producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    } else
                    {
                        MessageBox.Show("No se encontró el Metodo de pago", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por: " + ex);
            }
        }

        //Metodo para comparar si el cliente seleccionado existe y pasar su id a la factura
        private bool EncontrarCliente()
        {
            string cliente = txtClientes.Text;
            string[] partes = cliente.Split('_');
            if (partes != null && partes.Length > 1)
            {
                foreach (DataRow item in clientes.Rows)
                {
                    if (Convert.ToInt32(partes[partes.Length - 1]) == (int)item["Id_cliente"])
                    {
                        idCliente = (int)item["Id_cliente"];
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
