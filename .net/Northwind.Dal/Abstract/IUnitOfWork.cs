using Northwnd.Entity.Base;
using System;

namespace Northwnd.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;

        bool BeginTransection(); // transection başlatma
        bool RollBackTransection(); // hata durumunda sürecin geri alınmasını sağlayan işlem
        int SaveChanges(); // transection onaylama
    }
}
