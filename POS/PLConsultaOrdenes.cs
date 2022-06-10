using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultaOrdenes
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario)
        {
            inicio.Size = new Size(90, 30);
            menu.Size = new Size(90, 30);
            orden.Size = new Size(95, 30);
            venta.Size = new Size(90, 30);
            usuario.Size = new Size(110, 30);

            inicio.Location = new Point(300, 4);
            menu.Location = new Point(395, 4);
            orden.Location = new Point(490, 4);
            venta.Location = new Point(590, 4);
            usuario.Location = new Point(685, 4);
        }

        public static void posisiconConsultaOrdenes(PictureBox logo, Label menu, Label nuevaOrd, Button agregar)
        {
            logo.Size = new Size(115, 100);
            menu.Size = new Size(100, 40);
            agregar.Size = new Size(45, 30);

            logo.Location = new Point(30, 40);
            logo.BringToFront();
            menu.Location = new Point(160, 80);
            nuevaOrd.Location = new Point(605, 50);
            agregar.Location = new Point(740, 45);
        }
    }
}
