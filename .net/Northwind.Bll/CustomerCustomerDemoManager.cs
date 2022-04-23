using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class CustomerCustomerDemoManager : GenericManager<CustomerCustomerDemo, DtoCustomerCustomerDemo>, ICustomerCustomerDemoService
    {
        public readonly ICustomerCustomerDemoRepository customerCustomerDemoRepository;
        public CustomerCustomerDemoManager(IServiceProvider service) : base(service)
        {
            customerCustomerDemoRepository = service.GetService<ICustomerCustomerDemoRepository>();
        }

        public IQueryable<DtoCustomerCustomerDemo> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
