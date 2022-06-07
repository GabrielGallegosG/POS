using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLAgregarMenuForm
    {
        public static void posicionAgregarMenu(Panel encabezado, Label encabezadoL, Label nombreL, TextBox nombreTB,Label seccionL, ComboBox seccionCB, Label precioL, TextBox precioTB,
                                                Label descripcionL, RichTextBox descripcionRTB, Button agregar, Button cancelar)
        {
            //Tamaños
            nombreTB.Size = new Size(320, 20);
            seccionCB.Size = new Size(120, 20);
            precioTB.Size = new Size(100, 20);
            descripcionRTB.Size = new Size(420, 200);
            agregar.Size = new Size(100,30);
            cancelar.Size = new Size(100, 30);
            encabezado.Size = new Size(525,40);
            encabezadoL.Size = new Size(100, 40);

            //Posiciones
            encabezado.Location = new Point(0,50);
            encabezadoL.Location = new Point(160,10);
            nombreL.Location = new Point(50, 150);
            nombreTB.Location = new Point(150, 150);

            seccionL.Location = new Point(50, 200);
            seccionCB.Location = new Point(150, 200);

            precioL.Location = new Point(290, 200);
            precioTB.Location = new Point(370, 200);

            descripcionL.Location = new Point(50, 250);
            descripcionRTB.Location = new Point(50, 280);

            agregar.Location = new Point(370, 500);
            cancelar.Location = new Point(50, 500);
        }
    }
}
