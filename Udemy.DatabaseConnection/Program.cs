using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("Sql connection string");
            var dbCommnad = new DbCommand(sqlConnection, "Sql select");
            dbCommnad.Execute();

            var oracleConnection = new OracleConnection("Oracle connection string");
            dbCommnad = new DbCommand(oracleConnection, "Oracle select");
            dbCommnad.Execute();

            Console.ReadLine();
        }
    }
}
