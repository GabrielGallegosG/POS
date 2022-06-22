using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLLogIn
    {
        public static void posicionLogin(Panel encabezadoP,Label encabezado, Label inicio, buttonLogin empleado, buttonLogin admin, Panel panel) { 

            empleado.Size = new Size(230, 40);
            admin.Size = new Size(245, 40);
            panel.Size = new Size(540, 320);


            inicio.Location = new Point(550, 100);
            empleado.Location = new Point(400, 160);
            admin.Location = new Point(730, 160);
            panel.Location = new Point(420, 270);

            panel.Hide();
        }

        public static void posicionPanel(Label usuarioL, TextBox usuario, Label contraseñaL, TextBox contraseña, buttonLogin inicio, Button visible)
        {
            usuarioL.Size = new Size(170, 20);
            usuario.Size = new Size(380, 20);
            contraseñaL.Size = new Size(150, 20);
            contraseña.Size = new Size(380, 20);
            inicio.Size = new Size(155, 35);
            visible.Size = new Size(25, 25);

            usuarioL.Location = new Point(80, 50);
            usuario.Location = new Point(80, 80);
            contraseñaL.Location = new Point(80, 150);
            contraseña.Location = new Point(80, 180);
            inicio.Location = new Point(190, 250);
            visible.Location = new Point(430, 182);
        }
    }
}
