using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using Northwnd.Entity.DataTransferObject;
using Northwnd.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Northwnd.Bll
{
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;

        public UserManager(IServiceProvider service) : base(service)
        {
            userRepository = service.GetService<IUserRepository>();

        }
    }
}
