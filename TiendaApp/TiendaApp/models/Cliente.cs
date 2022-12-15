using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TiendaApp.models
{
    internal class Cliente
    {
        public string Cuil_Cuit { get; set; }
        public string NombreCompleto { get; set; }
        public int Deuda { get; set; }

        public Cliente()
        {

        }

        public override string ToString()
        {
            return $"cuit/cuil: {this.Cuil_Cuit}, nombre completo: {this.NombreCompleto}, deauda: {this.Deuda}";
        }
    }
}
