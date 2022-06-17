using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLAgregarUsuario
    {
        public static void posicionAgregarUsuario(Label encabezadoL, Label nombreL, TextBox nombre, Label apellidoPL, TextBox apellidoP, Label apellidoML, TextBox apellidoM,
                                                    Label usuarioL, TextBox usuario,Label contraseñaL, TextBox contraseña, Label tipoL, ComboBox tipo,
                                                    Label cargoL, TextBox cargo, buttonSystem cancelar, buttonSystem agregar) {

            nombre.Size = new Size(370,30);
            apellidoP.Size = new Size(300, 30);
            apellidoM.Size = new Size(300, 30);
            usuario.Size = new Size(260, 30);
            contraseña.Size = new Size(230, 30);
            tipo.Size = new Size(160, 30);
            cargo.Size = new Size(240, 30);
            agregar.Size = new Size(100, 30);
            cancelar.Size = new Size(100, 30);

            encabezadoL.Location = new Point(10, 10);

            nombreL.Location = new Point(50,80);
            nombre.Location = new Point(150, 80);

            apellidoPL.Location = new Point(50, 130);
            apellidoP.Location = new Point(220, 130);

            apellidoML.Location = new Point(50, 180);
            apellidoM.Location = new Point(220, 180);

            usuarioL.Location = new Point(50, 280);
            usuario.Location = new Point(150, 280);

            tipoL.Location = new Point(440, 280);
            tipo.Location = new Point(590, 280);

            contraseñaL.Location = new Point(50, 330);
            contraseña.Location = new Point(180, 330);

            cargoL.Location = new Point(440, 330);
            cargo.Location = new Point(510, 330);

            agregar.Location = new Point(650, 420);
            cancelar.Location = new Point(50, 420);
        }

    }
}
