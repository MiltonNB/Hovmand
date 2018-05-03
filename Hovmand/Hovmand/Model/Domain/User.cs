namespace Hovmand.Model.Domain
{
    public class User
    {
        public User(int userID, string firstName, string lastName, string title, string email, string password)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Email = email;
            Password = password;
        }

        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}