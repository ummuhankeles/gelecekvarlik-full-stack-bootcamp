using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Models;
using Northwnd.Entity.Base;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Entity.IBase;
using Northwnd.Interface;
using Northwnd.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwnd.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ApiBaseController<ICustomerService, Customer, DtoCustomer>
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("GetTotalReport")] //abc.com/api/customer/GetTotalReport
        public IResponse<IQueryable<DtoCustomer>> GetTotalReport()
        {
            try
            {
                return customerService.GetTotalReport();
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
