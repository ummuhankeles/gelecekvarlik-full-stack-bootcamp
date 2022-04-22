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
    public class ProductSalesFor1997Repository : GenericRepository<ProductSalesFor1997>, IProductSalesFor1997Repository
    {
        public ProductSalesFor1997Repository(DbContext context) : base(context)
        {
        }

        public IQueryable<ProductSalesFor1997> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
