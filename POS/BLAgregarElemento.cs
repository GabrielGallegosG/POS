using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS
{
    public class BLAgregarElemento
    { 
        static int seccionC;
        public static void agregarElemento(string nombreTextBox, string seccionComboBox, double precio, string descripcionRichTextBox) {
            int y = 1;
           

            if (seccionComboBox.Equals("PLATILLO")) {
                seccionC = 1;
            }
            if (seccionComboBox.Equals("BEBIDA"))
            {
                seccionC = 2;
            }
            if (seccionComboBox.Equals("POSTRE"))
            {
                seccionC = 3;
            }

            try
            {

                using (dataLayer.POS_BDEntities db = new dataLayer.POS_BDEntities())
                {
                    var query = db.Set< dataLayer.elemento> ();
                    query.Add(new dataLayer.elemento
                    {
                        nombre_elemento = nombreTextBox,
                        seccion = seccionC,
                        precio = precio,
                        descripcion = descripcionRichTextBox
                    });

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
