using System;

namespace Udemy.DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }

        public TimeSpan Timeout { get; private set; }

        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public abstract void Open();

        public abstract void Close();
    }
}
