using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultarUsuarios
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

        public static void posicionConsultaUsuarios(PictureBox logo, Label menu, Label agregar, Button agregarUs, Panel panel, DataGridView tabla,
                                                     Panel buscar, Label usuario, Button editar, Button baja, TextBox buscarU, PictureBox lupa)
        {
            logo.Size = new Size(135, 120);
            menu.Size = new Size(110, 40);
            panel.Size = new Size(900, 40);
            tabla.Size = new Size(900, 300);
            buscar.Size = new Size(350, 40);
            buscarU.Size = new Size(310, 40);
            usuario.Size = new Size(350, 30);
            lupa.Size = new Size(25, 25);

            logo.Location = new Point(40, 70);
            logo.BringToFront();
            menu.Location = new Point(200, 110);

            agregar.Location = new Point(1100, 90);
            agregarUs.Location = new Point(1300, 80);

            panel.Location = new Point(250, 220);
            tabla.Location = new Point(250, 260);

            buscar.Location = new Point(800, 170);
            buscarU.Location = new Point(35, 9);
            lupa.Location = new Point(5, 5);

            usuario.Location = new Point(250, 580);
            editar.Location = new Point(620, 580);
            baja.Location = new Point(660, 580);
        }
        
    }
}
