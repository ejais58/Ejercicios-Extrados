using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_recreado
{
    internal class EncargadoRegional : Personal
    {
        public string SucursalesACargo;

        public EncargadoRegional()
        {
            
        }

        public EncargadoRegional(int codigo, string nombre, string fechaNac, string SucursalesACargo) : base(codigo, nombre, fechaNac)
        {
            this.SucursalesACargo = SucursalesACargo;
        }

        public override string mostrarString()
        {
            return $"codigo: {this.Codigo}, nombre: {this.Nombre}, fecha de nacimiento: {this.FechaNac}, sucursales a cargo:{this.SucursalesACargo}";
        }



    }
}

