using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLEditarMenu
    {
        public static void posicionEditarMenu(Panel encabezado, Label encabezadoL, Label id, Label idSeleccionado,Label nombreL, TextBox nombreTB, Label seccionL, ComboBox seccionCB, Label precioL, TextBox precioTB,
                                               Label descripcionL, RichTextBox descripcionRTB, buttonSystem agregar, buttonSystem cancelar)
        {
            //Tamaños
            id.Size = new Size(20, 20);
            idSeleccionado.Size = new Size(500, 20);
            nombreTB.Size = new Size(320, 20);
            seccionCB.Size = new Size(120, 20);
            precioTB.Size = new Size(100, 20);
            descripcionRTB.Size = new Size(420, 200);
            agregar.Size = new Size(100, 30);
            cancelar.Size = new Size(100, 30);
            encabezado.Size = new Size(525, 40);
            encabezadoL.Size = new Size(100, 40);

            //Posiciones
            encabezado.Location = new Point(0, 0);
            encabezadoL.Location = new Point(10, 10);

            id.Location = new Point(50, 80);
            idSeleccionado.Location = new Point(100, 80);

            nombreL.Location = new Point(50, 130);
            nombreTB.Location = new Point(150, 130);

            seccionL.Location = new Point(50, 180);
            seccionCB.Location = new Point(150, 180);

            precioL.Location = new Point(290, 180);
            precioTB.Location = new Point(370, 180);

            descripcionL.Location = new Point(50, 230);
            descripcionRTB.Location = new Point(50, 260);

            agregar.Location = new Point(370, 500);
            cancelar.Location = new Point(50, 500);
        }
    }
}
