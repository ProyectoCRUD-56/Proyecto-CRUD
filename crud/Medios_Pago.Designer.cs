namespace Presentacion
{
    partial class Medios_Pago
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
            groupBox1 = new GroupBox();
            Guardar = new Button();
            label2 = new Label();
            txtDetalles = new TextBox();
            label1 = new Label();
            txtMetodo = new TextBox();
            Borrar = new Button();
            Editar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(15, 15, 15);
            groupBox1.Controls.Add(Guardar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDetalles);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMetodo);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(265, 667);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medios de Pago";
            // 
            // Guardar
            // 
            Guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Guardar.BackColor = Color.FromArgb(40, 40, 40);
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.ForeColor = Color.Gray;
            Guardar.Location = new Point(14, 615);
            Guardar.Margin = new Padding(3, 4, 3, 4);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(222, 44);
            Guardar.TabIndex = 22;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = false;
            Guardar.Click += Guardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 15;
            label2.Text = "Detalles:";
            // 
            // txtDetalles
            // 
            txtDetalles.BackColor = Color.FromArgb(15, 15, 15);
            txtDetalles.BorderStyle = BorderStyle.FixedSingle;
            txtDetalles.ForeColor = Color.LightGray;
            txtDetalles.Location = new Point(14, 128);
            txtDetalles.Margin = new Padding(3, 4, 3, 4);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(221, 27);
            txtDetalles.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Metodo: ";
            // 
            // txtMetodo
            // 
            txtMetodo.BackColor = Color.FromArgb(15, 15, 15);
            txtMetodo.BorderStyle = BorderStyle.FixedSingle;
            txtMetodo.ForeColor = Color.LightGray;
            txtMetodo.Location = new Point(14, 61);
            txtMetodo.Margin = new Padding(3, 4, 3, 4);
            txtMetodo.Name = "txtMetodo";
            txtMetodo.Size = new Size(221, 27);
            txtMetodo.TabIndex = 12;
            // 
            // Borrar
            // 
            Borrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Borrar.BackColor = Color.FromArgb(40, 40, 40);
            Borrar.FlatStyle = FlatStyle.Flat;
            Borrar.ForeColor = Color.Gray;
            Borrar.Location = new Point(424, 477);
            Borrar.Margin = new Padding(3, 4, 3, 4);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(128, 47);
            Borrar.TabIndex = 18;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = false;
            Borrar.Click += Borrar_Click;
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Editar.BackColor = Color.FromArgb(40, 40, 40);
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.ForeColor = Color.Gray;
            Editar.Location = new Point(290, 477);
            Editar.Margin = new Padding(3, 4, 3, 4);
            Editar.Name = "Editar";
            Editar.Size = new Size(128, 47);
            Editar.TabIndex = 17;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
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
            dataGridView1.Size = new Size(727, 455);
            dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(559, 477);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 47);
            button1.TabIndex = 26;
            button1.Text = "Usuarios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Medios_Pago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(999, 667);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(Borrar);
            Controls.Add(Editar);
            Controls.Add(dataGridView1);
            ForeColor = Color.LightGray;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Medios_Pago";
            Text = "Medios_Pago";
            Load += Medios_Pago_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Guardar;
        private Label label2;
        private TextBox txtDetalles;
        private Label label1;
        private TextBox txtMetodo;
        private Button Borrar;
        private Button Editar;
        private DataGridView dataGridView1;
        private Button button1;
    }
}