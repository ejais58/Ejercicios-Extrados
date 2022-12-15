using ejercicio_concurrencia.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio_concurrencia
{
    internal class Program
    {
        public static readonly object control = new object();
        static async Task Main(string[] args)
        {
            //Con lock
            //Thread t1 = new Thread(buscarMayorLock);
            //Thread t2 = new Thread(buscarMayorLock);
            //Thread t3 = new Thread(buscarMayorLock);
            //t1.Start();
            //t2.Start();
            //t3.Start();


            buscarMayorSincrono();

            buscarMayorAsincrono();
            



            Console.ReadLine();
        }

        public static void buscarMayorSincrono()
        {
            BuscadorMayorSincrono buscadorMayorSincrono = new BuscadorMayorSincrono();
            buscadorMayorSincrono.buscarMayor();
        }

        public static async void buscarMayorAsincrono()
        {
            BuscadorMayorAsincrono buscadorMayorAsincrono = new BuscadorMayorAsincrono();
            await buscadorMayorAsincrono.buscarMayorAsync();
            
        }

        public static void buscarMayorLock()
        {
            lock (control)
            {
               buscarMayorAsincrono();
            }
        }
        
    }
}
