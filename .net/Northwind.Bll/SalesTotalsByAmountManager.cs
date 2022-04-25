using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace Northwnd.Bll
{
    public class SalesTotalsByAmountManager : GenericManager<SalesTotalsByAmount, DtoSalesTotalsByAmount>, ISalesTotalsByAmountService
    {
        public readonly ISalesTotalsByAmountRepository salesTotalsByAmountRepository;

        public SalesTotalsByAmountManager(IServiceProvider service) : base(service)
        {
            salesTotalsByAmountRepository = service.GetService<ISalesTotalsByAmountRepository>();
        }
    }
}
