using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_concurrencia.models
{
    internal class BuscadorMayorAsincrono : BuscadorMayorSincrono
    {
        int longitudMedia;
        object control = new object();
        public async Task buscarMayorAsync()
        {

            sw.Start();

            await tareas();

            sw.Stop();
            
            Console.WriteLine($"El mayor numero es: {mayor} y esta en la posicion: {posicion}");
            Console.WriteLine($"Tiempo transcurrido: {sw.Elapsed}");
        }

        public async Task tareas() {
            Task t1 = Task.Run(() => primerArray());
            Task t2 = Task.Run(() => segundoArray());
            await Task.WhenAll(t1,t2);
        }
        public void primerArray()
        {
            
            for (int i = 0; i < arrayNumerosEnteros.Length / 2; i++)
            {
                if (arrayNumerosEnteros[i] > mayor)
                {
                    lock (control)
                    {
                        if (arrayNumerosEnteros[i] > mayor)
                        {
                            mayor = arrayNumerosEnteros[i];
                            posicion = i;
                        }
                    }
                    
                }
            }
            
            longitudMedia = arrayNumerosEnteros.Length / 2;
            
        }

        public void segundoArray()
        {
            
            for (int i = longitudMedia; i < arrayNumerosEnteros.Length; i++)
            {
                if (arrayNumerosEnteros[i] > mayor)
                {
                    lock (control)
                    {
                        if (arrayNumerosEnteros[i] > mayor)
                        {
                            mayor = arrayNumerosEnteros[i];
                            posicion = i;
                        }
                    }
                }
            }
            
        }

        

       

        

        


    }
}
