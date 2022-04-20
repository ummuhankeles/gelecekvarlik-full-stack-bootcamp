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
    public class CustomerDemographicManager : GenericManager<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService
    {
        public IQueryable<DtoCustomerDemographic> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
