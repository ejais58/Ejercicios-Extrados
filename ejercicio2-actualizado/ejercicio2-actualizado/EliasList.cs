using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_actualizado
{
    internal class EliasList
    {
        int[] lista;
        int contador;
        int tamanio;

        public EliasList()
        {
            contador = 5;
            tamanio = 5;
            lista = new int[5] { 0, 1, 2, 3, 4};
            
        }

        public void push( int numero)
        {
            if (contador == tamanio)
            {
                aumentarTamanioArray();
            }
            lista[contador] = numero;
            contador++;
        }

        public string insert(int numero, int posicion)
        
        {
            if (contador == tamanio) 
            {
                aumentarTamanioArray();
            }

            if (posicion > contador)
            {
                return "error: index inexistente en esta lista";
            }

            if (posicion == contador)
            {
                push(numero);
                return "Ok";
            }
            for (int i = contador; i > posicion; i--)
            {
                lista[i] = lista[i - 1];
            }

            lista[posicion] = numero;
            contador++;
            return "Ok";

        }

        public string delete(int posicion)
        {
            if (contador < posicion)
            {
                return "posicion no existe";
            }
            for (int i = posicion+1; i < contador+1; i++)
            {
                lista[i-1] = lista[i];
            }
            contador--;
            return "Ok";
        }

        public void seachForNumber( int numero)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == numero)
                {
                    Console.WriteLine("El numero ingresado esta en la posicion: {0}", i);
                }
            }

        }

        public void seachForIndex( int posicion)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (i == posicion)
                {
                    Console.WriteLine("El numero en la posicion {0} es: {1}", i, lista[i]);
                }
            }
        }

        public void aumentarTamanioArray()
        {
            int[] newList = new int[tamanio * 2];
            for (int i = 0; i < tamanio; i++)
            {
                newList[i] = lista[i];
            }
            lista = newList;
            tamanio = tamanio* 2;
        }

        public void mostrarLista()
        {
            for (int i = 0; i < lista.Length; i++)
            {

                Console.WriteLine($"{i}: {lista[i]}");

            }

        }
    }

    
}
