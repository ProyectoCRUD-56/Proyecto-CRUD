﻿namespace Presentacion
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Gray;
            button6.Location = new Point(474, 346);
            button6.Name = "button6";
            button6.Size = new Size(120, 36);
            button6.TabIndex = 20;
            button6.Text = "Medios de Pago";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(15, 15, 15);
            groupBox1.Controls.Add(Guardar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 393);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categoria de Producto";
            // 
            // Guardar
            // 
            Guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.ForeColor = Color.Gray;
            Guardar.Location = new Point(12, 354);
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
            txtDesc.BackColor = Color.FromArgb(15, 15, 15);
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.ForeColor = Color.LightGray;
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
            txtNombre.BackColor = Color.FromArgb(15, 15, 15);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.LightGray;
            txtNombre.Location = new Point(12, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 12;
            // 
            // Borrar
            // 
            Borrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Borrar.FlatStyle = FlatStyle.Flat;
            Borrar.ForeColor = Color.Gray;
            Borrar.Location = new Point(356, 346);
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
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.ForeColor = Color.Gray;
            Editar.Location = new Point(238, 346);
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
            dataGridView1.BackgroundColor = Color.FromArgb(15, 15, 15);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(524, 340);
            dataGridView1.TabIndex = 21;
            // 
            // Categoria_Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(765, 393);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(Borrar);
            Controls.Add(Editar);
            ForeColor = Color.LightGray;
            Name = "Categoria_Producto";
            Text = "Categoria_Producto";
            Load += Categoria_Producto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}