using System;
using Windows.UI.Xaml.Controls;
using Commands.Implementation;
using ViewModel.App.Implementation;

namespace Hovmand.ViewModel.App
{
    public class AppViewModel : AppViewModelBase
    {
        private NavigationViewItem _selectedMenuItem;

        public AppViewModel()
        {
            _selectedMenuItem = null;
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
            NavigationCommands.Add("OverView", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.App.OverviewPage));
            }));

            NavigationCommands.Add("ActiveLeads", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.ActiveLeads));
            }));

            NavigationCommands.Add("PendingLeads", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.PendingLeads));
            }));
        
            NavigationCommands.Add("ClosedLeads", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.ClosedLeads));
            }));

            NavigationCommands.Add("Customers", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(View.Domain.CustomersPage));
            }));
        }
    }
}