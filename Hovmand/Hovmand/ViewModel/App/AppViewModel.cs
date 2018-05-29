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

            // FileViewBar

            NavigationCommands.Add("Add", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(FileView));
            }));

            NavigationCommands.Add("Save", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(FileView));
            }));

            NavigationCommands.Add("Edit", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(FileView));
            }));

            NavigationCommands.Add("Delete", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(FileView));
            }));
        }
    }
}