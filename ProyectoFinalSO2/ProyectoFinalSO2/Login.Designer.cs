namespace ProyectoFinalSO2
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.CrearNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(96, 36);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '@';
            this.Password.Size = new System.Drawing.Size(111, 20);
            this.Password.TabIndex = 0;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(12, 15);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(46, 13);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario:";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(15, 62);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 2;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(12, 39);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(64, 13);
            this.Contraseña.TabIndex = 3;
            this.Contraseña.Text = "Contraseña:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(96, 12);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(111, 20);
            this.Username.TabIndex = 4;
            // 
            // CrearNuevo
            // 
            this.CrearNuevo.Location = new System.Drawing.Point(96, 62);
            this.CrearNuevo.Name = "CrearNuevo";
            this.CrearNuevo.Size = new System.Drawing.Size(111, 23);
            this.CrearNuevo.TabIndex = 5;
            this.CrearNuevo.Text = "Crear nuevo usuario";
            this.CrearNuevo.UseVisualStyleBackColor = true;
            this.CrearNuevo.Click += new System.EventHandler(this.CrearNuevo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 95);
            this.Controls.Add(this.CrearNuevo);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Password);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button CrearNuevo;
    }
}

