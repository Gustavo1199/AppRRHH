//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int iD { get; set; }
        public string Codigo_De_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Telefono { get; set; }
        public string Departamento { get; set; }
        public string cargos { get; set; }
        public string Fechadeingreso { get; set; }
        public decimal Salary { get; set; }
        public bool Estatus { get; set; }
    }
}
