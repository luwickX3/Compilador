using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSO2
{
    public partial class CreateUser : Form
    {
        Operaciones op = new Operaciones();
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            if (op.AgregarUsuario(User.Text, Pass.Text, Nom.Text, Tel.Text, Correo.Text) == "1")
            {
                MessageBox.Show("Usuario creado con exito");
                User.Text = "";
                Pass.Text = "";
                Nom.Text = "";
                Tel.Text = "";
                Correo.Text = "";
            }
            else 
            {
                MessageBox.Show("Error al crear usuario, cheque los parametros");
            }
        }
    }
}
