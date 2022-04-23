using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class SalesByCategoryManager : GenericManager<SalesByCategory, DtoSalesByCategory>, ISalesByCategoryService
    {
        public readonly ISalesByCategoryRepository salesByCategoryRepository;

        public SalesByCategoryManager(IServiceProvider service) : base(service)
        {
            salesByCategoryRepository = service.GetService<ISalesByCategoryRepository>();

        }

        public IQueryable<DtoSalesByCategory> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
