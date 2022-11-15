using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class EliasList
    {
        public int[] lista { get; set; }
        int contador;
        int tamanio;

        //constructor
        public EliasList()
        {
            this.contador = 0;
            this.tamanio = 5;
            this.lista = new int[tamanio];

        }
        public void push(int[] lista, int numero)
        {

            if(this.contador == this.tamanio)
            {
                aumentarTamanioArray(lista);
            }
            lista[this.contador] = numero;
            this.contador++;


        }

        public string insert(int[] lista, int numero, int posicion)
        {
            if (this.contador == this.tamanio)
            {
                aumentarTamanioArray(lista);
            }

            if (posicion > this.contador)
            {
               return "La posicion no existe en este array";
            }
            if (posicion == this.contador)
            {
                push(lista, numero);
                return "ok";
            }
            for (int i = this.contador + 1; i > posicion - 1; i--)
            {
                lista[i] = lista[i - 1];
            }
            lista[posicion - 1] = numero;
            this.contador++;
            return "Ok";


        }

        public string delete(int[] lista, int posicion)
        {
            if (this.contador < posicion)
            {
                return "posicion no existe";
            }
            for (int i = posicion; i < this.contador; i++)
            {
                lista[i - 1] = lista[i];
            }
            this.contador--;
            return "Ok";
        }

        public void seachForNumber(int[] lista, int numero)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == numero)
                {
                    Console.WriteLine("El numero ingresado esta en la posicion: {0}", i);
                }
            }

        }

        public void seachForIndex(int[] lista, int posicion)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (i == posicion)
                {
                    Console.WriteLine("El numero en la posicion {0} es: {1}", i, lista[i]);
                }
            }
        }



        public void mostrarLista(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
               
                Console.WriteLine($"{i}: {lista[i]}");
                    
            }

         }
        

        
        public bool validarEspacioVacio()
        {
            bool bandera = true;
            for (int i = 0; i < lista.Length; i++)
            {
                /*cero representa a espacio vacio.
                 * mientras la contenido lista sea igual a cero, se pueden seguir agregando datos*/
                if (lista[i] == 0)
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
            }
            return bandera;
        }

        public int[] aumentarTamanioArray(int[] lista)
        {
            int[] newList = new int[this.tamanio * 2];
            for (int i = 0; i < this.tamanio; i++)
            {
                newList[i] = lista[i];
            }
            lista = newList;
            this.tamanio *= 2;
            return lista;
        }
    }
}
