using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class BLAgregarOrden
    {
        public static void agregarOrden(String tipoServicio, int noMesa) {
            try
            {
                /*SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                string query = "INSERT INTO orden(no_mesa, nombre_empleado, fecha, hora, nombre_elemento, cantidad_elemento, comentarios, totals) VALUES ( '" + n + "', " + s + ", '" + d + "', " + p + ")";
                SqlCommand command = new SqlCommand(query, conexion);
                int cant;
                cant = command.ExecuteNonQuery();*/
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
