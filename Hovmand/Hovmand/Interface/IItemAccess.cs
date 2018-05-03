using System.Collections.Generic;

namespace Hovmand.Interface
{
    public interface IItemAccess
    {
        void AddAccessType(string itemName, AccessType access);

        List<AccessType> GetaAccessTypes(string itemName);
    }
}
