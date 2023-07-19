using ECommerceServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceServer.Application.Repositories
{
    public interface IProductWriteRepository : IWriteRepository<Product>
    {
    }
}
