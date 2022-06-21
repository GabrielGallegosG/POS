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
                string consulUs = "select id_usuario, nombre_usuario,apellidoP_usuario,apellidoM_usuario,tipo_usuario,cargo_usuario, usuario, contraseña from usuario";
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