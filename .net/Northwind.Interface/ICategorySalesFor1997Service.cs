using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Interface
{
    public interface ICategorySalesFor1997Service : IGenericService<CategorySalesFor1997, DtoCategorySalesFor1997>
    {
        IQueryable<DtoCategorySalesFor1997> GetTotalReport();
    }
}
