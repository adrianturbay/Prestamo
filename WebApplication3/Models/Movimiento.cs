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
    
    public partial class Movimiento
    {
        public long Id { get; set; }
        public Nullable<float> Ingreso { get; set; }
        public Nullable<float> Egreso { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<long> IdPrestamo { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual Prestamo Prestamo { get; set; }
    }
}