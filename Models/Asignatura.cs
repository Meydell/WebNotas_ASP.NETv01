//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNotas_ASP.NETv01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asignatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asignatura()
        {
            this.Calificaciones = new HashSet<Calificacion>();
        }
    
        public int AsignaturaID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Creditos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calificacion> Calificaciones { get; set; }
    }
}
