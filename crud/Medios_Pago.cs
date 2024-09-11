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
        Validaciones valid = new Validaciones();
        public Medios_Pago()
        {
            InitializeComponent();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar_Medio == false)
            {
                try
                {
                    if (valid.Validar_campos_vacios($"{txtMetodo.Text}, {txtDetalles.Text}")
                        && valid.Validar_solo_letras($"{txtMetodo.Text}, {txtDetalles.Text}","Metodo,Detalles")
                        && valid.ValidarLargo($"{txtMetodo.Text}, {txtDetalles.Text}", "Metodo,Detalles","70,100"))
                    {
                        medioPago.Insertar_MedioPago(txtMetodo.Text, txtDetalles.Text);
                        MessageBox.Show("Se insertó correctamente");
                        MostrarMediosPago();
                        limpiarForm();
                    }
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
                    if (valid.Validar_campos_vacios($"{txtMetodo.Text}, {txtDetalles.Text}, {idMedio_pago}")
                        && valid.Validar_solo_letras($"{txtMetodo.Text}, {txtDetalles.Text}, {idMedio_pago}","Metodo,Detalles,Medio de Pago")
                        && valid.ValidarLargo($"{txtMetodo.Text}, {txtDetalles.Text}", "Metodo,Detalles", "15,25"))
                    {
                        medioPago.Editar_MedioPago(txtMetodo.Text, txtDetalles.Text, idMedio_pago);
                        MessageBox.Show("se edito correctamente");
                        MostrarMediosPago();
                        limpiarForm();
                        Editar_Medio = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
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
        private void Medios_Pago_Load(object sender, EventArgs e)
        {
            MostrarMediosPago();
        }
        private void MostrarMediosPago()
        {
            conMedio_Pago medio_Pago = new conMedio_Pago();
            dataGridView1.DataSource = medio_Pago.MostrarMediosPago();
        }
        private void limpiarForm()
        {
            txtDetalles.Clear();
            txtMetodo.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Show();
            this.Hide();
        }
    }
}
