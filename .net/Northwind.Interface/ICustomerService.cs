using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Interface
{
    public interface ICustomerService : IGenericService<Customer, DtoCustomer>
    {
        IResponse<IQueryable<DtoCustomer>> GetTotalReport();
    }
}
