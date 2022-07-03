using System;
using Microsoft.Extensions.Configuration;

namespace Persistence.CFG
{
    public class ConfigReader : Object
    {
        static ConfigReader()
        {

        }

        public static DB.ConnectionStrings _connectionStrings =
                        new DB.ConnectionStrings();

        public static void ReadConnectionString()
        {
            var configurationBuilder =
              new Microsoft.Extensions.Configuration.ConfigurationBuilder()
              .SetBasePath(basePath: System.IO.Directory.GetCurrentDirectory())
              .AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
              .Build()
              ;

            configurationBuilder
              .GetSection(key: "ConnectionStrings")
              .Bind(instance: _connectionStrings)
              ;

        }

        public static DB.DatabaseContext ReadDB()
        {
            ReadConnectionString();
            return (new DB.DatabaseContext(connectionString: _connectionStrings.MyConnectionString));
        }
    }
}
