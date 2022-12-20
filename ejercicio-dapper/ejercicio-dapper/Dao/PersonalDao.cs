using Dapper;
using ejercicio_dapper.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_dapper.Dao
{
    public class PersonalDao
    {
        string connection = ConnectionString.MiCadena();
        public List<Personal> getListarPersonal()
        {
            var personal = new List<Personal>();

            string sqlQuery = "SELECT * FROM Personal";

            using (var db = new SqlConnection(connection))
            {
                
                personal = db.Query<Personal>(sqlQuery).ToList();
                
                foreach (var persona in personal)
                {
                    if (persona.GenteACargo == null && persona.SucursalesACargo == null)
                    {
                        Console.WriteLine($"EMPLEADO: Id: {persona.Id}, Nombre: {persona.Nombre}, Apellido: {persona.Apellido}, Fecha de nacimiento: {persona.FechaNacimiento}");
                    }
                    else if (persona.GenteACargo != null)
                    {
                        Console.WriteLine($"SUPERVISOR: Id: {persona.Id}, Nombre: {persona.Nombre}, Apellido: {persona.Apellido}, Fecha de nacimiento: {persona.FechaNacimiento}, Gente a cargo: {persona.GenteACargo}");
                    }
                    else
                    {
                        Console.WriteLine($"ENCARGADO REGIONAL: Id: {persona.Id}, Nombre: {persona.Nombre}, Apellido: {persona.Apellido}, Fecha de nacimiento: {persona.FechaNacimiento}, Sucursales a cargo: {persona.SucursalesACargo}");
                    }
                }
            }

            return personal;
        }

        public void postPersonal(Personal personal)
        {
            string sqlQuery = "INSERT INTO Personal(Id, Nombre, Apellido, FechaNacimiento, GenteACargo, SucursalesACargo) VALUES (@id,@nombre,@apellido,@fechaNac,@genteACargo,@sucursalesACargo)";

            using(var db = new SqlConnection(connection))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", personal.Id);
                parametros.Add("@nombre", personal.Nombre);
                parametros.Add("@apellido", personal.Apellido);
                parametros.Add("@fechaNac", personal.FechaNacimiento);
                parametros.Add("@genteACargo", personal.GenteACargo);
                parametros.Add("@sucursalesACargo", personal.SucursalesACargo);

                db.Execute(sqlQuery, parametros, commandType: CommandType.Text);
            }
        }

        public void updatePersonal(int id)
        {
            //Buscar por id
            string sqlQuery = "SELECT * FROM Personal WHERE Id = @id";

            using(var db = new SqlConnection(connection))
            {
                var personal = db.QueryFirstOrDefault<Personal>(sqlQuery, new {id = id});

                if (personal.GenteACargo == null && personal.SucursalesACargo == null)
                {
                    Console.WriteLine("Ascender Empleado a Supervisor");
                    Console.Write("Cantidad de gente a cargo: ");
                    int genteACargo = int.Parse(Console.ReadLine());
                    

                    //Actualizar base de datos
                    sqlQuery = $"UPDATE Personal SET GenteACargo = @genteACargo  WHERE Id = @id";

                    DynamicParameters parametros = new DynamicParameters();
                    parametros.Add("@genteACargo", genteACargo);
                    parametros.Add("@id", id);

                    db.Execute(sqlQuery, parametros, commandType: CommandType.Text);

                } 
                else if (personal.GenteACargo != null)
                {
                    Console.WriteLine("Ascender Supervisor a Encargado regional");
                    Console.Write("Cantidad de sucursales a cargo: ");
                    int sucursalesACargo = int.Parse(Console.ReadLine());

                    //Actualizar base de datos
                    sqlQuery = $"UPDATE Personal SET GenteACargo = NULL , SucursalesACargo = @sucursalesACargo WHERE Id = @id";

                    DynamicParameters parametros = new DynamicParameters();
                    parametros.Add("@sucursalesACargo", sucursalesACargo);
                    parametros.Add("@id", id);


                    db.Execute(sqlQuery, parametros, commandType: CommandType.Text);

                }
                else
                {
                    Console.WriteLine("No se puede ascender a un Encargado regional");
                }
            }
        }

        
        
    }
}
