namespace Hovmand.Model.App
{
    public class User
    {
        private int _userID;
        private string _firstName;
        private string _lastName;
        private string _title;

        public User(int userID, string firstName, string lastName, string title)
        {
            _userID = userID;
            _firstName = firstName;
            _lastName = lastName;
            _title = title;
        }

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}