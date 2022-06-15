using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class BLEliminarElemento
    {
        public static void EliminarnDT(int id)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ; integrated security = SSPI");
                conexion.Open();
                string query = "DELETE FROM elemento WHERE id_elemento = " + id;
                SqlCommand command = new SqlCommand(query, conexion);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
