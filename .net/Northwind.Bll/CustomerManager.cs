using Microsoft.AspNetCore.Http;
using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.Base;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Entity.IBase;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Northwnd.Bll
{
    public class CustomerManager : GenericManager<Customer, DtoCustomer>, ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerManager(IServiceProvider service) : base(service)
        {
            customerRepository = service.GetService<ICustomerRepository>();
        }

        public IResponse<IQueryable<DtoCustomer>> GetTotalReport()
        {
            try
            {
                var list = customerRepository.GetTotalReport();
                var listDto = list.Select(x => ObjectMapper.Mapper.Map<DtoCustomer>(x));

                return new Response<IQueryable<DtoCustomer>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = listDto
                };
            }
            catch (Exception ex)
            {

                return new Response<IQueryable<DtoCustomer>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

    }
}
