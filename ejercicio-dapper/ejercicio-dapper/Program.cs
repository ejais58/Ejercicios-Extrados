using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using System.Collections;
using System.Runtime.InteropServices;
using ejercicio_dapper.Dao;

namespace ejercicio_dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            PersonalDao personalDao = new PersonalDao();

            do
            {

                Console.WriteLine("::: Menu de opciones :::");
                Console.WriteLine("1. Mostrar lista de personal");
                Console.WriteLine("2. Agregar nuevo personal");
                Console.WriteLine("3. Ascender personal");
                Console.WriteLine("   Presione cualquier tecla para salir");

                Console.Write("Seleccion:");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        //Lista de personal
                        Console.WriteLine();
                        var personal = personalDao.getListarPersonal();
                        Console.WriteLine();
                        break;
                    case 2:
                        //Agregar personal
                        Personal person = new Personal();
                        Console.Write("Id: ");
                        person.Id = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        person.Nombre = Console.ReadLine();
                        Console.Write("Apellido: ");
                        person.Apellido = Console.ReadLine();
                        Console.Write("Fecha de nacimiento: ");
                        person.FechaNacimiento = DateTime.Parse(Console.ReadLine().Trim());
                        
                        tipoPersonal(person);

                        personalDao.postPersonal(person);
                        break;
                    case 3:
                        //Ascender personal
                        Console.Write("Id: ");
                        int id = int.Parse(Console.ReadLine());
                        personalDao.updatePersonal(id);
                        break;
                    case 4:
                        
                        break;
                }

            } while (option != 0);
            
        }

        public static void tipoPersonal(Personal personal)
        {
            Console.WriteLine("Tipo de personal: (1 empleado) (2 supervisor) (3 encargado regional)");
            Console.Write("seleccion:");
            string seleccion = Console.ReadLine();
            if (seleccion.Equals("2"))
            {
                Console.Write("Gente a cargo: ");
                personal.GenteACargo = int.Parse(Console.ReadLine());
            }
            else if (seleccion.Equals("3"))
            {
                Console.Write("Sucursales a cargo: ");
                personal.SucursalesACargo = int.Parse(Console.ReadLine());
            }
        }
    }
}
