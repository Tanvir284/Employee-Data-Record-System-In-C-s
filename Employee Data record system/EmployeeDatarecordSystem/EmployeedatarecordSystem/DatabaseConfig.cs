using System;
using System.Configuration;

namespace EmployeeManagementSystem
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            string env = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            if (!string.IsNullOrEmpty(env))
            {
                return env;
            }
            return ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString;
        }
    }
}
