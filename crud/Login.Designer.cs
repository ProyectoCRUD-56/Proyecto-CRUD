namespace Presentacion
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(298, 144);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(298, 221);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(310, 63);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 2;
            label3.Text = "Iniciar Sesion";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(335, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(298, 167);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(199, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(298, 244);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(199, 23);
            txtContraseña.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
    }
}