using System;
using System.Collections.Generic;
using System.Diagnostics;
using Hovmand.Model.Database;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Parsing;

namespace Hovmand.Model.Catalog.Base
{
    public class CatalogBase<T> where T : class
    {
        private HovmanddbContext _dbContext;

        public CatalogBase()
        {
            _dbContext = HovmanddbContext.Instance;
        }

        public void Create(T obj)
        {
            _dbContext.Set<T>().Add(obj);
        }

        public object Read(int key)
        {
            return _dbContext.Set<T>().Find(key);
        }

        public void Update(T obj)
        {
            _dbContext.Set<T>().Update(obj);
        }

        public void Delete(T obj)
        {
            _dbContext.Set<T>().Remove(obj);
        }
    }
}