using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Northwnd.Bll
{
    public class QuarterlyOrderManager : GenericManager<QuarterlyOrder, DtoQuarterlyOrder>, IQuarterlyOrderService
    {
        public readonly IQuarterlyOrderRepository quarterlyOrderRepository;
        public QuarterlyOrderManager(IServiceProvider service) : base(service)
        {
            quarterlyOrderRepository = service.GetService<IQuarterlyOrderRepository>();
        }
    }
}
