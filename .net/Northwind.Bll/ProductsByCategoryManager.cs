using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class ProductsByCategoryManager : GenericManager<ProductsByCategory, DtoProductsByCategory>, IProductsByCategoryService
    {
        public readonly IProductsByCategoryRepository productsByCategoryRepository;

        public ProductsByCategoryManager(IServiceProvider service) : base(service)
        {
            productsByCategoryRepository = service.GetService<IProductsByCategoryRepository>();
        }
    }
}
