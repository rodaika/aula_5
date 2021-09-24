﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace App.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where);
        void Save(TEntity obj);
        void Update(TEntity obj);
        void Delete(Guid id);
        int SaveChanges();
        DbContext Context();
    }
}
