using System;
using Windows.UI.Xaml.Controls;
using Commands.Implementation;
using ViewModel.App.Implementation;
using Hovmand.View.App;

namespace Hovmand.ViewModel.App
{
    public class AppViewModel : AppViewModelBase
    {
        private NavigationViewItem _selectedMenuItem;
        public static AppViewModel AppVm;

        public AppViewModel()
        {
            _selectedMenuItem = null;
            AppVm = this;
        }

        public NavigationViewItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                _selectedMenuItem = value;
                if (_selectedMenuItem == null) return;

                string tag = _selectedMenuItem.Tag.ToString();

                if (!NavigationCommands.ContainsKey(tag))
                {
                    throw new ArgumentException($"Menu entry {tag} has no matching navigation command");
                }

                NavigationCommands[tag].Execute(null);
            }
        }

        public override void AddCommands()
        {
            NavigationCommands.Add("LeadsPage", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.LeadsPage));
            }));

            NavigationCommands.Add("ActiveLeads", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.LeadsPage));
            }));

            NavigationCommands.Add("PendingLeads", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.LeadsPage));
            }));
        
            NavigationCommands.Add("ClosedLeads", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.LeadsPage));
            }));

            NavigationCommands.Add("Customers", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.CustomersPage));
            }));

            NavigationCommands.Add("Customer", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.CustomerPage));
            }));
        }
    }
}