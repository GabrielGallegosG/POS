using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class BLAgregarOrden
    {
        public static void agregarOrden(int usuario, string noMesa, string tipoServicio, string fecha, string hora, float totalOrden,
                                        string estadoElaboracion, string estadoPago, string metodoPago, string comentarios)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                string query = "INSERT INTO ordenes (usuario, noMesa, tipoServicio, fecha, hora, totalOrden, estadoElaboracion, estadoPago, metodoPago, comentarios) VALUES ( '" + usuario + "',  '" + noMesa + "',  '" + tipoServicio + "',  '" + fecha + "',  '" + hora + "', " + totalOrden + ",  '" + estadoElaboracion + "',  '" + estadoPago + "',  '" + metodoPago + "',  '" + comentarios + "')";
                SqlCommand command = new SqlCommand(query, conexion);
                int cant;
                cant = command.ExecuteNonQuery();

                MessageBox.Show("¡Se han guardado los cambios con exito!","Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                throw;
            }
        }

        void agregarOrdenMenu(List<agregarOrdenForm.elementosSeleccionados> lista, int orden, string usuario, string fecha, string hora)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();
                
                //string query = "INSERT INTO ordenes (usuario, noMesa, tipoServicio, fecha, hora, totalOrden, estadoElaboracion, estadoPago, metodoPago, comentarios) VALUES ( '" + usuario + "',  '" + noMesa + "',  '" + tipoServicio + "',  '" + fecha + "',  '" + hora + "', " + totalOrden + ",  '" + estadoElaboracion + "',  '" + estadoPago + "',  '" + metodoPago + "',  '" + comentarios + "')";
                //string query = @"INSERT INTO RankingActual (Puesto, NroJugador, NombreJugador, CategoriaId, PtosAcumulados,TorneoId, PuestoAnterior) 
                //VALUES (@Puesto, @NroJugador, @NombreJugador, @CategoriaId, @PtosAcumulados, @TorneoId, @PuestoAnterior)";

                
                string query = "INSERT INTO ordenMenu (orden, elementoMenu, cantidadElementoMenu, subtotalOrden) VALUES ("+orden+",@elemento,@cantidad,@subtotal)";
                SqlCommand cmd = new SqlCommand(query, conexion);


                System.Collections.IList list = lista;
                for (int i = 0; i < list.Count; i++)
                {
                    string[] listArch = (string[])list[i];
                    foreach (string item in listArch)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@NroJugador", item[2]);
                        cmd.Parameters.AddWithValue("@NombreJugador", "Nombre Test");
                        //resto
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
    

