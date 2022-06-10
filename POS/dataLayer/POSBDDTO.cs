using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.dataLayer
{
    public class POSBDDTO : POS_BDEntities
    {
        class elementoDTO
        {
            public int ID
            {
                get { return ID; }
                set { ID = value; }
            }
            public String NOMBRE
            {
                get { return NOMBRE; }
                set { NOMBRE = value; }
            }

            public String SECCION
            {
                get { return SECCION; }
                set { SECCION = value; }
            }

            public String DESCRIPCION
            {
                get { return DESCRIPCION; }
                set { DESCRIPCION = value; }
            }
        }
    }

}