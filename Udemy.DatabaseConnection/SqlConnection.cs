﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Sql connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection closed");
        }
    }
}
