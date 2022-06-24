using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class BLConsultaVenta
    {
        public static DataTable consultTabla()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();

                string consulPla = "select idOrden, usuario, noMesa, tipoServicio, fecha, hora, totalOrden, metodoPago from ordenes";
                SqlDataAdapter adapt = new SqlDataAdapter(consulPla, conexion);
                DataTable dtVentas = new DataTable();
                adapt.Fill(dtVentas);
                return dtVentas;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
