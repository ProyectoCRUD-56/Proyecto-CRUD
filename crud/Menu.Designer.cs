namespace Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasProductosToolStripMenuItem = new ToolStripMenuItem();
            metodosDePagoToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            checkoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, categoriasProductosToolStripMenuItem, metodosDePagoToolStripMenuItem, usuariosToolStripMenuItem, checkoutToolStripMenuItem });
            menuStrip1.BackColor = Color.FromArgb(15, 15, 15);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1067, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.FromArgb(15, 15, 15);
            clientesToolStripMenuItem.ForeColor = Color.LightGray;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.ForeColor = Color.LightGray;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(89, 24);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoriasProductosToolStripMenuItem
            // 
            categoriasProductosToolStripMenuItem.ForeColor = Color.LightGray;
            categoriasProductosToolStripMenuItem.Name = "categoriasProductosToolStripMenuItem";
            categoriasProductosToolStripMenuItem.Size = new Size(164, 24);
            categoriasProductosToolStripMenuItem.Text = "Categorias Productos";
            categoriasProductosToolStripMenuItem.Click += categoriasProductosToolStripMenuItem_Click;
            // 
            // metodosDePagoToolStripMenuItem
            // 
            metodosDePagoToolStripMenuItem.ForeColor = Color.LightGray;
            metodosDePagoToolStripMenuItem.Name = "metodosDePagoToolStripMenuItem";
            metodosDePagoToolStripMenuItem.Size = new Size(140, 24);
            metodosDePagoToolStripMenuItem.Text = "Metodos de Pago";
            metodosDePagoToolStripMenuItem.Click += metodosDePagoToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.ForeColor = Color.LightGray;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // checkoutToolStripMenuItem
            // 
            checkoutToolStripMenuItem.ForeColor = Color.LightGray;
            checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            checkoutToolStripMenuItem.Size = new Size(63, 20);
            checkoutToolStripMenuItem.Text = "Facturas";
            checkoutToolStripMenuItem.Click += checkoutToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1067, 815);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            // 
            // Menu
            // 
            
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasProductosToolStripMenuItem;
        private ToolStripMenuItem metodosDePagoToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem checkoutToolStripMenuItem;
    }
}