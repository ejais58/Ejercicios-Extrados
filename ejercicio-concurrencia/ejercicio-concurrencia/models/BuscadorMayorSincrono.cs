using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_concurrencia.models
{
    internal class BuscadorMayorSincrono
    {
        public List<int> listaNumerosEnteros = new List<int>();
        public int[] arrayNumerosEnteros;
        public int mayor = 0;
        public int posicion;
        public Stopwatch sw = new Stopwatch();

        public BuscadorMayorSincrono()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                listaNumerosEnteros.Add(random.Next(11));
            }

            listaNumerosEnteros.Insert(random.Next(11), 11);

            mostrarLista();

            arrayNumerosEnteros = listaNumerosEnteros.ToArray();

            
        }


        public void buscarMayor()
        {
            sw.Start();
            

            for (int i = 0; i < arrayNumerosEnteros.Length; i++)
            {
                if (arrayNumerosEnteros[i] > mayor)
                {
                    mayor = arrayNumerosEnteros[i];
                    posicion = i;
                }
            }

            sw.Stop();

            Console.WriteLine($"El mayor numero es: {mayor} y esta en la posicion: {posicion}");
            Console.WriteLine($"Tiempo transcurrido: {sw.Elapsed}");
        }

        public void mostrarLista()
        {
            foreach (var item in listaNumerosEnteros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
