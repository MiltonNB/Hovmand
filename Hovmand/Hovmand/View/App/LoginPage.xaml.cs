using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Hovmand.Model.App;
using Hovmand.Model.Catalog.Base;
using Hovmand.Model.Catalog.DomainCatalogs;
using Hovmand.Model.Database;
using Hovmand.ViewModel.Page;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Hovmand.View.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private HovmanddbContext dbContext;
        private PasswordHash pwHash;
        private List<User> userList;
        private Task task;

        public LoginPage()
        {
            this.InitializeComponent();
            dbContext = HovmanddbContext.Instance;
            pwHash = new PasswordHash();
            task = new Task(() => userList = dbContext.Users.ToList());
            task.Start();
            UsernameTextBox.Text = "admin";
            PasswordTextBox.Text = "admin";
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            CheckPW();
        }

        private void ForgotPasswordButton_Click(object sender, PointerRoutedEventArgs e)
        {
            ErrorMessage.Text = "";
        }   

        //TODO-Midlertidigt showcase. 

        private async void CheckPW()
        {
            task.Wait();

            string passwordH = pwHash.HashString(this.PasswordTextBox.Text);
            bool successfulLogin = false;

            foreach (var user in userList)
            {
                if (user.Email == this.UsernameTextBox.Text && user.Password == passwordH)
                    successfulLogin = true;
            }

            if (successfulLogin)
                this.Frame.Navigate(typeof(MainPage));
            else
            {
                var dialog = new MessageDialog("Wrong email/password.");
                await dialog.ShowAsync();
            }
        }
    }
}
