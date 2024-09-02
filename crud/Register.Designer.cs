namespace Presentacion
{
    partial class Register
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
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            lblConfirmarContraseña = new Label();
            txtConfirmarContraseña = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRol = new Label();
            txtRol = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(20, 30);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(142, 20);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(168, 30);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(125, 27);
            txtNombreUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(20, 70);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(86, 20);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(112, 70);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 3;
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Location = new Point(20, 110);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(156, 20);
            lblConfirmarContraseña.TabIndex = 4;
            lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Location = new Point(182, 110);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '*';
            txtConfirmarContraseña.Size = new Size(125, 27);
            txtConfirmarContraseña.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(20, 190);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol:";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(60, 190);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(125, 27);
            txtRol.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(20, 235);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(txtRol);
            Controls.Add(lblRol);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(lblConfirmarContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Label lblConfirmarContraseña;
        private TextBox txtConfirmarContraseña;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRol;
        private TextBox txtRol;
        private Button btnRegistrar;
    }
}