using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDEstatusAlumno.Entidades
{
    public class Estatus
    {
        public Estatus(int id, string clave, string nombre)
        {
            this.id = id;
            this.clave = clave;
            this.nombre = nombre;
        }
        public Estatus() { }
        public int id { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
    }
}