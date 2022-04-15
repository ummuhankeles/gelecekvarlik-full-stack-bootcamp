using AutoMapper;
using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, DtoCustomer>().ReverseMap();
        }
    }
}
