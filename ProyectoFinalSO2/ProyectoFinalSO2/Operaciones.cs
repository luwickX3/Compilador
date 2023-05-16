using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalSO2
{
    internal class Operaciones
    {
        public static string Encriptar(String str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public String VerificarUsuario(String Usr,String Psw)
        {
            String Cifrado = Encriptar(Psw);
            SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-LFT3TIB\\INSTANCEEXPRESS1;Initial Catalog = ProyectoFinalSO2; Integrated Security = True");
            Conexion.Open();
            String sql = $"SELECT Username,Contraseña FROM Usuario WHERE Username ='{Usr}'";
            SqlCommand cmd = new SqlCommand(sql,Conexion);
            SqlDataReader Leer = cmd.ExecuteReader();
            
            if (Leer.Read())
            {
                String Contra = Leer.GetString(1);
                String Cifrado2 = Encriptar(Contra);
                if (Cifrado == Cifrado2)
                {
                    return Leer["Username"].ToString();
                }
                else 
                {
                    Conexion.Close();
                    return "0";
                }
            }
            else 
            {
                Conexion.Close();
                return "0";
            }
        }
        
        public String AgregarUsuario(String Usr, String Psw, String Nme, String Phn, String Eml)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-LFT3TIB\\INSTANCEEXPRESS1;Initial Catalog = ProyectoFinalSO2; Integrated Security = True");
            Conexion.Open();
            string query1 = "SELECT MAX(IdUsuario) AS IdUsuario FROM Usuario";
            SqlCommand cmd = new SqlCommand(query1,Conexion);
            SqlDataReader Leer = cmd.ExecuteReader();
            if (Leer.Read())
            {
                if (Usr == "" )
                {
                    return "0";
                }
                else if (Psw == "")
                {
                    return "0";
                }
                else if (Nme == "")
                {
                    return "0";
                }
                else if (Phn == "")
                {
                    return "0";
                }
                else if (Eml == "")
                {
                    return "0";
                }
                else
                {
                    int Cosa = Leer.GetInt32(0);
                    Leer.Close();
                    Cosa = Cosa + 1;
                    String query2 = $"INSERT INTO Usuario (IdUsuario,Username,Contraseña,Nombre,Telefono,Email) VALUES ({Cosa},'{Usr}','{Psw}','{Nme}','{Phn}','{Eml}')";
                    cmd = new SqlCommand(query2, Conexion);
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    return "1";
                }
            }
            else 
            {
                return "0";
            }
        }
    }
}
