using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ConnectionUtils
{
    class SqliteConnectionFactory : ConnectionFactory
    {
        public override IDbConnection createConnection(IDictionary<string, string> properties)
        {
            String connectionString = properties["ConnectionString"];
            Console.WriteLine("SQLite ---Se deschide o conexiune la  ... {0}", connectionString);
            return new SQLiteConnection(connectionString);
           

        }
    }
}
