namespace Hovmand.Model.App
{
    public class User
    {
        private string _userID;
        private string _firstName;
        private string _lastName;
        private string _title;

        public User(string userID, string firstName, string lastName, string title)
        {
            _userID = userID;
            _firstName = firstName;
            _lastName = lastName;
            _title = title;
        }
    }
}