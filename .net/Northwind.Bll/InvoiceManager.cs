using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll
{
    public class InvoiceManager : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        public readonly IInvoiceRepository ınvoiceRepository;
        public InvoiceManager(IServiceProvider service) : base(service)
        {
            ınvoiceRepository = service.GetService<IInvoiceRepository>();
        }

        public IQueryable<DtoInvoice> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
