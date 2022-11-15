
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_recreado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            string nombre;
            int codigo;
            EliasList lista = new EliasList();


            do
            {
                
                Console.WriteLine("::: Menu de opciones :::");
                Console.WriteLine("1. Mostrar lista");
                Console.WriteLine("2. agregar personal");
                Console.WriteLine("3. Eliminar personal");
                Console.WriteLine("4. Buscar personal");
                Console.WriteLine("   Presione cualquier tecla para salir");

                Console.Write("Seleccion:");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        //Lista de personal
                        lista.mostrarLista();
                        break;
                    case 2:
                        opcionesPersonal(lista);
                        
                        break;
                    case 3:
                        
                        Console.Write("Ingrese el codigo de personal que quiere eliminar:");
                        codigo = int.Parse(Console.ReadLine());
                        lista.deleteForCodigo(codigo);
                        break;
                    case 4:
                        Console.Write("Ingrese el nombre de la persona que quiere buscar: ");
                        nombre = Console.ReadLine();
                        lista.seachForName(nombre);
                        break;                }

            } while (option != 0);
        
           
        }
        public static void opcionesPersonal(EliasList lista)
        {

            Random r = new Random();
            int codigo;
            string nombre;
            string fechaNac;
            string genteACargo;
            string sucursalesACargo;
            int option;
            do
            {

                Console.WriteLine("---------------------");
                Console.WriteLine("1. cargar empleado");
                Console.WriteLine("2. cargar supervisor");
                Console.WriteLine("3. cargar encargado regional");
                Console.WriteLine("   Presione cualquier tecla para salir");

                Console.Write("Seleccion:");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:

                        codigo = r.Next(100, 200);
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Fecha de nacimiento: ");
                        fechaNac = Console.ReadLine();
                        Personal empleado = new Personal(codigo, nombre, fechaNac);
                        lista.push(empleado.mostrarString());
                        break;
                    case 2:
                        
                        codigo = r.Next(100, 200);
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Fecha de nacimiento: ");
                        fechaNac = Console.ReadLine();
                        Console.Write("Gente a cargo: ");
                        genteACargo = Console.ReadLine();
                        Personal supervisor = new Supervisor(codigo,nombre, fechaNac, genteACargo);
                        lista.push(supervisor.mostrarString());
                        break;
                    case 3:

                        codigo = r.Next(100, 200);
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Fecha de nacimiento: ");
                        fechaNac = Console.ReadLine();
                        Console.Write("Sucursales a cargo: ");
                        sucursalesACargo = Console.ReadLine();
                        Personal encargado = new EncargadoRegional(codigo, nombre, fechaNac, sucursalesACargo);
                        lista.push(encargado.mostrarString());
                        break;

                }

            } while (option != 0);

        }
    }
}
