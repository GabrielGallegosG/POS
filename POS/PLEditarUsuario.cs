using System.Drawing;
using System.Windows.Forms;


namespace POS
{
    class PLEditarUsuario
    {
        public static void posicionEditarUsuario(Label encabezadoL, Label id, Label idUs, Label nombreL, TextBox nombre, Label apellidoPL, TextBox apellidoP, Label apellidoML, TextBox apellidoM,
                                                   Label usuarioL, TextBox usuario, Label contraseñaL, TextBox contraseña, Label tipoL, ComboBox tipo,
                                                   Label cargoL, TextBox cargo, buttonSystem cancelar, buttonSystem agregar)
        {
            idUs.Size = new Size(200, 30);
            nombre.Size = new Size(370, 30);
            apellidoP.Size = new Size(300, 30);
            apellidoM.Size = new Size(300, 30);
            usuario.Size = new Size(260, 30);
            contraseña.Size = new Size(230, 30);
            tipo.Size = new Size(160, 30);
            cargo.Size = new Size(240, 30);
            agregar.Size = new Size(120, 40);
            cancelar.Size = new Size(120, 40);

            encabezadoL.Location = new Point(10, 10);

            id.Location = new Point(50, 80);
            idUs.Location = new Point(100, 80);

            nombreL.Location = new Point(50, 130);
            nombre.Location = new Point(150, 130);

            apellidoPL.Location = new Point(50, 180);
            apellidoP.Location = new Point(220, 180);

            apellidoML.Location = new Point(50, 230);
            apellidoM.Location = new Point(220, 230);

            usuarioL.Location = new Point(50, 330);
            usuario.Location = new Point(150, 330);

            tipoL.Location = new Point(440, 330);
            tipo.Location = new Point(590, 330);

            contraseñaL.Location = new Point(50, 380);
            contraseña.Location = new Point(180, 380);

            cargoL.Location = new Point(440, 380);
            cargo.Location = new Point(510, 380);

            agregar.Location = new Point(630, 465);
            cancelar.Location = new Point(50, 465);
        }
    }
}
