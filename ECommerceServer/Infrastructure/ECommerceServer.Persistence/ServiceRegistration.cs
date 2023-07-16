﻿using Microsoft.EntityFrameworkCore;
using ECommerceServer.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceServer.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceDBContext>(options=> options.UseNpgsql("User ID=root;Password=myPassword;Host=localhost;Port=49153;Database=ECommerceDB;"));
        }
    }
}
