//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        public int idE { get; set; }
        public string nomE { get; set; }
        public string telE { get; set; }
        public string salud { get; set; }
        public Nullable<int> sedeE { get; set; }
    
        public virtual sede sede { get; set; }
    }
}
