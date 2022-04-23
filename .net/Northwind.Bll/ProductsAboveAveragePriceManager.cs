using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class ProductsAboveAveragePriceManager : GenericManager<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>, IProductsAboveAveragePriceService
    {
        public readonly IProductsAboveAveragePriceRepository productsAboveAveragePriceRepository;
        public ProductsAboveAveragePriceManager(IServiceProvider service) : base(service)
        {
            productsAboveAveragePriceRepository = service.GetService<IProductsAboveAveragePriceRepository>();
        }

        public IQueryable<DtoProductsAboveAveragePrice> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
