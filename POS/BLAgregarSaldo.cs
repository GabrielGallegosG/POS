using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class BLAgregarSaldo
    {
        public static void agregarSaldoInicial(String saldoInicial)
        {
            DateTime hoy = DateTime.Today;
            String fechaActual = hoy.ToString("d");
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                string query = "INSERT INTO saldoCajaDia(fechaActual, saldoInicial) VALUES ( '" + fechaActual + ",'" + saldoInicial + ")";
                SqlCommand command = new SqlCommand(query, conexion);
                int cant;
                cant = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
