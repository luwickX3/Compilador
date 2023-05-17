using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Security;
using static System.Net.WebRequestMethods;

namespace ProyectoFinalSO2
{
    public partial class MainMenu : Form
    {
        bool PalabraReservada;
        bool Encontro;
        int ValueCaracter = 0;
        int columna = 0;
        int estado = 0;
        int direccion = 0;
        String Caracter;
        String ArchivoEntrada = "";
        String ArchivoSalida = "";
        String wlinea;
        String wsalida;
        String Token = "";
        int Posicion = 0;
        String DireccionMatrices = "C:\\Users\\Rodrigo Alexis\\source\\repos\\ProyectoFinalSO2\\ProyectoFinalSO2\\Matrices y palabras reservadas\\Matrices";
        String DireccionPalabrasReservadas = "C:\\Users\\Rodrigo Alexis\\source\\repos\\ProyectoFinalSO2\\ProyectoFinalSO2\\Matrices y palabras reservadas\\PalabrasRecervadas";
        int[,] Matriz = new int[40, 40];

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Matriz[0, 0] = 1;
            Matriz[0, 1] = 3;
            Matriz[0, 2] = 4;
            Matriz[0, 3] = 6;
            Matriz[0, 4] = 7;
            Matriz[0, 5] = 107;
            Matriz[0, 6] = 105;
            Matriz[0, 7] = 106;
            Matriz[0, 8] = 10;
            Matriz[0, 9] = 11;
            Matriz[0, 10] = 114;
            Matriz[0, 11] = 115;
            Matriz[0, 12] = 116;
            Matriz[0, 13] = 117;
            Matriz[0, 14] = 118;
            Matriz[0, 15] = 119;
            Matriz[0, 16] = 120;
            Matriz[0, 17] = 0;
            Matriz[0, 18] = 121;
            Matriz[0, 19] = 300;

            Matriz[1, 0] = 1;
            Matriz[1, 1] = 1;
            Matriz[1, 2] = 100;
            Matriz[1, 3] = 100;
            Matriz[1, 4] = 100;
            Matriz[1, 5] = 100;
            Matriz[1, 6] = 100;
            Matriz[1, 7] = 100;
            Matriz[1, 8] = 100;
            Matriz[1, 9] = 100;
            Matriz[1, 10] = 100;
            Matriz[1, 11] = 100;
            Matriz[1, 12] = 100;
            Matriz[1, 13] = 100;
            Matriz[1, 14] = 100;
            Matriz[1, 15] = 100;
            Matriz[1, 16] = 100;
            Matriz[1, 17] = 100;
            Matriz[1, 18] = 100;
            Matriz[1, 19] = 2;

            Matriz[2, 0] = 1;
            Matriz[2, 1] = 1;
            Matriz[2, 2] = 300;
            Matriz[2, 3] = 300;
            Matriz[2, 4] = 300;
            Matriz[2, 5] = 300;
            Matriz[2, 6] = 300;
            Matriz[2, 7] = 300;
            Matriz[2, 8] = 300;
            Matriz[2, 9] = 300;
            Matriz[2, 10] = 300;
            Matriz[2, 11] = 300;
            Matriz[2, 12] = 300;
            Matriz[2, 13] = 300;
            Matriz[2, 14] = 300;
            Matriz[2, 15] = 300;
            Matriz[2, 16] = 300;
            Matriz[2, 17] = 300;
            Matriz[2, 18] = 300;
            Matriz[2, 19] = 300;

            Matriz[3, 0] = 101;
            Matriz[3, 1] = 3;
            Matriz[3, 2] = 4;
            Matriz[3, 3] = 101;
            Matriz[3, 4] = 101;
            Matriz[3, 5] = 101;
            Matriz[3, 6] = 101;
            Matriz[3, 7] = 101;
            Matriz[3, 8] = 101;
            Matriz[3, 9] = 101;
            Matriz[3, 10] = 101;
            Matriz[3, 11] = 101;
            Matriz[3, 12] = 101;
            Matriz[3, 13] = 101;
            Matriz[3, 14] = 101;
            Matriz[3, 15] = 101;
            Matriz[3, 16] = 101;
            Matriz[3, 17] = 101;
            Matriz[3, 18] = 101;
            Matriz[3, 19] = 101;

            Matriz[4, 0] = 302;
            Matriz[4, 1] = 5;
            Matriz[4, 2] = 302;
            Matriz[4, 3] = 302;
            Matriz[4, 4] = 302;
            Matriz[4, 5] = 302;
            Matriz[4, 6] = 302;
            Matriz[4, 7] = 302;
            Matriz[4, 8] = 302;
            Matriz[4, 9] = 302;
            Matriz[4, 10] = 302;
            Matriz[4, 11] = 302;
            Matriz[4, 12] = 302;
            Matriz[4, 13] = 302;
            Matriz[4, 14] = 302;
            Matriz[4, 15] = 302;
            Matriz[4, 16] = 302;
            Matriz[4, 17] = 302;
            Matriz[4, 18] = 302;
            Matriz[4, 19] = 302;

