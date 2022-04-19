using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Bll
{
    public class CustomerManager : GenericManager<Customer, DtoCustomer>, ICustomerService
    {
        // ICustomerRepository
        public IQueryable<DtoCustomer> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
