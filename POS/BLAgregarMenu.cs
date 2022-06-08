using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class BLAgregarMenu
    {
        public static void agregarElemento(string nombreTextBox, string seccionComboBox, double precio, string descripcionRichTextBox) {
            int y = 1;
            /*try
            {
                using (BDPOS db = new BDPOSEntities())
                {
                    var query = db.Set<elemento>();
                    query.Add(new elemento
                    {
                        id_elemento = y++,
                        nombreTextBox = nombreTextBox,
                        seccionComboBox = seccionComboBox,
                        precio = precio,
                        descripcionRichTextBox = descripcionRichTextBox
                    });

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }*/
        }
        
    }
}
