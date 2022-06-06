using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace POS
{
    class PLInicio
    {
        public static void posicionInicio(Label encabezado, Label agregar, Label consulta, Label login) { 
        
            encabezado.Size = new Size(150, 30);

            encabezado.Location = new Point(180, 50);
            agregar.Location = new Point(50,200);
            consulta.Location = new Point(250,200);
            login.Location = new Point(50, 300);

        }
    }
}
