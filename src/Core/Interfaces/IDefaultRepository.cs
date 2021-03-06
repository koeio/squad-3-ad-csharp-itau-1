﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TryLog.Core.Interfaces
{
    public interface IDefaultRepository<T>
    {
        void Add(T entity);
        T Get(T entity);
        List<T> Find(Expression<Func<T, bool>> predicate);
        void SaveOrUpdate(T entity);
        void Delete(T entity);
    }
}
