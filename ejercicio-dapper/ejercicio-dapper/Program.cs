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
                Console.WriteLine("1. Mostrar lista");
                Console.WriteLine("2. Agregar Personal");
                Console.WriteLine("3. Eliminar personal");
                Console.WriteLine("4. Buscar personal");
                Console.WriteLine("   Presione cualquier tecla para salir");

                Console.Write("Seleccion:");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        //Lista de personal
                        var personal = personalDao.getListarPersonal();
                        foreach (var persona in personal)
                        {
                            Console.WriteLine($"Id: {persona.Id}, Nombre: {persona.Nombre}, Apellido: {persona.Apellido}");
                        }
                        break;
                    case 2:
                        
                        break;
                    case 3:

                        break;
                    case 4:
                        
                        break;
                }

            } while (option != 0);
            
        }
    }
}
