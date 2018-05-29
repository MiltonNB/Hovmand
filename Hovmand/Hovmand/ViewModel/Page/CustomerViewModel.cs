using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Commands.Implementation;
using Hovmand.Annotations;
using Hovmand.Model.Catalog.Base;
using Hovmand.Model.Database;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class CustomerViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private HovmanddbContext dbContext = HovmanddbContext.Instance;
        private Customer _customer = new Customer();
        private CatalogBase<Customer> _customerCatalog;

        public CustomerViewModel()
        {
            _customerCatalog = new CatalogBase<Customer>();
            DeleteCustomerCommand = new RelayCommand(DeleteCustomer);
            UpdateCustomerCommand = new RelayCommand(UpdateCustomer);
            CreateCustomerCommand = new RelayCommand(CreateCustomer);
        }

        public RelayCommand DeleteCustomerCommand { get; set; }
        public RelayCommand UpdateCustomerCommand { get; set; }
        public RelayCommand CreateCustomerCommand { get; set; }

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

        public List<Customer> Customers
        {
            get { return dbContext.Customers.ToList(); }
        }

        public void DeleteCustomer()
        {
            _customerCatalog.Delete(CustomerId);
            dbContext.SaveChanges();
        }

        public void UpdateCustomer()
        {
    
        }

        public void CreateCustomer()
        {
            
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}