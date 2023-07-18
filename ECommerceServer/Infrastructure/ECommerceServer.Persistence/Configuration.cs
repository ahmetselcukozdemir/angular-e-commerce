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
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceServer.API"))
                  .AddJsonFile($"appsettings.json", optional: false)
                  .Build();
                return configuration.GetConnectionString("PostgreSQL");
            }
        }
    }
}
