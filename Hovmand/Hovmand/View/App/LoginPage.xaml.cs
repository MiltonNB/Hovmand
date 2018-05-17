using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Hovmand.Model.App;
using Hovmand.Model.Database;
using Hovmand.Model.Domain;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Hovmand.View.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            //ErrorMessage.Text = "";
            CheckPW();
        }

        private void ForgotPasswordButton_Click(object sender, PointerRoutedEventArgs e)
        {
            ErrorMessage.Text = "";
        }

        //TODO-Midlertidigt showcase. 

        private async void CheckPW()
        {
            HovmanddbContext dbContext = new HovmanddbContext();
            var n = new User
            {
                Email = "heq2j2@gmail.com",
                Firstname = "Per",
                Lastname = "Anton",
                Password = "22",
                Title = "Manager",
            };
            await dbContext.Users.AddAsync(n);
            Debug.WriteLine($"Added {n}");
            await dbContext.SaveChangesAsync();
            foreach (var VARIABLE in dbContext.Users)
            {
                Debug.WriteLine(VARIABLE.Firstname);
                Debug.Write($"{VARIABLE.UserId} + {VARIABLE.Key}");
            }
        }
    }
}
