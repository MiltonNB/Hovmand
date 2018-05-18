using Hovmand.Model.App;

namespace Hovmand.ViewModel.Data
{
    public class LoginPageViewModel
    {
        PasswordHash pwHash = new PasswordHash();
        public string Username
        {
            get { return null; }
        }

        public string Password
        {
            get { return pwHash.HashString(""); }
        }
    }
}