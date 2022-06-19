using System;
using System.Data.SqlClient;

namespace POS
{
    class BLAgregarUsuario
    {
            public static int seccion;
            public static void agregarUsuario(string nombre, string apellidoP, string apellidoM, string tipo, string cargo, string usuario, string contraseña)
            {

                if (tipo.Equals("EMPLEADO"))
                {
                    seccion = 1;
                }
                if (tipo.Equals("ADMINISTRADOR"))
                {
                    seccion = 2;
                }


                try
                {
                        SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01; database=POS_BD ;User=AdminPOS; password=admin");
                        conexion.Open();
                        string query = "INSERT INTO usuario(nombre_usuario, apellidoP_usuario, apellidoM_usuario, tipo_usuario, cargo_usuario ,usuario,contraseña) VALUES ('" + nombre + "', '" + apellidoP + "', '" + apellidoM + "', " + seccion + ",'"+ cargo + "','" + usuario + "','" + contraseña + "')";
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
