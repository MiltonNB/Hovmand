using System.Collections.Generic;

namespace Hovmand.Interface
{
    public interface ISecurityService
    {
        bool UseLogin { get; set; }

        string CurrentEmail { get; set; }

        void AddUser(string email, string password, string userType);

        void AddItemAccessType(string itemName, AccessType accessType);

        void AddItemAccessTypes(string itemName, List<AccessType> accessTypes);

        void AddUserAccessRight(string userType, string itemName, AccessType accessType);

        bool IsActionAllowedForCurrentUser(string itemName);

        bool IsActionAllowed(string email, string itemName);
    }
}
