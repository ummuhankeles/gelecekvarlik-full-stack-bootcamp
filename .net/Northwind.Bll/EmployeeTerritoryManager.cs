using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class EmployeeTerritoryManager : GenericManager<EmployeeTerritory, DtoEmployeeTerritory>, IEmployeeTerritoryService
    {
        public readonly IEmployeeTerritoryRepository employeeTerritoryRepository;
        public EmployeeTerritoryManager(IServiceProvider service) : base(service)
        {
            employeeTerritoryRepository = service.GetService<IEmployeeTerritoryRepository>();
        }
    }
}
