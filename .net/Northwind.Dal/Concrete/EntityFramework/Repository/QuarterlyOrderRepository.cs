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
    public class QuarterlyOrderRepository : GenericRepository<QuarterlyOrder>, IQuarterlyOrderRepository
    {
        public QuarterlyOrderRepository(DbContext context) : base(context)
        {
        }

        public IQueryable<QuarterlyOrder> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
