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
    public partial class Login : Form
    {
        Operaciones op = new Operaciones();
        public Login()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (op.VerificarUsuario(Username.Text, Password.Text) == "0")
            {
                MessageBox.Show("error en usuario o contraseña");
            }
            else
            {
                MessageBox.Show("Bienvenido " + op.VerificarUsuario(Username.Text, Password.Text));
                MainMenu Menu = new MainMenu();
                this.Hide();
                Menu.Show();
            }
        }

        private void CrearNuevo_Click(object sender, EventArgs e)
        {
            Form CreateUser = new CreateUser();
            CreateUser.ShowDialog();
        }
    }
}
