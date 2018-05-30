using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Windows.UI.Popups;
using Commands.Implementation;
using Hovmand.Annotations;
using Hovmand.Model.Catalog.Base;
using Hovmand.Model.Database;
using Hovmand.ViewModel.App;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class CustomerViewModel : INotifyCollectionChanged
    {
        private HovmanddbContext _dbContext = HovmanddbContext.Instance;
        private Customer _customer = new Customer();
        private CatalogBase<Customer> _customerCatalog;
        private AppViewModel appVm;

        public CustomerViewModel()
        {
            _customerCatalog = new CatalogBase<Customer>();
            DeleteCustomerCommand = new RelayCommand(DeleteCustomer);
            NavUpdateCustomerCommand = new RelayCommand(NavUpdateCustomer);
            NavCreateCustomerCommand = new RelayCommand(NavCreateCustomer);
            NavCancelCreationCommand = new RelayCommand(NavCancelCreation);
            SaveCustomerCommand = new RelayCommand(SaveCustomer);
            appVm = AppViewModel.AppVm;
            Customers.CollectionChanged += CollectionChanged;
            _dbContext.SaveChanges();
        }

        public RelayCommand DeleteCustomerCommand { get; set; }
        public RelayCommand SaveCustomerCommand { get; set; }
        public RelayCommand NavUpdateCustomerCommand { get; set; }
        public RelayCommand NavCreateCustomerCommand { get; set; }
        public RelayCommand NavCancelCreationCommand { get; set; }

        public Customer CustomerDomainObject
        {
            get => _customer;
            set
            {
                _customer = value;
                OnPropertyChanged();
            }
        }

        public int CustomerId
        {
            get { return _customer.CustomerId; }
        }

        public int Cvr
        {
            get { return CustomerDomainObject.Cvr; }
            set
            {
                CustomerDomainObject.Cvr = value;
                OnPropertyChanged();
            }
        }

        public string CompanyName
        {
            get { return CustomerDomainObject.CompanyName; }
            set
            {
                CustomerDomainObject.CompanyName = value; 
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get { return CustomerDomainObject.Address; }
            set
            {
                CustomerDomainObject.Address = value;
                OnPropertyChanged();
            }
        }

        public int Phone
        {
            get { return CustomerDomainObject.Phone; }
            set
            {
                CustomerDomainObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Mail
        {
            get { return CustomerDomainObject.Mail; }
            set
            {
                CustomerDomainObject.Mail = value; 
                OnPropertyChanged();
            }
        }

        public int FkContactId
        {
            get { return CustomerDomainObject.FkContactId; }
            set
            {
                CustomerDomainObject.FkContactId = value;
                OnPropertyChanged();
            }
        }

        public int FkLocationId
        {
            get { return CustomerDomainObject.FkLocationId; }
            set
            {
                CustomerDomainObject.FkLocationId = value;
                OnPropertyChanged();
            }
        }

        public Contact FkContact
        {
            get { return CustomerDomainObject.FkContact; }
            set
            {
                CustomerDomainObject.FkContact = value;
                OnPropertyChanged();
            }
        }

        public Location FkLocation
        {
            get { return CustomerDomainObject.FkLocation; }
            set
            {
                CustomerDomainObject.FkLocation = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Customer> Customers
        {
            get { return new ObservableCollection<Customer>(_dbContext.Customers);}
        }

        private void SaveCustomer()
        {
            var customer = new Customer()
            {
                Cvr = Cvr,
                CompanyName = CompanyName,
                Address = Address,
                Phone = Phone,
                Mail = Mail,
                FkContactId = 4,
                FkLocationId = 4,
            };
            _customerCatalog.Create(customer);
            _dbContext.SaveChanges();
            NavCancelCreation();
        }

        private async void DeleteCustomer()
        {
            var dialog = new MessageDialog("Are you sure you want to delete?", "Delete");
            int NO = 0;
            int YES = 1;

            dialog.Commands.Add(new UICommand { Label = "No", Id = NO });
            dialog.Commands.Add(new UICommand { Label = "Yes", Id = YES });

            var result = await dialog.ShowAsync();
            if ((int)result.Id == 0)
                return;
            if (CustomerId == 0)
                return;

            _customerCatalog.Delete(CustomerId);
            _dbContext.SaveChanges();
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            NavCancelCreation();
        }

        private void NavUpdateCustomer()
        {
            appVm.NavigationCommands["Customer"].Execute(null);
        }

        private void NavCreateCustomer()
        {
            appVm.NavigationCommands["Customer"].Execute(null);
        }

        private void NavCancelCreation()
        {
            appVm.NavigationCommands["Customers"].Execute(null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}