using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace Northwnd.Bll
{
    public class CategoryManager : GenericManager<Category, DtoCategory>, ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;
        public CategoryManager(IServiceProvider service) : base(service)
        {
            categoryRepository = service.GetService<ICategoryRepository>();
        }

        public IQueryable<DtoCategory> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
