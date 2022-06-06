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
            orden.Size = new Size(95, 30);
            venta.Size = new Size(90, 30);
            usuario.Size = new Size(110, 30);

            inicio.Location = new Point(300,4);
            menu.Location = new Point(395,4);
            orden.Location = new Point(490,4);
            venta.Location = new Point(590,4);
            usuario.Location = new Point(685,4);
        }

        public  static void posicionConsultaMenu(PictureBox logo, Label menu, Panel platillos, Panel bebidas, Panel postres,
                                                    DataGridView platillosDGV, DataGridView bebidasDGV, DataGridView postresDGV,
                                                    Label platillo, Label bebida, Label postre, Button modiPlatillo, Button modiBebida, 
                                                    Button modiPostre, Button eliPlatillo, Button eliBebida, Button eliPostre,
                                                    Label agregarMenuL, Button agregarMenuBtn)
        {
            logo.Size = new Size(115,100);
            menu.Size = new Size(100,40);
            platillos.Size = new Size(200, 40);
            bebidas.Size = new Size(200, 40);
            postres.Size = new Size(200, 40);
            platillosDGV.Size = new Size(200, 150);
            bebidasDGV.Size = new Size(200, 150);
            postresDGV.Size = new Size(200, 150);
            platillo.Size = new Size(120, 25);
            bebida.Size = new Size(120, 25);
            postre.Size = new Size(120, 25);
            modiPlatillo.Size = new Size(35,30);
            modiBebida.Size = new Size(35, 30);
            modiPostre.Size = new Size(35, 30);
            eliPlatillo.Size = new Size(35, 30);
            eliBebida.Size = new Size(35, 30);
            eliPostre.Size = new Size(35, 30);
            agregarMenuBtn.Size = new Size(45, 30);

            logo.Location = new Point(30,10);
            logo.BringToFront();
            menu.Location = new Point(160, 50);

            platillos.Location = new Point(30, 150);
            bebidas.Location = new Point(300, 150);
            postres.Location = new Point(570, 150);

            platillosDGV.Location = new Point(30, 200);
            bebidasDGV.Location = new Point(300, 200);
            postresDGV.Location = new Point(570, 200);

            platillo.Location = new Point(30, 370);
            bebida.Location = new Point(300, 370);
            postre.Location = new Point(570, 370);

            modiPlatillo.Location = new Point(160, 365);
            modiBebida.Location = new Point(430, 365);
            modiPostre.Location = new Point(700, 365);

            eliPlatillo.Location = new Point(190,365);
            eliBebida.Location = new Point(460,365);
            eliPostre.Location = new Point(730,365);

            agregarMenuL.Location = new Point(585, 50);
            agregarMenuBtn.Location = new Point(740, 45);
        }

        public static void panelPlatillo(Label platillos)
        {
            platillos.Location = new Point(50, 10);
        }

        public static void panelBebida(Label bebida)
        {
            bebida.Location = new Point(60, 10);
        }

        public static void panelPostre(Label postre)
        {
            postre.Location = new Point(60, 10);
        }
    }
}
