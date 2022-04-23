using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace Northwnd.Bll
{
    public class RegionManager : GenericManager<Region, DtoRegion>, IRegionService
    {
        public readonly IRegionRepository regionRepository;
        public RegionManager(IServiceProvider service) : base(service)
        {
            regionRepository = service.GetService<IRegionRepository>();
        }

        public IQueryable<DtoRegion> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
