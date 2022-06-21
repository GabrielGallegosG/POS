using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultaOrdenes
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario)
        {
            inicio.Size = new Size(90, 35);
            menu.Size = new Size(90, 35);
            orden.Size = new Size(110, 35);
            venta.Size = new Size(100, 35);
            usuario.Size = new Size(120, 35);

            inicio.Location = new Point(808, 7);
            menu.Location = new Point(907, 7);
            orden.Location = new Point(1005, 7);
            venta.Location = new Point(1123, 7);
            usuario.Location = new Point(1230, 7);
        }

        public static void posisiconConsultaOrdenes(PictureBox logo, Label menu, Label nuevaOrd, Button agregar)
        {
            logo.Size = new Size(155, 120);
            menu.Size = new Size(100, 40);
            agregar.Size = new Size(45, 30);
            logo.Location = new Point(40, 70);
            logo.BringToFront();
            menu.Location = new Point(200, 110);
            nuevaOrd.Location = new Point(1150, 90);
            agregar.Location = new Point(1300, 86);
        }
    }
}
