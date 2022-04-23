using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class OrderDetailsExtendedManager : GenericManager<OrderDetailsExtended, DtoOrderDetailsExtended>, IOrderDetailsExtendedService
    {
        public readonly IOrderDetailsExtendedRepository orderDetailsExtendedRepository;
        public OrderDetailsExtendedManager(IServiceProvider service) : base(service)
        {
            orderDetailsExtendedRepository = service.GetService<IOrderDetailsExtendedRepository>();
        }

        public IQueryable<DtoOrderDetailsExtended> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
