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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NotasModelContainer : DbContext
    {
        public NotasModelContainer()
            : base("name=NotasModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Calificacion> Calificaciones { get; set; }
        public virtual DbSet<Asignatura> Asignaturas { get; set; }
    }
}
