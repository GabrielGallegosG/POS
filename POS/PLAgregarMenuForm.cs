using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLAgregarMenuForm
    {
        public static void posicionAgregarMenu(Panel encabezado, Label encabezadoL, Label nombreL, TextBox nombreTB,Label seccionL, ComboBox seccionCB, Label precioL, TextBox precioTB,
                                                Label descripcionL, RichTextBox descripcionRTB, buttonSystem agregar, buttonSystem cancelar)
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
            encabezado.Location = new Point(0,0);
            encabezadoL.Location = new Point(160,10);
            nombreL.Location = new Point(50, 90);
            nombreTB.Location = new Point(150, 90);

            seccionL.Location = new Point(50, 140);
            seccionCB.Location = new Point(150, 140);

            precioL.Location = new Point(290, 140);
            precioTB.Location = new Point(370, 140);

            descripcionL.Location = new Point(50, 190);
            descripcionRTB.Location = new Point(50, 220);

            agregar.Location = new Point(370, 440);
            cancelar.Location = new Point(50, 440);
        }
    }
}
