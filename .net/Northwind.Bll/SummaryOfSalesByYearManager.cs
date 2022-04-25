using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class SummaryOfSalesByYearManager : GenericManager<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>, ISummaryOfSalesByYearService
    {
        public readonly ISummaryOfSalesByYearRepository summaryOfSalesByYearRepository;

        public SummaryOfSalesByYearManager(IServiceProvider service) : base(service)
        {
            summaryOfSalesByYearRepository = service.GetService<ISummaryOfSalesByYearRepository>();

        }
    }
}
