using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class CustomerAndSuppliersByCityManager : GenericManager<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        public readonly ICustomerAndSuppliersByCityRepository customerAndSuppliersByCityRepository;
        public CustomerAndSuppliersByCityManager(IServiceProvider service) : base(service)
        {
            customerAndSuppliersByCityRepository = service.GetService<ICustomerAndSuppliersByCityRepository>();
        }
    }
}
