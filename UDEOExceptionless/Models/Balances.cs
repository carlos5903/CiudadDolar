//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UDEOExceptionless.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Balances
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Balances()
        {
            this.donacion_balance = new HashSet<donacion_balance>();
        }
    
        public int Id { get; set; }
        public decimal Gastos { get; set; }
        public decimal Publicidad { get; set; }
        public decimal Caja_chica { get; set; }
        public decimal Iva { get; set; }
        public decimal Isr { get; set; }
        public decimal Total { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<donacion_balance> donacion_balance { get; set; }
    }
}
