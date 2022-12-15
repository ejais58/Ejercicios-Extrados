using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaApp.models
{
    internal class Tienda
    {
        public double MargenDeGanancia { get; set; }
        public double IVA { get; set; }
        public double DeudaMaxima { get; set; }


        public Tienda(double margenDeGanancia, double iVA, double deudaMaxima)
        {
            this.MargenDeGanancia = margenDeGanancia;
            this.IVA = iVA;
            this.DeudaMaxima = deudaMaxima;
        }
    }
}
