using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class PLPagoOrden
    {

        public static void datosPago(Label noOrden, Label orden, Label montoPagar, Label monto) {
            
            noOrden.Size = new Size(100, 40);
            orden.Size = new Size(100, 40);
            montoPagar.Size = new Size(120, 40);
            monto.Size = new Size(120, 40);

            noOrden.Location = new Point(50, 80);
            orden.Location = new Point(50, 100);
            montoPagar.Location = new Point(360, 80);
            monto.Location = new Point(360, 100);
        }

        public static void metodoPago(Label metodo, CheckBox efectivo, CheckBox tarjeta, TextBox efectivoTB, TextBox tarjetaTB, Label total, Label division, Label saldoFavor)
        {

            metodo.Size = new Size(100, 40);
            efectivoTB.Size = new Size(100, 40);
            tarjetaTB.Size = new Size(100, 40);
            total.Size = new Size(120, 40);
            division.Size = new Size(120, 40);

            metodo.Location = new Point(50, 160);
            efectivo.Location = new Point(50, 200);
            tarjeta.Location = new Point(50, 250);
            efectivoTB.Location = new Point(370, 190);
            tarjetaTB.Location = new Point(370, 240);
            division.Location = new Point(350, 290);
            total.Location = new Point(370, 315);
            saldoFavor.Location = new Point(50, 320);

            efectivoTB.Enabled = false;
            tarjetaTB.Enabled = false;

        }

        public static void botonesPago(Button masTarde, Button ahora) {
            masTarde.Size = new Size(140,50);
            ahora.Size = new Size(140, 50);

            masTarde.Location = new Point(50, 400);
            ahora.Location = new Point(370, 400);

        }

    }
}
