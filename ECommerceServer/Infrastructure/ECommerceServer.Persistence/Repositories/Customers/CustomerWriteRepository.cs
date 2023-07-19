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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
