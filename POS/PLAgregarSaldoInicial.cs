using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLAgregarSaldoInicial
    {
        public static void posicionAgregarSaldoInicial(Panel encabezado, Label encabezadoSaldoInicial, Label cantidad, 
                                            TextBox cantidadInicial, buttonSystem agregar, buttonSystem cancelar)
        {
            encabezado.Size = new Size(623, 38);
            encabezadoSaldoInicial.Size = new Size(422, 25);
            cantidad.Size = new Size(282, 21);
            cantidadInicial.Size = new Size(326, 29);
            agregar.Size = new Size(121, 39);
            cancelar.Size = new Size(121, 39);

            encabezado.Location = new Point(0,12);
            encabezadoSaldoInicial.Location = new Point(98,6);
            cantidad.Location = new Point(180,104);
            cantidadInicial.Location = new Point(153,164);
            agregar.Location = new Point(372,263);
            cancelar.Location = new Point(167,263);
        }






    }
}
