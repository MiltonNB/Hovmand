using System.Diagnostics;
using Hovmand.Model.Database;
using Microsoft.EntityFrameworkCore;

namespace Hovmand.Model.Catalog.Base
{
    public class CatalogBase<T>
    {
        private HovmanddbContext _dbContext;

        public CatalogBase()
        {
            _dbContext = new HovmanddbContext();
        }

        public void Create(object obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public T Read(int key)
        {
            return default(T);
        }

        public void Update(object obj, int key)
        {
            //todo
        }

        public void Delete(int key)
        {
            //todo
        }
    }
}