using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using crudDapper.Tables;

namespace crudDapper.Conexion
{
    public class Conexion
    {
        private IDbConnection Connection

        {
            get
            {
                return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            }

        }

        public IEnumerable<Employee> GetEmployees()
        {

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Employee>("SELECT * FROM employee");
            }


        }
    }
}
