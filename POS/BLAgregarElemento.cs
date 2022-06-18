using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public class BLAgregarElemento
    { 
        public static int seccion;
        public static void agregarElemento(string nombre, string seccionComboBox, double precio, string descripcion) {
            int y = 1;
           

            if (seccionComboBox.Equals("PLATILLO")) {
                seccion = 1;
            }
            if (seccionComboBox.Equals("BEBIDA"))
            {
                seccion = 2;
            }
            if (seccionComboBox.Equals("POSTRE"))
            {
                seccion = 3;
            }

            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ; Integrated Security = SSPI ;User=AdminPOS; password=admin");
                conexion.Open();
                string query = "INSERT INTO elemento(nombre_elemento ,seccion ,descripcion ,precio) VALUES ( '" + nombre + "', " + seccion +", '"+descripcion+"', "+ precio+")";
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
