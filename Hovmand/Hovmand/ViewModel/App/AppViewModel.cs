using System;
using Windows.UI.Xaml.Controls;
using Commands.Implementation;
using ViewModel.App.Implementation;

namespace Hovmand.ViewModels.App
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
                AppFrame.Navigate(typeof(Views.App.OverviewPage));
            }));

            NavigationCommands.Add("LeadsView", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(Views.App.LeadPage));
            }));

            NavigationCommands.Add("CustomersView", new RelayCommand(() =>
            {
                AppFrame.Navigate(typeof(Views.App.CustomerPage));
            }));
        }
    }
}