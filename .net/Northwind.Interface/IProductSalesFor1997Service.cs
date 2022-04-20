using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Interface
{
    public interface IProductSalesFor1997Service : IGenericService<ProductSalesFor1997, DtoProductSalesFor1997>
    {
        IQueryable<DtoProductSalesFor1997> GetTotalReport();
    }
}
