namespace ProyectoFinalSO2
{
    partial class CreateUser
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
            this.User = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(114, 6);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 20);
            this.User.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(58, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 35);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(64, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Contraseña:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 61);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre:";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(12, 87);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(52, 13);
            this.Telefono.TabIndex = 4;
            this.Telefono.Text = "Telefono:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 113);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(96, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "Correo electronico:";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(114, 32);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 6;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(114, 58);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 7;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(114, 84);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(100, 20);
            this.Tel.TabIndex = 8;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(114, 110);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(100, 20);
            this.Correo.TabIndex = 9;
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(15, 136);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(199, 23);
            this.Crear.TabIndex = 10;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 166);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.User);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Button Crear;
    }
}