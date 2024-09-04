namespace Presentacion
{
    partial class Categoria_Producto
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
            button6 = new Button();
            groupBox1 = new GroupBox();
            Guardar = new Button();
            label2 = new Label();
            txtDesc = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            Borrar = new Button();
            Editar = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            Buscar_Nombre = new Button();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            txtResult = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(474, 347);
            button6.Name = "button6";
            button6.Size = new Size(120, 36);
            button6.TabIndex = 20;
            button6.Text = "Medios de Pago";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Guardar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 500);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categoria de Producto";
            // 
            // Guardar
            // 
            Guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Guardar.Location = new Point(12, 461);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(194, 33);
            Guardar.TabIndex = 22;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 15;
            label2.Text = "Descripción:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(12, 96);
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
            // Borrar
            // 
            Borrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Borrar.Location = new Point(356, 347);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(112, 35);
            Borrar.TabIndex = 18;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Editar.Location = new Point(238, 347);
            Editar.Name = "Editar";
            Editar.Size = new Size(112, 35);
            Editar.TabIndex = 17;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(636, 341);
            dataGridView1.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(Buscar_Nombre);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtResult);
            groupBox2.Location = new Point(636, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 144);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Comandos";
            // 
            // Buscar_Nombre
            // 
            Buscar_Nombre.Location = new Point(108, 43);
            Buscar_Nombre.Name = "Buscar_Nombre";
            Buscar_Nombre.Size = new Size(95, 31);
            Buscar_Nombre.TabIndex = 30;
            Buscar_Nombre.Text = "Nombre";
            Buscar_Nombre.UseVisualStyleBackColor = true;
            Buscar_Nombre.Click += Buscar_Nombre_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 31);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 28;
            label7.Text = "ID";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(17, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 23);
            numericUpDown1.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 94);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 26;
            label6.Text = "Resultado";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(17, 112);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(186, 23);
            txtResult.TabIndex = 25;
            // 
            // Categoria_Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 500);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(Borrar);
            Controls.Add(Editar);
            Name = "Categoria_Producto";
            Text = "Categoria_Producto";
            Load += Categoria_Producto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private GroupBox groupBox1;
        private Button Guardar;
        private Label label2;
        private TextBox txtDesc;
        private Label label1;
        private TextBox txtNombre;
        private Button Borrar;
        private Button Editar;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button Buscar_Nombre;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private TextBox txtResult;
    }
}