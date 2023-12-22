﻿using System;
using System.Collections.Generic;

namespace nov23.Data.Models
{
    public partial class Saldo
    {
        public Saldo()
        {
            TransaccioneIdDestinoNavigations = new HashSet<Transaccione>();
            TransaccioneIdOrigenNavigations = new HashSet<Transaccione>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal? Saldo1 { get; set; }

        public virtual ICollection<Transaccione> TransaccioneIdDestinoNavigations { get; set; }
        public virtual ICollection<Transaccione> TransaccioneIdOrigenNavigations { get; set; }
    }
}
