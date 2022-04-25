using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class SummaryOfSalesByQuarterManager : GenericManager<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>, ISummaryOfSalesByQuarterService
    {
        public readonly ISummaryOfSalesByQuarterRepository summaryOfSalesByQuarterRepository;
        public SummaryOfSalesByQuarterManager(IServiceProvider service) : base(service)
        {
            summaryOfSalesByQuarterRepository = service.GetService<ISummaryOfSalesByQuarterRepository>();
        }
    }
}
