using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceServer.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                string connectionString = "";

                if (string.IsNullOrEmpty(envName)) 
                {
                    IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceServer.API"))
                 .AddJsonFile($"appsettings.json", optional: false)
                 .Build();

                    connectionString = configuration.GetConnectionString("PostgreSQL");
                }
                else
                {
                    IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceServer.API"))
                 .AddJsonFile($"appsettings.{envName}.json", optional: false)
                 .Build();
                    connectionString = configuration.GetConnectionString("PostgreSQL");
                }

                return connectionString;
            }
        }
    }
}
