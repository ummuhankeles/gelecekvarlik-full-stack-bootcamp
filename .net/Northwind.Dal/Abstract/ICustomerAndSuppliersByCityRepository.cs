using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Dal.Abstract
{
    public interface ICustomerAndSuppliersByCityRepository
    {
        IQueryable<CustomerAndSuppliersByCity> GetTotalReport();
     }
}
