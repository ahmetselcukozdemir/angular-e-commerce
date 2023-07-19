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
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
