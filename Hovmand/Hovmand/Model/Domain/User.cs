using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public class User : DomainAppBase
    {
        public User(int key, int userID, string firstName, string lastName, string title, string email)
        {
            Key = key;
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Email = email;
        }

        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }
        public override void SetDefaultValues()
        {
            Key = NullKey;
        }
    }
}