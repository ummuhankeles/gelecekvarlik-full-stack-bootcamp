using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Interface
{
    public interface IShipperService : IGenericService<Shipper, DtoShipper>
    {
        IQueryable<DtoShipper> GetTotalReport();
    }
}
