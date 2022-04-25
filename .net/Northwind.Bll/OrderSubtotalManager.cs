using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class OrderSubtotalManager : GenericManager<OrderSubtotal, DtoOrderSubtotal>, IOrderSubtotalService
    {
        public readonly IOrderSubtotalRepository orderSubtotalRepository;
        public OrderSubtotalManager(IServiceProvider service) : base(service)
        {
            orderSubtotalRepository = service.GetService<IOrderSubtotalRepository>();
        }
    }
}
