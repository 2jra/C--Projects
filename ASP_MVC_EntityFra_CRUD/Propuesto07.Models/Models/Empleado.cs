//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Propuesto07.Models.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public double Sueldo { get; set; }
        public int Id_Departamento { get; set; }
    
        public virtual Departamento Departamento { get; set; }
    }
}