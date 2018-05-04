using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;
using Hovmand.Model.Database;
using Hovmand.Model.Domain;
using Model.Implementation;

namespace Hovmand.Model.Catalog.Base
{
    public class CatalogBase<T> : EFCorePersistableCatalogAsync<HovmandDBContext, T, T, T> 
        where T : class, IStorable, ICopyable, new()
    {
        public override T CreateDomainObjectFromViewDataObject(T obj)
        {
            return obj;
        }

        public override T CreateViewDataObject(T obj)
        {
            return obj;
        }

        public override T CreatePersistentDataObject(T obj)
        {
            return obj;
        }

        public override T CreateDomainObjectFromPersistentDataObject(T obj)
        {
            return obj;
        }
    }
}