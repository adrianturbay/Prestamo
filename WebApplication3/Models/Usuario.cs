//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.PresClienUsus = new HashSet<PresClienUsu>();
        }
    
        public long Id { get; set; }
        public string ApyNom { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Celular { get; set; }
        public string Usuario1 { get; set; }
        public string Password { get; set; }
        public Nullable<long> IdZona { get; set; }
        public Nullable<byte> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PresClienUsu> PresClienUsus { get; set; }
        public virtual Zona Zona { get; set; }
    }
}
