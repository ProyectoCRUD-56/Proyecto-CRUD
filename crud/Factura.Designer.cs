namespace Presentacion
{
    partial class Factura
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
            button1 = new Button();
            button2 = new Button();
            cbMetodosPago = new ComboBox();
            txtClientes = new TextBox();
            txtProductos = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            NumCantidad = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Tarifa = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(668, 116);
            button1.Name = "button1";
            button1.Size = new Size(102, 41);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(687, 401);
            button2.Name = "button2";
            button2.Size = new Size(101, 37);
            button2.TabIndex = 1;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbMetodosPago
            // 
            cbMetodosPago.FormattingEnabled = true;
            cbMetodosPago.Location = new Point(6, 84);
            cbMetodosPago.Name = "cbMetodosPago";
            cbMetodosPago.Size = new Size(379, 23);
            cbMetodosPago.TabIndex = 2;
            // 
            // txtClientes
            // 
            txtClientes.Location = new Point(6, 35);
            txtClientes.Name = "txtClientes";
            txtClientes.PlaceholderText = "Cliente";
            txtClientes.Size = new Size(379, 23);
            txtClientes.TabIndex = 3;
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(6, 133);
            txtProductos.Name = "txtProductos";
            txtProductos.PlaceholderText = "Producto";
            txtProductos.Size = new Size(379, 23);
            txtProductos.TabIndex = 4;
            txtProductos.Leave += txtProductos_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(438, 115);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Cantidad";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(643, 375);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Total: ";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(687, 372);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            // 
            // NumCantidad
            // 
            NumCantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NumCantidad.Location = new Point(438, 133);
            NumCantidad.Name = "NumCantidad";
            NumCantidad.Size = new Size(55, 23);
            NumCantidad.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Tarifa, SubTotal });
            dataGridView1.Location = new Point(18, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(619, 254);
            dataGridView1.TabIndex = 11;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Tarifa
            // 
            Tarifa.HeaderText = "Tarifa";
            Tarifa.Name = "Tarifa";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtClientes);
            groupBox1.Controls.Add(cbMetodosPago);
            groupBox1.Controls.Add(NumCantidad);
            groupBox1.Controls.Add(txtProductos);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 163);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Factura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 17);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 14;
            label5.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 13;
            label2.Text = "Producto:";
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(499, 133);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 11;
            label4.Text = "Metodo de Pago:";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(button2);
            Name = "Factura";
            Text = "Factura";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)NumCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox cbMetodosPago;
        private TextBox txtClientes;
        private TextBox txtProductos;
        private Label label1;
        private Label label3;
        private TextBox txtTotal;
        private NumericUpDown NumCantidad;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private Label label2;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Tarifa;
        private DataGridViewTextBoxColumn SubTotal;
    }
}