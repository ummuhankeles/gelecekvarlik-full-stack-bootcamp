using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class EmployeeManager : GenericManager<Employee, DtoEmployee>, IEmployeeService
    {
        public IEmployeeRepository employeeRepository;
        public EmployeeManager(IServiceProvider service) : base(service)
        {
            employeeRepository = service.GetService<IEmployeeRepository>();
        }

        public IQueryable<DtoEmployee> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
