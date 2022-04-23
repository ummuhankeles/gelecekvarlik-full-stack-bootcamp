using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Northwnd.Bll
{
    public class CategorySalesFor1997Manager : GenericManager<CategorySalesFor1997, DtoCategorySalesFor1997>, ICategorySalesFor1997Service
    {
        public readonly ICategorySalesFor1997Repository categorySalesFor1997Repository;

        public CategorySalesFor1997Manager(IServiceProvider service) : base(service)
        {
            categorySalesFor1997Repository = service.GetService<ICategorySalesFor1997Repository>();

        }

        public IQueryable<DtoCategorySalesFor1997> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
