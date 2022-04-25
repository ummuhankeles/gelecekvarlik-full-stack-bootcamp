using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class ProductManager : GenericManager<Product, DtoProduct>, IProductService
    {
        public readonly IProductRepository productRepository;
        public ProductManager(IServiceProvider service) : base(service)
        {
            productRepository = service.GetService<IProductRepository>();
        }
    }
}
