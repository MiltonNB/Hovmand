using System;
using System.Collections.Generic;
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
            var dialog = new MessageDialog("");
            
            PasswordHash pwHash = new PasswordHash();
            List<string> savedHashes = new List<string>(){ "09159038ffe1867b6188d79bfcd2335c19fc5364", "5bebf00777c11fe9fa1938c660a21bc6f0d3a64c", "40bd001563085fc35165329ea1ff5c5ecbdbbeef" };

            if (PasswordTextBox.Text != String.Empty && pwHash.MatchString(PasswordTextBox.Text, savedHashes))
                dialog.Title = "Correct password";
            else
                dialog.Title = "Wrong password";

            await dialog.ShowAsync();
        }
    }
}
