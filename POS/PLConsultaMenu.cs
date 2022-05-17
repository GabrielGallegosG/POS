using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class PLConsultaMenu
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario)
        {
            inicio.Size = new Size(90,30);
            menu.Size = new Size(90, 30);
            orden.Size = new Size(90, 30);
            venta.Size = new Size(90, 30);
            usuario.Size = new Size(110, 30);

            inicio.Location = new Point(305,4);
            menu.Location = new Point(400,4);
            orden.Location = new Point(495,4);
            venta.Location = new Point(590,4);
            usuario.Location = new Point(685,4);
        }

        public  static void posicionConsultaMenu(PictureBox logo, Label menu, Panel platillos, Panel bebidas, Panel postres,
                                                    DataGridView platillosDGV, DataGridView bebidasDGV, DataGridView postresDGV)
        {
            logo.Size = new Size(115,100);
            menu.Size = new Size(100,40);
            platillos.Size = new Size(160, 40);
            bebidas.Size = new Size(160, 40);
            postres.Size = new Size(160, 40);
            platillosDGV.Size = new Size(160, 150);
            bebidasDGV.Size = new Size(160, 150);
            postresDGV.Size = new Size(160, 150);

            logo.Location = new Point(30,10);
            logo.BringToFront();
            menu.Location = new Point(160, 50);

            platillos.Location = new Point(30, 150);
            bebidas.Location = new Point(300, 150);
            postres.Location = new Point(570, 150);

            platillosDGV.Location = new Point(30, 200);
            bebidasDGV.Location = new Point(300, 200);
            postresDGV.Location = new Point(570, 200);
        }
    }
}