            Matriz[5, 0] = 102;
            Matriz[5, 1] = 5;
            Matriz[5, 2] = 102;
            Matriz[5, 3] = 102;
            Matriz[5, 4] = 102;
            Matriz[5, 5] = 102;
            Matriz[5, 6] = 102;
            Matriz[5, 7] = 102;
            Matriz[5, 8] = 102;
            Matriz[5, 9] = 102;
            Matriz[5, 10] = 102;
            Matriz[5, 11] = 102;
            Matriz[5, 12] = 102;
            Matriz[5, 13] = 102;
            Matriz[5, 14] = 102;
            Matriz[5, 15] = 102;
            Matriz[5, 16] = 102;
            Matriz[5, 17] = 102;
            Matriz[5, 18] = 102;
            Matriz[5, 19] = 102;

            Matriz[6, 0] = 6;
            Matriz[6, 1] = 6;
            Matriz[6, 2] = 6;
            Matriz[6, 3] = 103;
            Matriz[6, 4] = 6;
            Matriz[6, 5] = 6;
            Matriz[6, 6] = 6;
            Matriz[6, 7] = 6;
            Matriz[6, 8] = 6;
            Matriz[6, 9] = 6;
            Matriz[6, 10] = 6;
            Matriz[6, 11] = 6;
            Matriz[6, 12] = 6;
            Matriz[6, 13] = 6;
            Matriz[6, 14] = 6;
            Matriz[6, 15] = 6;
            Matriz[6, 16] = 6;
            Matriz[6, 17] = 6;
            Matriz[6, 18] = 6;
            Matriz[6, 19] = 6;

            Matriz[7, 0] = 108;
            Matriz[7, 1] = 108;
            Matriz[7, 2] = 108;
            Matriz[7, 3] = 108;
            Matriz[7, 4] = 108;
            Matriz[7, 5] = 8;
            Matriz[7, 6] = 108;
            Matriz[7, 7] = 108;
            Matriz[7, 8] = 108;
            Matriz[7, 9] = 108;
            Matriz[7, 10] = 108;
            Matriz[7, 11] = 108;
            Matriz[7, 12] = 108;
            Matriz[7, 13] = 108;
            Matriz[7, 14] = 108;
            Matriz[7, 15] = 108;
            Matriz[7, 16] = 108;
            Matriz[7, 17] = 108;
            Matriz[7, 18] = 108;
            Matriz[7, 19] = 108;

            Matriz[8, 0] = 8;
            Matriz[8, 1] = 8;
            Matriz[8, 2] = 8;
            Matriz[8, 3] = 8;
            Matriz[8, 4] = 8;
            Matriz[8, 5] = 9;
            Matriz[8, 6] = 8;
            Matriz[8, 7] = 8;
            Matriz[8, 8] = 8;
            Matriz[8, 9] = 8;
            Matriz[8, 10] = 8;
            Matriz[8, 11] = 8;
            Matriz[8, 12] = 8;
            Matriz[8, 13] = 8;
            Matriz[8, 14] = 8;
            Matriz[8, 15] = 8;
            Matriz[8, 16] = 8;
            Matriz[8, 17] = 8;
            Matriz[8, 18] = 8;
            Matriz[8, 19] = 8;

            Matriz[9, 0] = 304;
            Matriz[9, 1] = 304;
            Matriz[9, 2] = 304;
            Matriz[9, 3] = 304;
            Matriz[9, 4] = 104;
            Matriz[9, 5] = 304;
            Matriz[9, 6] = 304;
            Matriz[9, 7] = 304;
            Matriz[9, 8] = 304;
            Matriz[9, 9] = 304;
            Matriz[9, 10] = 304;
            Matriz[9, 11] = 304;
            Matriz[9, 12] = 304;
            Matriz[9, 13] = 304;
            Matriz[9, 14] = 304;
            Matriz[9, 15] = 304;
            Matriz[9, 16] = 304;
            Matriz[9, 17] = 304;
            Matriz[9, 18] = 304;
            Matriz[9, 19] = 304;

            Matriz[10, 0] = 111;
            Matriz[10, 1] = 111;
            Matriz[10, 2] = 111;
            Matriz[10, 3] = 111;
            Matriz[10, 4] = 111;
            Matriz[10, 5] = 111;
            Matriz[10, 6] = 111;
            Matriz[10, 7] = 111;
            Matriz[10, 8] = 111;
            Matriz[10, 9] = 109;
            Matriz[10, 10] = 111;
            Matriz[10, 11] = 111;
            Matriz[10, 12] = 111;
            Matriz[10, 13] = 111;
            Matriz[10, 14] = 111;
            Matriz[10, 15] = 111;
            Matriz[10, 16] = 111;
            Matriz[10, 17] = 111;
            Matriz[10, 18] = 110;
            Matriz[10, 19] = 111;

