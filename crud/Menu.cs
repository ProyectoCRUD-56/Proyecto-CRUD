using crud;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Close_Windows);
        }
        private void Close_Windows(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain Productos = new frmMain();
            Productos.MdiParent = this;
            Productos.Show();
        }

        private void categoriasProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria_Producto categoria = new Categoria_Producto();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void metodosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medios_Pago pago = new Medios_Pago();
            pago.MdiParent = this;
            pago.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.MdiParent= this;
            usuario.Show();
        }
    }
}
