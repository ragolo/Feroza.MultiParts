//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Feroza.MultiParts.Infrastructure.Data.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Referencias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Referencias()
        {
            this.Aplicaciones = new HashSet<Aplicaciones>();
        }
    
        public string CodigoOem { get; set; }
        public bool Kit { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionTecnica { get; set; }
        public int IdFabricante { get; set; }
        public int IdSistemas { get; set; }
        public int IdSubSistemas { get; set; }
        public string CodigoOemPadre { get; set; }
        public Nullable<int> IdMarcas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aplicaciones> Aplicaciones { get; set; }
    }
}
