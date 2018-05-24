using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Hovmand.Model.Catalog.Base;
using Hovmand.Model.Catalog.DomainCatalogs;
using Hovmand.Model.Database;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Hovmand.Views.App
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
            HovmanddbContext context = HovmanddbContext.Instance;
            
            Product product = new Product()
            {
                Information = "",
                InStock = 1,
                Price = 2.0,
                Title = "",
            };

            User user = new User()
            {
                Email = "",
                Firstname = "",
                Lastname = "",
                Password = "",
                Title = "",
            };

            Lead lead = new Lead()
            {
                DateAdded = DateTime.Now,
                Information = "",
                Status = ""
            };

            Offer offer = new Offer()
            {
                Date = DateTime.Now,
                Information = "w2123",
                Price = 2.0,
                ProductAmount = 1,
                FkLeadId = 1,
                FkProductId = 1,
            };

            //context.Products.Add(product);
            //context.Users.Add(user);
            //context.Leads.Add(lead);
            //context.Offers.Add(offer);
            CatalogBase<Type> cb = new CatalogBase<Type>();

            cb.Create(offer);



            await context.SaveChangesAsync();
            Debug.WriteLine("Saved successfully.");
        }
    }
}
