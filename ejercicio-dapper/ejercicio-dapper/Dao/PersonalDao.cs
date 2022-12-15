using Dapper;
using ejercicio_dapper.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_dapper.Dao
{
    public class PersonalDao
    {
        public List<Personal> getListarPersonal()
        {
            var personal = new List<Personal>();

            string connection = ConnectionString.MiCadena();

            string sqlQuery = "SELECT Id, Nombre, Apellido FROM Personal";

            using (var db = new SqlConnection(connection))
            {
                
                personal = db.Query<Personal>(sqlQuery).ToList();
                
            }

            return personal;
        }

        
        
    }
}
