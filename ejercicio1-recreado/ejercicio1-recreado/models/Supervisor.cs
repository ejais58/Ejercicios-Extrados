using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_recreado
{
    internal class Supervisor : Personal
    {
        public string GenteACargo;

        public Supervisor() 
        {
                   
        }

        public Supervisor(int codigo, string nombre, string fechaNac, string genteACargo):base(codigo,nombre,fechaNac)
        {
           this.GenteACargo = genteACargo;
        }

       

        public override string mostrarString()
        {
            return $"codigo: {this.Codigo}, nombre: {this.Nombre}, fecha de nacimiento: {this.FechaNac}, gente a cargo:{this.GenteACargo}";
        }



    }
}
