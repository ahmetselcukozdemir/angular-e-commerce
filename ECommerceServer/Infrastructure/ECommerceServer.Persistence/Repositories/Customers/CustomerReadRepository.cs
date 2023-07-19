using ECommerceServer.Application.Repositories;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceServer.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
