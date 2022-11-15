using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            // Carga de datos
            //cargaDatosManual();



            //Menu de opciones
            MenuDeOpciones(cargarDatos());

        }


        //Funciones

        public static void MenuDeOpciones(string[] personal)
        {
            int option;
            
            do
            {
                Console.WriteLine("::: Menu de opciones :::");
                Console.WriteLine("1. Mostrar lista");
                Console.WriteLine("2. Ascender personal");
                Console.WriteLine("   Presione cualquier tecla para salir");

                Console.Write("Seleccion:");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        //Lista de personal
                        mostrarListado(personal);
                        break;
                    case 2:
                        string codigo;
                        Console.Write("Ingrese el codigo de personal que quiere ascender:");
                        codigo = "codigo:" + Console.ReadLine();
                        
                        //var persona = personal.SingleOrDefault(st => st.Contains(codigo));
                        ascenderPersonal(personal, codigo);
                        break;
         
                }

            } while (option != 0);

        }

        public static string[] cargarDatos()
        {
            string[] personal = new string[] {"codigo:102,nombre: Maria Aibar,fechaNac:03-10-1994",
                                 "codigo:110,nombre: Jose Perez,fechaNac:02-02-1996, genteACargo: 5",
                                 "codigo:105,nombre: Raul Sanchez,fechaNac:15-09-2000, sucursalesACargo: 2",
                                 "codigo:151,nombre: Juan Cordoba,fechaNac:22-12-1992",
                                 "codigo:187,nombre: Pedro Luna,fechaNac:16-03-1990, sucursalesACargo: 5",
                                 "codigo:101,nombre: Lucas Baigorria,fechaNac:19-04-1981, genteACargo: 3"};

            return personal;
        }

        public static void mostrarListado(string[] personal)
        {
            Console.WriteLine();
            Console.WriteLine("Lista");
            for (int i = 0; i < personal.Length; i++)
            {
                Console.WriteLine(personal[i]);
            }
            Console.WriteLine();

        }

        public static void ascenderPersonal(string[] personal, string codigo)
        {
            for (int i = 0; i < personal.Length; i++)
            {
                //separa el string por comas
                string[] fragmentos = personal[i].Split(',');
                if (fragmentos[0].Equals(codigo))
                {
                    //ascender empleado
                    if (!personal[i].Contains("genteACargo") && !personal[i].Contains("sucursalesACargo"))
                    {
                        Console.Write("Cantidad de gente a cargo:");
                        string genteACargo = Console.ReadLine();
                        Console.WriteLine("Empleado ascendido a Supervisor");
                        personal[i] = personal[i] + $", genteACargo: {genteACargo}";
                        Console.WriteLine();
                    }
                    else if (personal[i].Contains("genteACargo"))
                    {
                        Console.Write("Cantidad de sucursales a cargo:");
                        string sucursalesACargo = Console.ReadLine();
                        Console.WriteLine("Supervisor ascendido a Encargado regional");
                        fragmentos[3] = $" sucursalesACargo: {sucursalesACargo}";
                        personal[i] = String.Join(",", fragmentos);
                        Console.WriteLine();
                    }
                    else if (personal[i].Contains("sucursalesACargo"))
                    {
                        Console.WriteLine("no se puede ascender a un Encargado regional");
                        Console.WriteLine();
                    }
                    

                }
            }
        }

        public static string[] cargaDatosManual()
        {
            string[] personal;
            int cantidad;
            int option;
            Console.WriteLine("::: Carga de personal :::");
            Console.Write("Ingrese la cantidad de personal:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            personal = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Personal: ");
                personal[i] = Console.ReadLine();
            }
            Console.WriteLine("Carga Finalizada!");


            return personal;


        }


    }



}
