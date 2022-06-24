using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class BLConsultarOrden
    {

        public static DataTable OrdenesDT()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();

                string consulPla = "select idOrden, noMesa, tipoServicio, fecha, hora, totalOrden, estadoElaboracion from ordenes";
                SqlDataAdapter adapt = new SqlDataAdapter(consulPla, conexion);
                DataTable dtOrdenes = new DataTable();
                adapt.Fill(dtOrdenes);
                return dtOrdenes;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
