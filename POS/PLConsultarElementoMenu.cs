using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class PLConsultarElementoMenu
    {
        public static void posicionConsultarElementorMenu(Panel encabezado, Label encabezadoL, Label id, Label idSeleccionado, Label nombreL, TextBox nombreTB, Label precioL, TextBox precioTB,
                                               Label descripcionL, RichTextBox descripcionRTB, Button modificar, Button eliminar, buttonSystem regresar)
        {
            //Tamaños
            id.Size = new Size(20, 20);
            idSeleccionado.Size = new Size(100, 20);
            nombreTB.Size = new Size(320, 20);
            precioTB.Size = new Size(100, 20);
            descripcionRTB.Size = new Size(420, 200);
            eliminar.Size = new Size(35, 35);
            modificar.Size = new Size(35, 35);
            regresar.Size = new Size(100, 30);
            encabezado.Size = new Size(525, 40);
            encabezadoL.Size = new Size(100, 40);

            //Posiciones
            encabezado.Location = new Point(0, 0);
            encabezadoL.Location = new Point(10, 10);

            id.Location = new Point(50, 80);
            idSeleccionado.Location = new Point(100, 80);

            nombreL.Location = new Point(50, 123);
            nombreTB.Location = new Point(135, 122);

            precioL.Location = new Point(290, 80);
            precioTB.Location = new Point(370, 79);

            descripcionL.Location = new Point(50, 180);
            descripcionRTB.Location = new Point(52, 210);

            modificar.Location = new Point(400, 475);
            eliminar.Location = new Point(435, 475);
            regresar.Location = new Point(50, 480);
        }

    }
}
