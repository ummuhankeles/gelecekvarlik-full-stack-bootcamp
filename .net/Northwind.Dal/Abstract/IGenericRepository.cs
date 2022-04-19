﻿using Northwnd.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Dal.Abstract
{
    public interface IGenericRepository<T> where T:IEntityBase
    {
        // listeleme
        List<T> GetAll();

        // filtreeli listeleme
        List<T> GetAll(Expression<Func<T, bool>> expression); // bu yapı dinamik where sağlar

        // getirme
        T Find(int id);

        // kaydetme
        T Add(T item);

        // async kaydetme
        Task<T> AddAsync(T item);

        // güncelleme
        T Update(T item);

        // silme
        bool Delete(int id);

        bool Delete(T item);

        // iqueryable listeleme
        IQueryable<T> GetQueryable();
    }
}
