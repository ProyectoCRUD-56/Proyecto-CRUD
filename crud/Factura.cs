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
        private ListBox lstSugerencias;
        private DataGridView dgvResultados;
        private int idCliente,idProducto, idMetodoPago, idUsuario, numeroCantidad;
        private decimal total = 0;
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            Listar_MetodosPago();
            //Listar_Productos();
            clientes = factura.Mostrar_Clientes();
            Listar_Clientes(clientes, txtClientes);
            productos = factura.Mostrar_Productos();
            Listar_Productos(productos, txtProductos);
        }

        public void CalcularTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            txtTotal.Text = total.ToString();
        }

        private void Limpiar()
        {
            txtProductos.Clear();
            txtPrecio.Clear();
            NumCantidad.Value = 0;
            txtTotal.Clear();
            dataGridView1.Rows.Clear();
            cbMetodosPago.SelectedIndex = 0;
        }

        private void Listar_MetodosPago()
        {
            conFacturas objeto = new conFacturas();
            cbMetodosPago.DataSource = objeto.Mostrar_MetodosPago();
            cbMetodosPago.DisplayMember = "Metodo";
            cbMetodosPago.ValueMember = "Id_mediospago";
            cbMetodosPago.Text = "Selecciona un metodo de pago:";
        }
        private void Listar_Clientes(DataTable listado, TextBox textBox)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            //autoCompleteCollection.AddRange(categorias.Values.ToArray());
            foreach (DataRow item in listado.Rows)
            {
                autoCompleteCollection.Add((string)item["Nombre"]);
            }

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Listar_Productos(DataTable tabla, TextBox textBox)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            //autoCompleteCollection.AddRange(categorias.Values.ToArray());
            foreach (DataRow item in tabla.Rows)
            {
                autoCompleteCollection.Add((string)item["Nombre"]);
            }

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string producto = txtProductos.Text;
            int numCant = (int)NumCantidad.Value;
            productos = factura.Mostrar_Productos();

            foreach (DataRow item in productos.Rows)
            {
                if (producto == (string)item["Nombre"])
                {
                    if (numCant < (int)item["Stock"] && numCant > 0)
                    {
                        dataGridView1.Rows.Add(item["Nombre"], numCant, (double)item["Precio"], (double)item["Precio"] * numCant);
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
        }

        private void txtProductos_Leave(object sender, EventArgs e)
        {
            foreach (DataRow row in productos.Rows)
            {
                if (string.Equals(row["Nombre"].ToString(), txtProductos.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    // Si se encuentra coincidencia, mostrar el precio correspondiente en txtPrecio
                    txtPrecio.Text = row["Precio"].ToString();
                    break;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            TimeSpan hora = DateTime.Now.TimeOfDay;
            try
            {
                if (EncontrarCliente())
                {
                    if (dataGridView1.Rows.Count > 1)
                    {
                        int id = factura.Insertar_Factura(idCliente, 2, fecha, hora, (int)cbMetodosPago.SelectedValue, (float)total);

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if ((row.Cells.Cast<DataGridViewCell>().All(cell => cell.Value != null)))
                            {
                                numeroCantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                                foreach (DataRow row2 in productos.Rows)
                                {
                                    if (row.Cells["Producto"].Value.ToString() == row2["Nombre"].ToString())
                                    {
                                        idProducto = Convert.ToInt32(row2["Id_producto"]);
                                        factura.Insertar_Transaccion(id, idProducto, numeroCantidad);

                                    }
                                }
                            }   
                        }
                        Limpiar();
                        MessageBox.Show("Se inserto correctamente");
                    } else
                    {
                        MessageBox.Show("No se registra ningun producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool EncontrarCliente()
        {
            foreach (DataRow item in clientes.Rows)
            {
                if (txtClientes.Text == (string)item["Nombre"])
                {
                    idCliente = (int)item["Id_cliente"];
                    return true;
                }
            }
            return false;
        }

        private void Encontrar_Productos(DataGridViewRow row, int id)
        {
            if ((row.Cells.Cast<DataGridViewCell>().All(cell => cell.Value != null)))
            {
                numeroCantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                foreach (DataRow row2 in productos.Rows)
                {
                    if (row.Cells["Producto"].Value.ToString() == row2["Nombre"].ToString())
                    {
                        idProducto = Convert.ToInt32(row2["Id_producto"]);
                        factura.Insertar_Transaccion(id, idProducto, numeroCantidad);

                    }
                }
            }
        }
    }
}
