using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.DatabaseConnection
{
    public class DbCommand
    {
        public DbConnection DatabaseConnection { get; private set; }

        public string Command { get; private set; }

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection != null && command != string.Empty)
            {
                DatabaseConnection = dbConnection;
                Command = command;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void Execute()
        {
            DatabaseConnection.Open();
            Console.WriteLine("Ran the command - {0} ", Command);
            DatabaseConnection.Close();
        }
    }
}
