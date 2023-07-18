using ECommerceServer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceServer.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceDBContext>
    {
        public ECommerceDBContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerceDBContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<ECommerceDBContext>();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new ECommerceDBContext(dbContextOptionsBuilder.Options);
        } 
    }
}
