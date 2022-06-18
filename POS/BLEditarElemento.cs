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
     public class  BLEditarElemento
    {

    public static String idSeleccionadoDT(string nombreP) {
        try
        {
            SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
            conexion.Open();

            string query = "select id_elemento from elemento where nombre_elemento = '" + nombreP + "'";
            string id = "";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader registro = command.ExecuteReader();
                if (registro.Read())
                {
                    id = registro["id_elemento"].ToString();
                }

                return id;
        }
            catch (Exception)
            {
                throw;
            }
        }


        public static String precioSeleccionadoDT(string nombreP)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ; User=AdminPOS; password=admin");
                conexion.Open();

                string query = "select precio from elemento where nombre_elemento = '" + nombreP + "'";
                string precio = "";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader registro = command.ExecuteReader();
                if (registro.Read())
                {
                    precio = registro["precio"].ToString();
                }

                return precio;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static String descripcionSeleccionadoDT(string nombreP)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin"); 
                conexion.Open();

                string query = "select descripcion from elemento where nombre_elemento = '" + nombreP + "'";
                string descripcion = "";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader registro = command.ExecuteReader();
                if (registro.Read())
                {
                    descripcion = registro["descripcion"].ToString();
                }

                return descripcion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void guardarEdicionDT(int id, string nombre, string seccion, string descripcion, string precio)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                string query = "UPDATE elemento SET nombre_elemento = '" + nombre + "' ,seccion = " + seccion + " ,descripcion =  '" + descripcion + "' ,precio = " + precio +" WHERE id_elemento = " + id ;
                SqlCommand command = new SqlCommand(query, conexion);
                int cant;
                cant = command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("¡Se han guardado los combios con exito!", "Edición completada ID - " + id, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
    

