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
    
    public partial class Calificacion
    {
        public int CalificacionID { get; set; }
        public decimal Acumulado { get; set; }
        public decimal ProyectoFinal { get; set; }
        public int EstudianteEstudianteID { get; set; }
        public int AsignaturaAsignaturaID { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
        public virtual Asignatura Asignatura { get; set; }
    }
}