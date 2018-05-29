using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Hovmand.Annotations;
using Hovmand.Model.Database;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class CustomerViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private CreateCommand<Customer> _createCommand = new CreateCommand<Customer>();
        private DeleteCommand<Customer> _deleteCommand = new DeleteCommand<Customer>();
        private ICommand _updateCommand = new UpdateCommand<Customer>();
        private HovmanddbContext dbContext = HovmanddbContext.Instance;
        private Customer _customer = new Customer(); 

        public CustomerViewModel()
        {
        }

        public Customer CustomerDomainObject
        {
            get
            {

                return _customer; 
            }
            set
            {
                _customer = value;
                OnPropertyChanged();
                Debug.WriteLine(_customer.CustomerId);
                _deleteCommand.RaiseCanExecuteChanged();
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

        public ICommand CreateCommand
        {
            get { return _createCommand; }
        }

        public ICommand DeleteCommand
        {
            get { return _deleteCommand; }
        }

        public ICommand UpdateCommand
        {
            get { return _updateCommand; }
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}