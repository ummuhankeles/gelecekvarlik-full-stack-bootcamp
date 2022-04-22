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
    public class SalesByCategoryRepository : GenericRepository<SalesByCategory>, ISalesByCategoryRepository
    {
        public SalesByCategoryRepository(DbContext context) : base(context)
        {
        }

        public IQueryable<SalesByCategory> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
