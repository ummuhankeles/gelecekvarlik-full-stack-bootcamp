using Microsoft.EntityFrameworkCore;
using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Dal.Concrete.EntityFramework.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public IQueryable<Product> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
