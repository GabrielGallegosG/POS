using System;
using System.Data.SqlClient;

namespace POS
{
    class BLEliminarUsuario
    {
        public static void EliminarUsuarioDT(int id)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                string query = "DELETE FROM usuario WHERE id_usuario = " + id;
                SqlCommand command = new SqlCommand(query, conexion);
                int cant = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
