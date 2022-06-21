using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLAgregarSaldoFinal
    {
        public static void posicionAgregarSaldoFinal(Panel encabezado, Label encabezadoSaldoFinal, Label cantidadL, 
                                            TextBox cantidadFinal, buttonSystem agregar, buttonSystem cancelar)
        {
            encabezado.Size = new Size(623, 38);
            encabezadoSaldoFinal.Size = new Size(422, 25);
            cantidadL.Size = new Size(282, 21);
            cantidadFinal.Size = new Size(326, 29);
            agregar.Size = new Size(121, 39);
            cancelar.Size = new Size(121, 39);

            encabezado.Location = new Point(0,12);
            encabezadoSaldoFinal.Location = new Point(98,6);
            cantidadL.Location = new Point(180,104);
            cantidadFinal.Location = new Point(153,164);
            agregar.Location = new Point(372,263);
            cancelar.Location = new Point(167,263);
        }






    }
}