            Matriz[11, 0] = 113;
            Matriz[11, 1] = 113;
            Matriz[11, 2] = 113;
            Matriz[11, 3] = 113;
            Matriz[11, 4] = 113;
            Matriz[11, 5] = 113;
            Matriz[11, 6] = 113;
            Matriz[11, 7] = 113;
            Matriz[11, 8] = 113;
            Matriz[11, 9] = 113;
            Matriz[11, 10] = 113;
            Matriz[11, 11] = 113;
            Matriz[11, 12] = 113;
            Matriz[11, 13] = 113;
            Matriz[11, 14] = 113;
            Matriz[11, 15] = 113;
            Matriz[11, 16] = 113;
            Matriz[11, 17] = 113;
            Matriz[11, 18] = 112;
            Matriz[11, 19] = 113;
        }
        private void CargarArchivo_Click(object sender, EventArgs e)
        {
            Abrir.ShowDialog();
            ArchivoEntrada = Abrir.FileName;
            System.IO.StreamReader fileReader = new System.IO.StreamReader;
            fileReader = My.Computer.FileSystem.OpenTextFileReader(archivo);
            String stringReader;
            while (!(fileReader.EndOfStream))
            {
                stringReader = fileReader.ReadLine();
                ListBoxEntrada.Items.Add(stringReader);
            }
        }

