using System.Collections.Generic;
using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Data
{
    public class CustomerDataViewModel : DataViewModelBase<Customer>
    {
        public CustomerDataViewModel(Customer domainObject = null)
        {
            CustomerDomainObject = domainObject;
            CreateCommand = new CreateCommand<Customer>();
            DeleteCommand = new DeleteCommand<Customer>();
            UpdateCommand = new UpdateCommand<Customer>();
        }

        public Customer CustomerDomainObject { get; set; }

        public int CustomerId
        {
            get { return CustomerDomainObject.CustomerId; }
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

        public ICommand CreateCommand
        {
            get { return CreateCommand; }
            set { CreateCommand = value; }
        }

        public ICommand DeleteCommand
        {
            get { return DeleteCommand; }
            set { DeleteCommand = value; }
        }

        public ICommand UpdateCommand
        {
            get { return UpdateCommand; }
            set { UpdateCommand = value; }
        }
    }
}