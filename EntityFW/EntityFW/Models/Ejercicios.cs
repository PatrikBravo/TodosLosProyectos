//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFW.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ejercicios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string curp { get; set; }
        public Nullable<decimal> sueldo { get; set; }
        public Nullable<int> idEstadoOrigen { get; set; }
        public Nullable<short> idEstatus { get; set; }
    }
}
