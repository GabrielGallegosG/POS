using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class PLAgregarMenuForm
    {
        public static void posicionAgregarMenu(Panel encabezado, Label nombreL, TextBox nombreTB,Label seccionL, ComboBox seccionCB, Label precioL, TextBox precioTB,
                                                Label descripcionL, RichTextBox descripcionRTB)
        {
            //Tamaños
            nombreTB.Size = new Size(320, 20);
            seccionCB.Size = new Size(120, 20);
            precioTB.Size = new Size(100, 20);
            descripcionRTB.Size = new Size(420, 200);

            //Posiciones
            encabezado.Location = new Point(0,50);
            nombreL.Location = new Point(50, 150);
            nombreTB.Location = new Point(150, 150);

            seccionL.Location = new Point(50, 200);
            seccionCB.Location = new Point(150, 200);

            precioL.Location = new Point(290, 200);
            precioTB.Location = new Point(370, 200);

            descripcionL.Location = new Point(50, 250);
            descripcionRTB.Location = new Point(50, 280);
        }
    }
}
