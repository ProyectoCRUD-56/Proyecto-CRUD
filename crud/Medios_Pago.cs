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
    public partial class Medios_Pago : Form
    {
        private conMedio_Pago medioPago = new conMedio_Pago();
        private string idMedio_pago = null;
        private bool Editar_Medio = false;
        public Medios_Pago()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Close_Windows);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar_Medio == false)
            {
                try
                {
                    medioPago.Insertar_MedioPago(txtMetodo.Text, txtDetalles.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarMediosPago();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar_Medio == true)
            {
                try
                {
                    medioPago.Editar_MedioPago(txtMetodo.Text, txtDetalles.Text, idMedio_pago);
                    MessageBox.Show("se edito correctamente");
                    MostrarMediosPago();
                    limpiarForm();
                    Editar_Medio = false;
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
                Editar_Medio = true;
                txtMetodo.Text = dataGridView1.CurrentRow.Cells["Metodo"].Value.ToString();
                txtDetalles.Text = dataGridView1.CurrentRow.Cells["Detalles"].Value.ToString();
                idMedio_pago = dataGridView1.CurrentRow.Cells["Id_mediospago"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idMedio_pago = dataGridView1.CurrentRow.Cells["Id_mediospago"].Value.ToString();
                medioPago.Eliminar_MedioPago(idMedio_pago);
                MessageBox.Show("Eliminado correctamente");
                MostrarMediosPago();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Buscar_Metodo_Click(object sender, EventArgs e)
        {
            txtResult.Text = medioPago.getNombre((int)numericUpDown1.Value);
        }

        private void Medios_Pago_Load(object sender, EventArgs e)
        {
            MostrarMediosPago();
        }

        private void MostrarMediosPago()
        {
            conMedio_Pago medio_Pago = new conMedio_Pago();
            dataGridView1.DataSource = medio_Pago.MostrarMediosPago();
        }

        private void Close_Windows(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void limpiarForm()
        {
            txtDetalles.Clear();
            txtMetodo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }
    }
}
