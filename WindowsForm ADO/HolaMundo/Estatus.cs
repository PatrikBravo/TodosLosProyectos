﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Estatus
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
