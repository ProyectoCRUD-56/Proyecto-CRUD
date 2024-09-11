namespace Presentacion
{
    partial class Usuarios
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
            label5 = new Label();
            txtApellido = new TextBox();
            CbRol = new ComboBox();
            Guardar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            Borrar = new Button();
            Editar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label5 = new Label();
            txtApellido = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(15, 15, 15);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(CbRol);
            groupBox1.Controls.Add(Guardar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(265, 667);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 109);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 25;
            label5.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(15, 15, 15);
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.LightGray;
            txtApellido.Location = new Point(14, 133);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(221, 27);
            txtApellido.TabIndex = 24;
            // 
            // CbRol
            // 
            CbRol.BackColor = Color.FromArgb(15, 15, 15);
            CbRol.FlatStyle = FlatStyle.Flat;
            CbRol.ForeColor = Color.Gray;
            CbRol.FormattingEnabled = true;
            CbRol.Items.AddRange(new object[] { "Administrador", "Empleado" });
            CbRol.Location = new Point(14, 351);
            CbRol.Margin = new Padding(3, 4, 3, 4);
            CbRol.Name = "CbRol";
            CbRol.Size = new Size(221, 28);
            CbRol.TabIndex = 23;
            CbRol.Tag = "";
            CbRol.Text = "Seleccione una opcion:";
            // 
            // Guardar
            // 
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.ForeColor = Color.Gray;
            Guardar.Location = new Point(14, 615);
            Guardar.Margin = new Padding(3, 4, 3, 4);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(222, 44);
            Guardar.TabIndex = 22;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 327);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 19;
            label4.Text = "Rol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 252);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 17;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.LightGray;
            txtEmail.Location = new Point(14, 276);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 27);
            txtEmail.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 181);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 15;
            label2.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.ForeColor = Color.LightGray;
            txtContraseña.Location = new Point(14, 205);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(221, 27);
            txtContraseña.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 13;
            label1.Text = "Usuario:";
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
            // Borrar
            // 
            Borrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Borrar.FlatStyle = FlatStyle.Flat;
            Borrar.ForeColor = Color.Gray;
            Borrar.Location = new Point(435, 475);
            Borrar.Margin = new Padding(3, 4, 3, 4);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(128, 47);
            Borrar.TabIndex = 18;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.ForeColor = Color.Gray;
            Editar.Location = new Point(301, 475);
            Editar.Margin = new Padding(3, 4, 3, 4);
            Editar.Name = "Editar";
            Editar.Size = new Size(128, 47);
            Editar.TabIndex = 17;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
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
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(570, 475);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 47);
            button1.TabIndex = 27;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 82);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 25;
            label5.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 100);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 24;
            // 
            // Usuarios
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button Guardar;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtContraseña;
        private Label label1;
        private TextBox txtNombre;
        private Button Borrar;
        private Button Editar;
        private DataGridView dataGridView1;
        private ComboBox CbRol;
        private Button button1;
        private Label label5;
        private TextBox txtApellido;
    }
}