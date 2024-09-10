namespace crud
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            combo_categoria = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            label5 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label2 = new Label();
            txtDesc = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 15, 15);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(601, 433);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gray;
            button2.Location = new Point(14, 440);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 47);
            button2.TabIndex = 12;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Editar_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gray;
            button3.Location = new Point(121, 440);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(114, 47);
            button3.TabIndex = 13;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Borrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(15, 15, 15);
            groupBox1.Controls.Add(combo_categoria);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(265, 500);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // combo_categoria
            // 
            combo_categoria.BackColor = Color.FromArgb(15, 15, 15);
            combo_categoria.FlatStyle = FlatStyle.Flat;
            combo_categoria.ForeColor = Color.Gray;
            combo_categoria.FormattingEnabled = true;
            combo_categoria.Location = new Point(14, 353);
            combo_categoria.Name = "combo_categoria";
            combo_categoria.Size = new Size(194, 28);
            combo_categoria.TabIndex = 24;
            combo_categoria.Text = "Seleccione una opcion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 268);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 23;
            label8.Text = "Categoria:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(14, 389);
            button1.Name = "button1";
            button1.Size = new Size(222, 44);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 292);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 21;
            label5.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(15, 15, 15);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.ForeColor = Color.LightGray;
            txtStock.Location = new Point(14, 316);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(221, 27);
            txtStock.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 213);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 19;
            label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(15, 15, 15);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.LightGray;
            txtPrecio.Location = new Point(14, 237);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(221, 27);
            txtPrecio.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 155);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 17;
            label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(15, 15, 15);
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.ForeColor = Color.LightGray;
            txtMarca.Location = new Point(14, 179);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(221, 27);
            txtMarca.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 96);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 15;
            label2.Text = "Descripción:";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.FromArgb(15, 15, 15);
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.ForeColor = Color.LightGray;
            txtDesc.Location = new Point(14, 120);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(221, 27);
            txtDesc.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(15, 15, 15);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.LightGray;
            txtNombre.Location = new Point(14, 61);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 27);
            txtNombre.TabIndex = 12;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.FromArgb(15, 15, 15);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Gray;
            button6.Location = new Point(287, 452);
            button6.Name = "button6";
            button6.Size = new Size(102, 36);
            button6.TabIndex = 15;
            button6.Text = "Categorias";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(874, 500);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Button button1;
        private Label label5;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtMarca;
        private Label label2;
        private TextBox txtDesc;
        private Label label1;
        private TextBox txtNombre;
        private Button button6;
        private ComboBox combo_categoria;
        private Label label8;
    }
}
