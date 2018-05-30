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
            if (obj != null)
                _dbContext.Set<T>().Add(obj);
        }

        public object Read(int key)
        {
            if (key != 0)
                return _dbContext.Set<T>().Find(key);
            return null;
        }

        public void Update(T obj)
        {
            if (obj != null)
                _dbContext.Set<T>().Update(obj);
        }

        public void Delete(int key)
        {
            if (key != 0)
            {
                var obj = _dbContext.Set<T>().Find(key);
                _dbContext.Set<T>().Remove(obj);
            }
        }
    }
}