using System;
using System.Data;
using System.Data.SqlClient;

namespace POS
{
    class BLConsultarUsuarios
    {
        public static DataTable UsuariosDT()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD  ;User=AdminPOS; password=admin");
                conexion.Open();

                string consulUs = "select nombre_elemento,precio from elemento where seccion = '1'";
                SqlDataAdapter adaptUs = new SqlDataAdapter(consulUs, conexion);
                DataTable dtUsuarios = new DataTable();
                adaptUs.Fill(dtUsuarios);
                return dtUsuarios;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
