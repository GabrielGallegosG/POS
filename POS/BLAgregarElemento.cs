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
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01; database=POS_BD ;User=AdminPOS; password=admin");
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

        public static int validarNombre(string nombre)
        {
            int ban = 0;

            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                nombre = nombre.ToLower();
                string query = "select * from elemento where nombre_elemento = '"+ nombre +"'";
                string validarNombre = "";

                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader registro = command.ExecuteReader();
                if (registro.Read())
                {
                    validarNombre = registro["nombre_elemento"].ToString();
                    validarNombre = validarNombre.ToLower();
                    if (validarNombre.Equals(nombre))
                        ban = 1;
                }

                return ban;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
