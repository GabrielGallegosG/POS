//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.dataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class seccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public seccion()
        {
            this.elemento = new HashSet<elemento>();
        }
    
        public int id_seccion { get; set; }
        public string nombre_seccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<elemento> elemento { get; set; }
        public virtual seccion seccion1 { get; set; }
        public virtual seccion seccion2 { get; set; }
    }
}
