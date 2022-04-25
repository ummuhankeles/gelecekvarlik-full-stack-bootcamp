using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class OrderDetailManager : GenericManager<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        public readonly IOrderDetailRepository orderDetailRepository;
        public OrderDetailManager(IServiceProvider service) : base(service)
        {
            orderDetailRepository = service.GetService<IOrderDetailRepository>();
        }
    }
}
