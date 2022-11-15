using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_recreado
{
    internal class Personal : EliasList
    {
        
        public int Codigo;
        public string Nombre;
        public string FechaNac;
      
        
        public Personal():base()
        {
            
        }

        public Personal( int codigo, string nombre, string fechaNac)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.FechaNac = fechaNac;
            
        }

        

        public virtual string mostrarString()
        {
            return $"codigo: {this.Codigo}, nombre: {this.Nombre}, fecha de nacimiento: {this.FechaNac}";
        }


    }
}
