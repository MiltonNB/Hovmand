namespace Hovmand.Model.App
{
    public class User
    {
        public User(int userID, string firstName, string lastName, string title, string email)
        {
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
    }
}