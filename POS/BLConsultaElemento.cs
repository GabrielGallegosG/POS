using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class BLConsultaElemento
    {
        public static DataTable PlatillosDT()
        {
            try { 
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();

                string consulPla = "select nombre_elemento,precio from elemento where seccion = '1'";
                SqlDataAdapter adaptPla = new SqlDataAdapter(consulPla, conexion);
                DataTable dtPlatillo = new DataTable();
                adaptPla.Fill(dtPlatillo);
                return dtPlatillo;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static DataTable BebidasDT()
        {
            try {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();

                string consulBe = "select nombre_elemento,precio from elemento where seccion = '2'";
                SqlDataAdapter adaptBe = new SqlDataAdapter(consulBe, conexion);
                DataTable dtBebida = new DataTable();
                adaptBe.Fill(dtBebida);
                return dtBebida;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable PostresDT()
        {
            try {
                SqlConnection conexion = new SqlConnection("server=desktop-arias-r\\mssqlserver01 ; database=POS_BD ;User=AdminPOS; password=admin");
                conexion.Open();

                string consulPos = "select nombre_elemento,precio from elemento where seccion = '3'";
                SqlDataAdapter adaptPos = new SqlDataAdapter(consulPos, conexion);
                DataTable dtPostre = new DataTable();
                adaptPos.Fill(dtPostre);

                return dtPostre;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
} 
