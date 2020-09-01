﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ReziRoster.API.Repositories.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(object id);
        IEnumerable<TEntity> GetByCustomExpression(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
