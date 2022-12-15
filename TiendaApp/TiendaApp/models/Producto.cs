using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaApp.models
{
    internal class Producto
    {
        public int CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioContado { get; set; }
        public double PrecioVenta { get; set; }

        
    }
}
