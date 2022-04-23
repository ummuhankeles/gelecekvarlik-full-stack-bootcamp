using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class SupplierManager : GenericManager<Supplier, DtoSupplier>, ISupplierService
    {
        public readonly ISupplierRepository supplierRepository;

        public SupplierManager(IServiceProvider service) : base(service)
        {
            supplierRepository = service.GetService<ISupplierRepository>();
        }

        public IQueryable<DtoSupplier> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
