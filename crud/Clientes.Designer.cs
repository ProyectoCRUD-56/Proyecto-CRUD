namespace Presentacion
{
    partial class Clientes
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
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtCedula = new TextBox();
            GuardarBtn = new Button();
            label5 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            BorrarBtn = new Button();
            EditarBtn = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(15, 15, 15);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(GuardarBtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.Gray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(265, 667);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(15, 15, 15);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBox1.Location = new Point(15, 493);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 28);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "Seleccione una opción";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 469);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 25;
            label7.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 176);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 24;
            label6.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(15, 15, 15);
            txtCedula.BorderStyle = BorderStyle.FixedSingle;
            txtCedula.ForeColor = Color.LightGray;
            txtCedula.Location = new Point(14, 200);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(221, 27);
            txtCedula.TabIndex = 23;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GuardarBtn.BackColor = Color.FromArgb(40, 40, 40);
            GuardarBtn.FlatStyle = FlatStyle.Flat;
            GuardarBtn.ForeColor = Color.Gray;
            GuardarBtn.Location = new Point(14, 607);
            GuardarBtn.Margin = new Padding(3, 4, 3, 4);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(222, 44);
            GuardarBtn.TabIndex = 22;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = false;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 393);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 21;
            label5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(15, 15, 15);
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.LightGray;
            txtCorreo.Location = new Point(14, 417);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 27);
            txtCorreo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 321);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 19;
            label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(15, 15, 15);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.LightGray;
            txtTelefono.Location = new Point(14, 345);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(221, 27);
            txtTelefono.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 247);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 17;
            label3.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(15, 15, 15);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = Color.LightGray;
            txtDireccion.Location = new Point(14, 271);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(221, 27);
            txtDireccion.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 15;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(15, 15, 15);
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.LightGray;
            txtApellido.Location = new Point(14, 128);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(221, 27);
            txtApellido.TabIndex = 14;
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
            // BorrarBtn
            // 
            BorrarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BorrarBtn.BackColor = Color.FromArgb(40, 40, 40);
            BorrarBtn.FlatStyle = FlatStyle.Flat;
            BorrarBtn.ForeColor = Color.Gray;
            BorrarBtn.Location = new Point(435, 475);
            BorrarBtn.Margin = new Padding(3, 4, 3, 4);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(128, 47);
            BorrarBtn.TabIndex = 17;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = false;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditarBtn.BackColor = Color.FromArgb(40, 40, 40);
            EditarBtn.FlatStyle = FlatStyle.Flat;
            EditarBtn.ForeColor = Color.Gray;
            EditarBtn.Location = new Point(297, 475);
            EditarBtn.Margin = new Padding(3, 4, 3, 4);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(132, 47);
            EditarBtn.TabIndex = 16;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = false;
            EditarBtn.Click += EditarBtn_Click;
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
            dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(570, 475);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 47);
            button1.TabIndex = 27;
            button1.Text = "Producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(999, 667);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(BorrarBtn);
            Controls.Add(EditarBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button GuardarBtn;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private Button BorrarBtn;
        private Button EditarBtn;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox txtCedula;
        private ComboBox comboBox1;
        private Label label7;
        private Button button1;
    }
}