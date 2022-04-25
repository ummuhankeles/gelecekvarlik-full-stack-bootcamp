using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Northwnd.Bll
{
    public class TerritoryManager : GenericManager<Territory, DtoTerritory>, ITerritoryService
    {
        public readonly ITerritoryRepository territoryRepository;

        public TerritoryManager(IServiceProvider service) : base(service)
        {
            territoryRepository = service.GetService<ITerritoryRepository>();
        }
    }
}
