using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_dapper.DataAccess
{
    public static class ConnectionString
    {
        public static string MiCadena()
        {
            return @"Data Source=DESKTOP-6UCTG52;Initial Catalog=Dapper;Persist Security Info=True;User ID=sa;Password=123456";
        }
    }
}
