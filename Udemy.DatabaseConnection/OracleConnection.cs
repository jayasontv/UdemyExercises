using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection closed");
        }
    }
}
