using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Northwnd.Bll
{
    public class CurrentProductListManager : GenericManager<CurrentProductList, DtoCurrentProductList>, ICurrentProductListService
    {
        public readonly ICurrentProductListRepository currentProductListRepository;
        public CurrentProductListManager(IServiceProvider service) : base(service)
        {
            currentProductListRepository = service.GetService<ICurrentProductListRepository>();
        }

        public IQueryable<DtoCurrentProductList> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
