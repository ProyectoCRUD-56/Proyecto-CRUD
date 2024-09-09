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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(526, 325);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(12, 330);
            button2.Name = "button2";
            button2.Size = new Size(88, 35);
            button2.TabIndex = 12;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Editar_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(106, 330);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 13;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Borrar_Click;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 375);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // combo_categoria
            // 
            combo_categoria.FormattingEnabled = true;
            combo_categoria.Location = new Point(12, 265);
            combo_categoria.Margin = new Padding(3, 2, 3, 2);
            combo_categoria.Name = "combo_categoria";
            combo_categoria.Size = new Size(170, 23);
            combo_categoria.TabIndex = 24;
            combo_categoria.Text = "Seleccione una opcion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 248);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 23;
            label8.Text = "Categoria:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 292);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(194, 33);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 21;
            label5.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(12, 222);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(194, 23);
            txtStock.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 19;
            label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 178);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(194, 23);
            txtPrecio.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 17;
            label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 134);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(194, 23);
            txtMarca.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 15;
            label2.Text = "Descripción:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(12, 90);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(194, 23);
            txtDesc.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 12;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(238, 338);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(89, 27);
            button6.TabIndex = 15;
            button6.Text = "Categorias";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 375);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
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
