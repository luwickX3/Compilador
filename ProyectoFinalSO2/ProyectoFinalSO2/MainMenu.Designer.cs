namespace ProyectoFinalSO2
{
    partial class MainMenu
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
            this.Lenguajes = new System.Windows.Forms.ComboBox();
            this.SeleccionarLenguaje = new System.Windows.Forms.Label();
            this.CargarArchivo = new System.Windows.Forms.Button();
            this.Compilar = new System.Windows.Forms.Button();
            this.Filtrar = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Abrir = new System.Windows.Forms.OpenFileDialog();
            this.ListBoxEntrada = new System.Windows.Forms.ListBox();
            this.ArchivoDeEntrada = new System.Windows.Forms.Label();
            this.ListBoxSalida = new System.Windows.Forms.ListBox();
            this.ListBoxPalabrasReservadas = new System.Windows.Forms.ListBox();
            this.ListBoxIDS = new System.Windows.Forms.ListBox();
            this.ListBoxEnteras = new System.Windows.Forms.ListBox();
            this.ListBoxReales = new System.Windows.Forms.ListBox();
            this.ListBoxStrings = new System.Windows.Forms.ListBox();
            this.ArchivoDeSalida = new System.Windows.Forms.Label();
            this.PalabrasReservadas = new System.Windows.Forms.Label();
            this.IDS = new System.Windows.Forms.Label();
            this.CtesEnteras = new System.Windows.Forms.Label();
            this.CtesReales = new System.Windows.Forms.Label();
            this.CtesString = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lenguajes
            // 
            this.Lenguajes.FormattingEnabled = true;
            this.Lenguajes.Location = new System.Drawing.Point(127, 12);
            this.Lenguajes.Name = "Lenguajes";
            this.Lenguajes.Size = new System.Drawing.Size(121, 21);
            this.Lenguajes.TabIndex = 0;
            // 
            // SeleccionarLenguaje
            // 
            this.SeleccionarLenguaje.AutoSize = true;
            this.SeleccionarLenguaje.Location = new System.Drawing.Point(12, 15);
            this.SeleccionarLenguaje.Name = "SeleccionarLenguaje";
            this.SeleccionarLenguaje.Size = new System.Drawing.Size(109, 13);
            this.SeleccionarLenguaje.TabIndex = 1;
            this.SeleccionarLenguaje.Text = "Seleccionar lenguaje:";
            // 
            // CargarArchivo
            // 
            this.CargarArchivo.Location = new System.Drawing.Point(254, 10);
            this.CargarArchivo.Name = "CargarArchivo";
            this.CargarArchivo.Size = new System.Drawing.Size(85, 23);
            this.CargarArchivo.TabIndex = 2;
            this.CargarArchivo.Text = "Cargar archivo";
            this.CargarArchivo.UseVisualStyleBackColor = true;
            this.CargarArchivo.Click += new System.EventHandler(this.CargarArchivo_Click);
            // 
            // Compilar
            // 
            this.Compilar.Location = new System.Drawing.Point(345, 10);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(75, 23);
            this.Compilar.TabIndex = 3;
            this.Compilar.Text = "Compilar";
            this.Compilar.UseVisualStyleBackColor = true;
            this.Compilar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // Filtrar
            // 
            this.Filtrar.Location = new System.Drawing.Point(426, 10);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(75, 23);
            this.Filtrar.TabIndex = 4;
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 131);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(799, 277);
            this.DataGridView1.TabIndex = 5;
            // 
            // Abrir
            // 
            this.Abrir.Filter = "ArchivosTxt|*.txt";
            // 
            // ListBoxEntrada
            // 
            this.ListBoxEntrada.FormattingEnabled = true;
            this.ListBoxEntrada.Location = new System.Drawing.Point(12, 69);
            this.ListBoxEntrada.Name = "ListBoxEntrada";
            this.ListBoxEntrada.Size = new System.Drawing.Size(109, 56);
            this.ListBoxEntrada.TabIndex = 6;
            // 
            // ArchivoDeEntrada
            // 
            this.ArchivoDeEntrada.AutoSize = true;
            this.ArchivoDeEntrada.Location = new System.Drawing.Point(12, 44);
            this.ArchivoDeEntrada.Name = "ArchivoDeEntrada";
            this.ArchivoDeEntrada.Size = new System.Drawing.Size(100, 13);
            this.ArchivoDeEntrada.TabIndex = 7;
            this.ArchivoDeEntrada.Text = "Archivo de entrada:";
            // 
            // ListBoxSalida
            // 
            this.ListBoxSalida.FormattingEnabled = true;
            this.ListBoxSalida.Location = new System.Drawing.Point(127, 69);
            this.ListBoxSalida.Name = "ListBoxSalida";
            this.ListBoxSalida.Size = new System.Drawing.Size(109, 56);
            this.ListBoxSalida.TabIndex = 8;
            // 
            // ListBoxPalabrasReservadas
            // 
            this.ListBoxPalabrasReservadas.FormattingEnabled = true;
            this.ListBoxPalabrasReservadas.Location = new System.Drawing.Point(242, 69);
            this.ListBoxPalabrasReservadas.Name = "ListBoxPalabrasReservadas";
            this.ListBoxPalabrasReservadas.Size = new System.Drawing.Size(109, 56);
            this.ListBoxPalabrasReservadas.TabIndex = 9;
            // 
            // ListBoxIDS
            // 
            this.ListBoxIDS.FormattingEnabled = true;
            this.ListBoxIDS.Location = new System.Drawing.Point(357, 69);
            this.ListBoxIDS.Name = "ListBoxIDS";
            this.ListBoxIDS.Size = new System.Drawing.Size(109, 56);
            this.ListBoxIDS.TabIndex = 10;
            // 
            // ListBoxEnteras
            // 
            this.ListBoxEnteras.FormattingEnabled = true;
            this.ListBoxEnteras.Location = new System.Drawing.Point(472, 69);
            this.ListBoxEnteras.Name = "ListBoxEnteras";
            this.ListBoxEnteras.Size = new System.Drawing.Size(109, 56);
            this.ListBoxEnteras.TabIndex = 11;
            // 
            // ListBoxReales
            // 
            this.ListBoxReales.FormattingEnabled = true;
            this.ListBoxReales.Location = new System.Drawing.Point(587, 69);
            this.ListBoxReales.Name = "ListBoxReales";
            this.ListBoxReales.Size = new System.Drawing.Size(109, 56);
            this.ListBoxReales.TabIndex = 12;
            // 
            // ListBoxStrings
            // 
            this.ListBoxStrings.FormattingEnabled = true;
            this.ListBoxStrings.Location = new System.Drawing.Point(702, 69);
            this.ListBoxStrings.Name = "ListBoxStrings";
            this.ListBoxStrings.Size = new System.Drawing.Size(109, 56);
            this.ListBoxStrings.TabIndex = 13;
            // 
            // ArchivoDeSalida
            // 
            this.ArchivoDeSalida.AutoSize = true;
            this.ArchivoDeSalida.Location = new System.Drawing.Point(124, 44);
            this.ArchivoDeSalida.Name = "ArchivoDeSalida";
            this.ArchivoDeSalida.Size = new System.Drawing.Size(91, 13);
            this.ArchivoDeSalida.TabIndex = 14;
            this.ArchivoDeSalida.Text = "Archivo de salida:";
            // 
            // PalabrasReservadas
            // 
            this.PalabrasReservadas.AutoSize = true;
            this.PalabrasReservadas.Location = new System.Drawing.Point(239, 44);
            this.PalabrasReservadas.Name = "PalabrasReservadas";
            this.PalabrasReservadas.Size = new System.Drawing.Size(106, 13);
            this.PalabrasReservadas.TabIndex = 15;
            this.PalabrasReservadas.Text = "Palabras reservadas:";
            // 
            // IDS
            // 
            this.IDS.AutoSize = true;
            this.IDS.Location = new System.Drawing.Point(354, 44);
            this.IDS.Name = "IDS";
            this.IDS.Size = new System.Drawing.Size(26, 13);
            this.IDS.TabIndex = 16;
            this.IDS.Text = "Id\'s:";
            // 
            // CtesEnteras
            // 
            this.CtesEnteras.AutoSize = true;
            this.CtesEnteras.Location = new System.Drawing.Point(469, 44);
            this.CtesEnteras.Name = "CtesEnteras";
            this.CtesEnteras.Size = new System.Drawing.Size(46, 13);
            this.CtesEnteras.TabIndex = 17;
            this.CtesEnteras.Text = "Enteras:";
            // 
            // CtesReales
            // 
            this.CtesReales.AutoSize = true;
            this.CtesReales.Location = new System.Drawing.Point(584, 44);
            this.CtesReales.Name = "CtesReales";
            this.CtesReales.Size = new System.Drawing.Size(43, 13);
            this.CtesReales.TabIndex = 18;
            this.CtesReales.Text = "Reales:";
            // 
            // CtesString
            // 
            this.CtesString.AutoSize = true;
            this.CtesString.Location = new System.Drawing.Point(699, 44);
            this.CtesString.Name = "CtesString";
            this.CtesString.Size = new System.Drawing.Size(42, 13);
            this.CtesString.TabIndex = 19;
            this.CtesString.Text = "Strings:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 420);
            this.Controls.Add(this.CtesString);
            this.Controls.Add(this.CtesReales);
            this.Controls.Add(this.CtesEnteras);
            this.Controls.Add(this.IDS);
            this.Controls.Add(this.PalabrasReservadas);
            this.Controls.Add(this.ArchivoDeSalida);
            this.Controls.Add(this.ListBoxStrings);
            this.Controls.Add(this.ListBoxReales);
            this.Controls.Add(this.ListBoxEnteras);
            this.Controls.Add(this.ListBoxIDS);
            this.Controls.Add(this.ListBoxPalabrasReservadas);
            this.Controls.Add(this.ListBoxSalida);
            this.Controls.Add(this.ArchivoDeEntrada);
            this.Controls.Add(this.ListBoxEntrada);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.Compilar);
            this.Controls.Add(this.CargarArchivo);
            this.Controls.Add(this.SeleccionarLenguaje);
            this.Controls.Add(this.Lenguajes);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cerrado);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Lenguajes;
        private System.Windows.Forms.Label SeleccionarLenguaje;
        private System.Windows.Forms.Button CargarArchivo;
        private System.Windows.Forms.Button Compilar;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.OpenFileDialog Abrir;
        private System.Windows.Forms.ListBox ListBoxEntrada;
        private System.Windows.Forms.Label ArchivoDeEntrada;
        private System.Windows.Forms.ListBox ListBoxSalida;
        private System.Windows.Forms.ListBox ListBoxPalabrasReservadas;
        private System.Windows.Forms.ListBox ListBoxIDS;
        private System.Windows.Forms.ListBox ListBoxEnteras;
        private System.Windows.Forms.ListBox ListBoxReales;
        private System.Windows.Forms.ListBox ListBoxStrings;
        private System.Windows.Forms.Label ArchivoDeSalida;
        private System.Windows.Forms.Label PalabrasReservadas;
        private System.Windows.Forms.Label IDS;
        private System.Windows.Forms.Label CtesEnteras;
        private System.Windows.Forms.Label CtesReales;
        private System.Windows.Forms.Label CtesString;
    }
}