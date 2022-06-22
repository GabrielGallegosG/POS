using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS
{
    class BLEditarUsuario
    {
        public static void guardarEdicionDT(int id, string nombre, string apellidoP, string apellidoM, string tipo, string cargo, string usuario, string contraseña)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                string query = "UPDATE usuario SET nombre_usuario = '" + nombre + "' ,apellidoP_usuario = '" + apellidoP + "' ,apellidoM_usuario =  '" + apellidoM + "' ,tipo_usuario = " + tipo + ", cargo_usuario = '" + cargo + "', usuario = '" + usuario + "', contraseña = '" + contraseña + "' WHERE id_usuario = " + id;
                SqlCommand command = new SqlCommand(query, conexion);
                int cant;
                cant = command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("¡Se han guardado los cambios con exito!", "Edición completada ID - " + id, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
