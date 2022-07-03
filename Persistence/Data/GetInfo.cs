using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public static class GetInfo
    {
        static GetInfo()
        {
        }

        public static DateTime GetServerDateNow()
        {
            CFG.ConfigReader.ReadConnectionString();
            using (var connection = new SqlConnection(CFG.ConfigReader._connectionStrings.MyConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT GETDATE()";
                return (DateTime)command.ExecuteScalar();
            }
        }

        public static string GetVersion()
        {
            CFG.ConfigReader.ReadConnectionString();
            using (var connection = new SqlConnection(CFG.ConfigReader._connectionStrings.MyConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT version FROM ver";
                return (string)command.ExecuteScalar();
            }
        }

        public static string GetUpdateLink()
        {
            CFG.ConfigReader.ReadConnectionString();
            using (var connection = new SqlConnection(CFG.ConfigReader._connectionStrings.MyConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT link FROM ver";
                return (string)command.ExecuteScalar();
            }
        }

    }
}
