﻿using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class OrderManager : GenericManager<Order, DtoOrder>, IOrderService
    {
        public readonly IOrderRepository orderRepository;
        public OrderManager(IServiceProvider service) : base(service)
        {
            orderRepository = service.GetService<IOrderRepository>();
        }

        public IQueryable<DtoOrder> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