        private void Cerrado(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

            //StreamReader Lector = new StreamReader(ArchivoEntrada);
            //String Linea;
            //Linea = Lector.ReadLine();
            //while (Linea != null)
            //{
            //    ListBoxEntrada.Items.Add(Linea);
            //    Linea = Lector.ReadLine();
            //    Console.WriteLine(Linea);
            //}
        private void Compilar_Click(object sender, EventArgs e)
        {
            int Renglon = 0;
            while (Renglon < ListBoxEntrada.Items.Count)
            {
                ListBoxEntrada.SelectedIndex = Renglon;
                wlinea = ListBoxEntrada.Text;
                BuscaTokens();
                Renglon++;
            }
        }

        protected void BuscaTokens()
        {
            estado = 0;
            Token = "";
            Posicion = 1;
            while (Posicion <= wlinea.Length())
            {
                Caracter = wlinea.Substring(0, 1);
                MessageBox.Show(Caracter);
                foreach (char c in Caracter)
                    ValueCaracter = System.Convert.ToInt32(c);
                CalcularColumna();
                estado = Matriz[estado, columna];
                if (estado >= 100)
                {
                    if (Token.Length() >= 0)
                    {
                        ReconocerToken();
                    }
                    estado = 0;
                    Token = "";
                    ListBoxSalida.Items.Add(Token);
                }
                else
                {
                    if (estado != 0)
                    {
                        Token = Token + Caracter;
                    }
                }
                Posicion = Posicion++;
            }
            if (Token.Length() > 0)
            {
                Caracter = " ";
                CalcularColumna();
                estado = Matriz[estado, columna];
                ReconocerToken();
            }
        }

        protected void CalcularColumna()
        {
            if (ValueCaracter >= System.Convert.ToInt32("A") && ValueCaracter <= System.Convert.ToInt32("Z"))
            {
                columna = 0;
            }
            else if (ValueCaracter >= System.Convert.ToInt32("a") && ValueCaracter <= System.Convert.ToInt32("z"))
            {
                columna = 0;
            }
            else if (ValueCaracter >= System.Convert.ToInt32("0") && ValueCaracter <= System.Convert.ToInt32("9"))
            {
                columna = 1;
            }
            else if (ValueCaracter == System.Convert.ToInt32("."))
            {
                columna = 2;
            }
            else if (ValueCaracter == System.Convert.ToInt32("\""))
            {
                columna = 3;
            }
            else if (ValueCaracter == System.Convert.ToInt32("/"))
            {
                columna = 4;
            }
            else if (ValueCaracter == System.Convert.ToInt32("*"))
            {
                columna = 5;
            }
            else if (ValueCaracter == System.Convert.ToInt32("+"))
            {
                columna = 6;
            }
            else if (ValueCaracter == System.Convert.ToInt32("-"))
            {
                columna = 7;
            }
            else if (ValueCaracter == System.Convert.ToInt32("<"))
            {
                columna = 8;
            }
            else if (ValueCaracter == System.Convert.ToInt32(">"))
            {
                columna = 9;
            }
            else if (ValueCaracter == System.Convert.ToInt32("("))
            {
                columna = 10;
            }
            else if (ValueCaracter == System.Convert.ToInt32(")"))
            {
                columna = 11;
            }
            else if (ValueCaracter == System.Convert.ToInt32("["))
            {
                columna = 12;
            }
            else if (ValueCaracter == System.Convert.ToInt32("]"))
            {
                columna = 13;
            }
            else if (ValueCaracter == System.Convert.ToInt32("{"))
            {
                columna = 14;
            }
            else if (ValueCaracter == System.Convert.ToInt32("}"))
            {
                columna = 15;
            }
            else if (ValueCaracter == System.Convert.ToInt32(";"))
            {
                columna = 16;
            }
            else if (ValueCaracter == System.Convert.ToInt32(" "))
            {
                columna = 17;
            }
            else if (ValueCaracter == System.Convert.ToInt32("="))
            {
                columna = 18;
            }
            else if (ValueCaracter == System.Convert.ToInt32("_"))
            {
                columna = 19;
            }
        }

        protected void ReconocerToken()
        {
            if (estado = 100)
            {
                PalabraResevada = false;
                Buscapreservadas();
                if (PalabraReservada)
                {
                    wsalida = Token + " PR " + direccion.ToString();
                }
                else
                {
                    Buscaidentificadores();
                    wsalida = Token + " PR " + direccion.ToString();
                }
                Posicion = Posicion - 1;
            }
            if (estado = 101)
            {
                ConstantesEnteras();
                wSalida = Token + "Ctes.Enteras" + direccion.ToString();
                Posicion = Posicion - 1;
            }
            if (estado = 102)
            {
                ConstantesReales();
                wSalida = Token + "Ctes.Reales" + direccion.ToString();
                Posicion = Posicion - 1;
            }
            if (Estado = 103)
            {
                Token = Token + Caracter;
                ConstantesString();
                wSalida = Token + "Ctes.String" + direccion.ToString();
            }
            if (Estado = 105)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 106)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 107)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 108)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 114)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 115)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 116)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 117)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 118)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 119)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 120)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 121)
            {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado = 104)
            {
                Token = Token + Caracter;
                wSalida = Token + "Commentario";
            }
            ListBoxSalida.Items.Add(wSalida);
        }

        protected void Buscapreservadas()
        {
            int Renglon2 = 0;
            direccion = -1;
            while ((!(PalabraReservada)) && (Renglon2 < ListBoxPalabrasReservadas.Items.Count))
            {
                ListBoxPalabrasReservadas.SelectedIndex = Renglon2;
                if (Token.ToUpper() = ListBoxPalabrasReservadas.Text.ToUpper())
                {
                    PalabraReservada = true;
                    direccion = Renglon2;
                }
                Renglon2++;
            }
        }

        protected void Buscaidentificadores()
        {
            int Renglon2 = 0;
            Encontro = false;
            while (!Encontro && Renglon2 < ListBoxIDS.Items.Count)
            {
                ListBoxIDS.SelectedIndex = Renglon2;
                if (Token.ToUpper() == ListBoxIDS.Text.ToUpper())
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2++;
            }
            if (!Encontro)
            {
                ListBoxIDS.Items.Add(Token);
                direccion = ListBoxIDS.Items.Count - 1;
            }
        }

        protected void ConstantesEnteras()
        {
            int Renglon2 = 0;
            Encontro = false;
            while (!(Encontro)) & (Renglon2 < ListBoxEnteras.Items.Count)
            {
                ListBoxEnteras.SelectedIndex = Renglon2;
                if (Token.ToUpper() == ListBoxEnteras.Text.ToUpper())
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2 = Renglon2++;
            }
            if (!Encontro)
            {
                ListBoxEnteras.Items.Add(Token);
                direccion = ListBoxEnteras.Items.Count - 1;
            }
        }

        protected void ConstantesReales()
        {
            int Renglon2 = 0;
            Encontro = False;
            while ((!Encontro) && (Renglon2 < ListBoxReales.Items.Count))
            {
                ListBoxReales.SelectedIndex = Renglon2;
                if (Token.ToUpper() == ListBoxReales.Text.ToUpper())
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2 = Renglon2++;
            }
            if (!Encontro)
            {
                ListBoxReales.Items.Add(Token);
                direccion = ListBoxReales.Items.Count - 1;
            }
        }

        protected void ConstantesString()
        {
            int Renglon2 = 0;
            Encontro = false;
            while(!(Encontro)) & (Renglon2 < ListBoxString.Items.Count)
            {
                ListBoxString.SelectedIndex = Renglon2;
                if (Token.ToUpper == ListBoxString.Text.ToUpper)
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2 = Renglon2++;
            }
            if (!Encontro)
            {
                ListBoxString.Items.Add(Token);
                direccion = ListBoxString.Items.Count - 1;
            }
        }
    }
}
