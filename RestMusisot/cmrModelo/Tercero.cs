//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cmrModelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tercero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tercero()
        {
            this.Venta = new HashSet<Venta>();
        }
    
        public long Id { get; set; }
        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public bool EsProveedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}