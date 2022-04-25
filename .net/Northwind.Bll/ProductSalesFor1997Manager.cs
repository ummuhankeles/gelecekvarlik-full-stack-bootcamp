using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class ProductSalesFor1997Manager : GenericManager<ProductSalesFor1997, DtoProductSalesFor1997>, IProductSalesFor1997Service
    {
        public readonly IProductSalesFor1997Repository productSalesFor1997Repository;
        public ProductSalesFor1997Manager(IServiceProvider service) : base(service)
        {
            productSalesFor1997Repository = service.GetService<IProductSalesFor1997Repository>();
        }
    }
}
