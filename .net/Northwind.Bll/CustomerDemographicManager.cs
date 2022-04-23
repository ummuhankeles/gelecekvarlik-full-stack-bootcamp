using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class CustomerDemographicManager : GenericManager<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService
    {
        public readonly ICustomerDemographicRepository customerDemographicRepository;
        public CustomerDemographicManager(IServiceProvider service) : base(service)
        {
            customerDemographicRepository = service.GetService<ICustomerDemographicRepository>();
        }

        public IQueryable<DtoCustomerDemographic> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
