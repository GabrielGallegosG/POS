using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLLogIn
    {
        public static void posicionLogin(Label encabezado, Label inicio, Button empleado, Button admin, Panel panel) { 

            encabezado.Size = new Size(150, 30);
            inicio.Size = new Size(160, 30);
            empleado.Size = new Size(230, 30);
            admin.Size = new Size(230, 30);
            panel.Size = new Size(450, 240);

            encabezado.Location = new Point(280, 10);
            inicio.Location = new Point(300, 80);
            empleado.Location = new Point(110, 130);
            admin.Location = new Point(430, 130);
            panel.Location = new Point(160, 200);

            panel.Hide();
        }

        public static void posicionPanel(Label usuarioL, TextBox usuario, Label contraseñaL, TextBox contraseña, Button inicio)
        {
            usuarioL.Size = new Size(170, 20);
            usuario.Size = new Size(360, 20);
            contraseñaL.Size = new Size(150, 20);
            contraseña.Size = new Size(360, 20);
            inicio.Size = new Size(135, 30);

            usuarioL.Location = new Point(45, 20);
            usuario.Location = new Point(45, 50);
            contraseñaL.Location = new Point(45, 110);
            contraseña.Location = new Point(45, 140);
            inicio.Location = new Point(150, 200);
        }
    }
}
