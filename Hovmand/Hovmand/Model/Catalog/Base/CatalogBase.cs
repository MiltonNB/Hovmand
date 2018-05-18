using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;
using Hovmand.Model.Database;
using Hovmand.Model.Domain;
using Model.Implementation;

namespace Hovmand.Model.Catalog.Base
{
    public class CatalogBase<T>
    {
        public void Create(T obj)
        {
            //todo
        }

        public T Read(int key)
        {
            return default(T);
        }

        public void Update(T obj, int key)
        {
            //todo
        }

        public void Delete(int key)
        {
            //todo
        }
    }
}