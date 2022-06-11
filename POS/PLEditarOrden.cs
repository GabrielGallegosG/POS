using System.Drawing;
using System.Windows.Forms;


namespace POS
{
    class PLEditarOrden
    {
        public static void posicionEditarOrden(Label empleado, Label empleadoOrd, Label tipoServ, Label noMesa, Label fecha, Label hora, Label fechaOrd, Label horaOrd, ComboBox servicio, ComboBox mesa,
           Label agregar, CheckBox platillo, CheckBox postre, CheckBox bebida)
        {
            empleado.Size = new Size(100, 20);
            empleadoOrd.Size = new Size(150, 20);
            tipoServ.Size = new Size(100, 20);
            noMesa.Size = new Size(100, 20);
            fecha.Size = new Size(100, 20);
            hora.Size = new Size(100, 20);
            fechaOrd.Size = new Size(100, 20);
            horaOrd.Size = new Size(100, 20);
            servicio.Size = new Size(160, 20);
            mesa.Size = new Size(80, 20);

            empleado.Location = new Point(50, 70);
            empleadoOrd.Location = new Point(150, 70);
            tipoServ.Location = new Point(50, 120);
            noMesa.Location = new Point(50, 170);
            servicio.Location = new Point(200, 120);
            mesa.Location = new Point(170, 170);

            fecha.Location = new Point(570, 70);
            hora.Location = new Point(570, 120);
            fechaOrd.Location = new Point(650, 70);
            horaOrd.Location = new Point(650, 120);

            agregar.Location = new Point(50, 250);
            platillo.Location = new Point(50, 300);
            postre.Location = new Point(180, 300);
            bebida.Location = new Point(300, 300);
        }
    }
}
