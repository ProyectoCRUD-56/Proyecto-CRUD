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
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 500);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBox1.Location = new Point(13, 370);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 23);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "Seleccione una opcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 352);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 25;
            label7.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 132);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 24;
            label6.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(12, 150);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(194, 23);
            txtCedula.TabIndex = 23;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GuardarBtn.Location = new Point(12, 455);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(194, 33);
            GuardarBtn.TabIndex = 22;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 295);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 21;
            label5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 313);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(194, 23);
            txtCorreo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 259);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 23);
            txtTelefono.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 17;
            label3.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 203);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 23);
            txtDireccion.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 96);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 14;
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
            // BorrarBtn
            // 
            BorrarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BorrarBtn.Location = new Point(381, 356);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(112, 35);
            BorrarBtn.TabIndex = 17;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = true;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditarBtn.Location = new Point(263, 358);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(112, 35);
            EditarBtn.TabIndex = 16;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            EditarBtn.Click += EditarBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(636, 341);
            dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(499, 356);
            button1.Name = "button1";
            button1.Size = new Size(98, 34);
            button1.TabIndex = 27;
            button1.Text = "Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 500);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(BorrarBtn);
            Controls.Add(EditarBtn);
            Controls.Add(dataGridView1);
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