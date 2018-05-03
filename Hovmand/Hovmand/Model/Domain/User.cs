namespace Hovmand.Model.App
{
    public class User
    {
        public User(int userID, string firstName, string lastName, string title)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }

        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }
    }
}