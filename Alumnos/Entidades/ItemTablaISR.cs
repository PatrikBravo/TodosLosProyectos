using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemTablaISR
    {
        public ItemTablaISR()
        {
        }

        public ItemTablaISR(decimal límite_inferior, decimal límite_superior, decimal cuotaFija, decimal excedente, decimal subsidio, decimal iSR)
        {
            Límite_inferior = límite_inferior;
            Límite_superior = límite_superior;
            CuotaFija = cuotaFija;
            Excedente = excedente;
            Subsidio = subsidio;
            ISR = iSR;
        }

        public decimal Límite_inferior { get; set; }
        public decimal Límite_superior { get; set; }
        public decimal CuotaFija { get; set; }
        public decimal Excedente { get; set; }
        public decimal Subsidio { get; set; }
        public decimal ISR { get; set; }
    }
}
