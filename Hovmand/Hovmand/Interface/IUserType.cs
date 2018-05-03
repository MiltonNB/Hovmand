using System.Collections.Generic;

namespace Hovmand.Interface
{
    public interface IUserType
    {
        void AddUserType(string userType);

        void AddAccessRight(string userType, string itenName, AccessType accessType);

        List<AccessType> GetAccessRights(string userType, string itemName);

        bool HasAccessRight(string userType, string itemName, AccessType accessType);
    }
}