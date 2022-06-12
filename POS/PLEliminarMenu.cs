using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLEliminarMenu
    {
        public static void posicionEliminarMenu(Panel encabezado, Label encabezadoL, Label id, Label idSeleccionado, Label nombreL, Label nombreSeleccionado, Label seccionL, Label seccionSeleccionado, Label precioL, Label precioSeleccionado,
                                               RichTextBox nota, buttonSystem cancelar, buttonSystem eliminar)
        {
            //Tamaños
            id.Size = new Size(20, 20);
            idSeleccionado.Size = new Size(100, 20);
            nombreSeleccionado.Size = new Size(320, 20);
            seccionSeleccionado.Size = new Size(120, 20);
            precioSeleccionado.Size = new Size(100, 20);
            nota.Size = new Size(490,60);
            eliminar.Size = new Size(150, 30);
            cancelar.Size = new Size(150, 30);
            encabezado.Size = new Size(580, 40);
            encabezadoL.Size = new Size(200, 40);

            //Posiciones
            encabezado.Location = new Point(0, 0);
            encabezadoL.Location = new Point(10, 10);

            id.Location = new Point(50, 80);
            idSeleccionado.Location = new Point(100, 80);

            nombreL.Location = new Point(50, 130);
            nombreSeleccionado.Location = new Point(150, 130);

            seccionL.Location = new Point(50, 180);
            seccionSeleccionado.Location = new Point(150, 180);

            precioL.Location = new Point(290, 180);
            precioSeleccionado.Location = new Point(370, 180);

            nota.Location = new Point(40, 230);

            eliminar.Location = new Point(370, 300);
            cancelar.Location = new Point(50, 300);
        }
    }
}
