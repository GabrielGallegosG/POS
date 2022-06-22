using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultarVentas
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario)
        {
            inicio.Size = new Size(90, 30);
            menu.Size = new Size(90, 30);
            orden.Size = new Size(101, 30);
            venta.Size = new Size(90, 30);
            usuario.Size = new Size(110, 30);

            inicio.Location = new Point(282, 3);
            menu.Location = new Point(378, 3);
            orden.Location = new Point(474, 3);
            venta.Location = new Point(582, 3);
            usuario.Location = new Point(678, 3);
        }

        public static void posicionConsultaMenu(PictureBox logo, Label ventas, DataGridView consultTabla,
                                                    Label filtrarL, ComboBox filtrarCB, Label datoBuscarL, TextBox datoBuscar)
        {
            logo.Size = new Size(115, 100);
            ventas.Size = new Size(110, 30);
            consultTabla.Size = new Size(915, 334);
            filtrarL.Size = new Size(132, 21);
            filtrarCB.Size = new Size(199, 21);
            datoBuscarL.Size = new Size(164, 21);
            datoBuscar.Size = new Size(197, 20);

            logo.Location = new Point(12, 48);
            logo.BringToFront();
            ventas.Location = new Point(133, 87);
            consultTabla.Location = new Point(13, 171);
            filtrarL.Location = new Point(295, 62);
            filtrarCB.Location = new Point(299, 97);
            datoBuscarL.Location = new Point(595, 62);
            datoBuscar.Location = new Point(602, 97);

        }







    }
}
