using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class ShipperManager : GenericManager<Shipper, DtoShipper>, IShipperService
    {
        public readonly IShipperRepository shipperRepository;
        public ShipperManager(IServiceProvider service) : base(service)
        {
            shipperRepository = service.GetService<IShipperRepository>();

        }
    }
}
