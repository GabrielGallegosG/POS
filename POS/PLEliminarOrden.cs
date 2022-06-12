using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLEliminarOrden
    {
        public static void posicionEliminarOrden(Panel encabezado, Label encabezadoL, Label noOrden, Label noOrdenSelec, Label tipoServ, Label servicio, Label noMesa, Label mesa, Label fecha, Label fechaOrd,
                                               Label hora, Label horaOrd,RichTextBox nota, buttonSystem cancelar, buttonSystem eliminar)
        {
            //Tamaños
            noOrden.Size = new Size(20, 20);
            noOrdenSelec.Size = new Size(120, 20);
            tipoServ.Size = new Size(320, 20);
            servicio.Size = new Size(170, 20);
            noMesa.Size = new Size(100, 20);
            mesa.Size = new Size(100, 20);
            fecha.Size = new Size(100, 20);
            fechaOrd.Size = new Size(100, 20);
            hora.Size = new Size(100, 20);
            horaOrd.Size = new Size(100, 20);
            nota.Size = new Size(490, 60);
            eliminar.Size = new Size(150, 30);
            cancelar.Size = new Size(150, 30);
            encabezado.Size = new Size(580, 40);
            encabezadoL.Size = new Size(200, 40);

            //Posiciones
            encabezado.Location = new Point(0, 0);
            encabezadoL.Location = new Point(10, 10);

            noOrden.Location = new Point(30, 80);
            noOrdenSelec.Location = new Point(140, 80);

            tipoServ.Location = new Point(30, 130);
            servicio.Location = new Point(180, 130);

            noMesa.Location = new Point(30, 180);
            mesa.Location = new Point(150, 180);

            nota.Location = new Point(40, 230);

            eliminar.Location = new Point(370, 300);
            cancelar.Location = new Point(50, 300);
        }
    }
}
