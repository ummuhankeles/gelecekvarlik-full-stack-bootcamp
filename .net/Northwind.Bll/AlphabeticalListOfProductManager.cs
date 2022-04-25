using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Northwnd.Bll
{
    public class AlphabeticalListOfProductManager : GenericManager<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>, IAlphabeticalListOfProductService
    {
        public readonly IAlphabeticalListOfProductRepository alphabeticalListOfProductRepository;
        public AlphabeticalListOfProductManager(IServiceProvider service) : base(service)
        {
            alphabeticalListOfProductRepository = service.GetService<IAlphabeticalListOfProductRepository>();
        }
    }
}
