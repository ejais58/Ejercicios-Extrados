using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_actualizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            int numero;
            int posicion;
            EliasList elias = new EliasList();
            do
            {
                Console.WriteLine(":::Menu de opciones:::");
                Console.WriteLine("1. agregar numero");
                Console.WriteLine("2. insertar numero");
                Console.WriteLine("3. eliminar numero");
                Console.WriteLine("4. buscar numero");
                Console.WriteLine("5. buscar numero por su indice");
                Console.WriteLine("   pulsar cualquier tecla para salir");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        Console.Write("ingrese un numero:");
                        int.TryParse(Console.ReadLine(), out numero);
                        elias.push(numero);
                        elias.mostrarLista();
                        break;
                    case 2:
                        Console.Write("ingrese la posicion que quiere ingresar el numero:");
                        int.TryParse(Console.ReadLine(), out posicion);
                        Console.Write("ingrese el numero que quiere colocar:");
                        int.TryParse(Console.ReadLine(), out numero);
                        elias.insert(numero, posicion);
                        elias.mostrarLista();
                        break;
                    case 3:
                        Console.Write("ingrese la posicion del numero que quiere eliminar:");
                        int.TryParse(Console.ReadLine(), out posicion);
                        elias.delete(posicion);
                        elias.mostrarLista();
                        break;
                    case 4:
                        Console.Write("ingrese el numero que quiere buscar:");
                        int.TryParse(Console.ReadLine(), out numero);
                        elias.seachForNumber(numero);
                        elias.mostrarLista();
                        break;
                    case 5:
                        Console.Write("ingrese el indice:");
                        int.TryParse(Console.ReadLine(), out posicion);
                        elias.seachForIndex(posicion);
                        break;
                }



            } while (option != 0);
        }
    }
}
