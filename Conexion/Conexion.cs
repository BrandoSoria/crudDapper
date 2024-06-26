using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace crudDapper.Conexion
{
    public static class Conexion
    {
        public static IDbConnection Connection

        {
            get
            {
                return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            }

        }
    }
}