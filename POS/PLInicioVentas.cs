﻿using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLInicioVentas
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario)
        {
            inicio.Size = new Size(90, 30);
            menu.Size = new Size(90, 30);
            orden.Size = new Size(101, 30);
            venta.Size = new Size(90, 30);
            usuario.Size = new Size(110, 30);

            inicio.Location = new Point(287, 10);
            menu.Location = new Point(383, 10);
            orden.Location = new Point(479, 10);
            venta.Location = new Point(587, 10);
            usuario.Location = new Point(683, 10);
        }

        public static void posicionConsultaMenu(PictureBox logo, Label ventas, Panel consultarVentas, Panel saldoInicial, Panel saldoFinal,
                                                    Label consultVentas, Label saldoInicialLabel, Label saldoFinalLabel)
        {
            logo.Size = new Size(115, 100);
            ventas.Size = new Size(110, 30);
            consultarVentas.Size = new Size(179, 41);
            saldoInicial.Size = new Size(217, 41);
            saldoFinal.Size = new Size(208, 41);
            consultVentas.Size = new Size(169, 19);
            saldoInicialLabel.Size = new Size(204, 19);
            saldoFinalLabel.Size = new Size(192, 19);

            logo.Location = new Point(12, 48);
            logo.BringToFront();
            ventas.Location = new Point(133, 87);
            consultarVentas.Location = new Point(246, 107);
            saldoInicial.Location = new Point(431, 107);
            saldoFinal.Location = new Point(652, 107);
            consultVentas.Location = new Point(2,7);
            saldoInicialLabel.Location = new Point(3,7);
            saldoFinalLabel.Location = new Point(5,7);
        }







    }
}
