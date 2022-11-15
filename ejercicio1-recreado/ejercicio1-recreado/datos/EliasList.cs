using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_recreado
{
    internal class EliasList
    {
        public string[] lista;
        public int contador;
        public int tamanio;

        public EliasList()
        {
            this.contador = 0;
            this.tamanio = 1;
            this.lista = new string[1];

        }

        public virtual void push(string personal)
        {
            if (contador == tamanio)
            {
                aumentarTamanioArray();
            }
            
            lista[contador] = personal;
            contador++;
        }

        

        

        public string delete(int posicion)
        {
            if (contador < posicion)
            {
                return "posicion no existe";
            }
            for (int i = posicion + 1; i < contador + 1; i++)
            {
                lista[i - 1] = lista[i];
            }
            contador--;
            return "Ok";
        }

        public void deleteForCodigo(int codigo)
        {
            for (int i = 0; i < contador + 1; i++)
            {
                if (lista[i].Contains(codigo.ToString()))
                {
                    lista[i - 1] = lista[i];
                }
                contador--;
            }
        }

        //public void seachForNumber(int numero)
        //{
        //    for (int i = 0; i < lista.Length; i++)
        //    {
        //        if (lista[i] == numero)
        //        {
        //            Console.WriteLine("El numero ingresado esta en la posicion: {0}", i);
        //        }
        //    }

        //}

        public void seachForIndex(int posicion)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (i == posicion)
                {
                    Console.WriteLine("El numero en la posicion {0} es: {1}", i, lista[i]);
                }
            }
        }

        public void seachForName(string nombre)
        {
            for(int i = 0; i < lista.Length; i++)
            {
                if (lista[i].Contains(nombre))
                {
                    Console.WriteLine(lista[i]);
                }
            }
        }

        public void aumentarTamanioArray()
        {
            string[] newList = new string[tamanio * 2];
            for (int i = 0; i < tamanio; i++)
            {
                newList[i] = lista[i];
            }
            lista = newList;
            tamanio = tamanio * 2;
        }

        public virtual void mostrarLista()
        {
            for (int i = 0; i < lista.Length; i++)
            {

                Console.WriteLine($"{i}: {lista[i]}");

            }

        }
    }


}

