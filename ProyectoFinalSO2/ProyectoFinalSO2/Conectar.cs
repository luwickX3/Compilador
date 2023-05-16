using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinalSO2
{
    class Conectar
    {
        SqlConnection Conexion = new SqlConnection();
        String CadenaDeConexion = "Data Source=DESKTOP-LFT3TIB\\INSTANCEEXPRESS1;Initial Catalog = ProyectoFinalSO2; Integrated Security = True";
        public Conectar()
        {
            Conexion.ConnectionString = CadenaDeConexion;
        }
        public void AbrirConexion()
        {
            try 
            {
                Conexion.Open();
                Console.WriteLine("Conexion abierta");
            } 
            catch (Exception e) 
            {
                Console.WriteLine("error:"+e.Message);
            }
        }
        public void CerrarConexion()
        {
            try
            {
                Conexion.Close();
                Console.WriteLine("Conexion cerrada");
            }
            catch (Exception e)
            {
                Console.WriteLine("error:" + e.Message);
            }
        }
    }
}
