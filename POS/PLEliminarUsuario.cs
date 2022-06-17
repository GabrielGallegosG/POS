using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLEliminarUsuario
    {
        public static void posicionEliminarUsuario(Panel encabezado, Label encabezadoL, Label usuario, Label idSeleccionado, Label nombreL, Label nombreSeleccionado, Label apellidoP, Label apellidoPSeleccionado, Label apellidoM, Label apellidoMSeleccionado,
                                               RichTextBox nota, buttonSystem cancelar, buttonSystem eliminar)
        {
            //Tamaños
            usuario.Size = new Size(20, 20);
            idSeleccionado.Size = new Size(100, 20);
            nombreSeleccionado.Size = new Size(320, 20);
            apellidoPSeleccionado.Size = new Size(250, 20);
            apellidoMSeleccionado.Size = new Size(250, 20);
            nota.Size = new Size(490, 60);
            eliminar.Size = new Size(150, 30);
            cancelar.Size = new Size(150, 30);
            encabezado.Size = new Size(580, 40);
            encabezadoL.Size = new Size(200, 40);

            //Posiciones
            encabezado.Location = new Point(0, 0);
            encabezadoL.Location = new Point(10, 10);

            usuario.Location = new Point(50, 80);
            idSeleccionado.Location = new Point(160, 80);

            nombreL.Location = new Point(50, 130);
            nombreSeleccionado.Location = new Point(140, 130);

            apellidoP.Location = new Point(50, 180);
            apellidoPSeleccionado.Location = new Point(220, 180);

            apellidoM.Location = new Point(50, 230);
            apellidoMSeleccionado.Location = new Point(220, 230);

            nota.Location = new Point(40, 300);

            eliminar.Location = new Point(370, 370);
            cancelar.Location = new Point(50, 370);
        }
    }
}
