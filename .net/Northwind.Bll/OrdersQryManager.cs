using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class OrdersQryManager : GenericManager<OrdersQry, DtoOrdersQry>, IOrdersQryService
    {
        public readonly IOrdersQryRepository ordersQryRepository;
        public OrdersQryManager(IServiceProvider service) : base(service)
        {
            ordersQryRepository = service.GetService<IOrdersQryRepository>();
        }

        public IQueryable<DtoOrdersQry> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
