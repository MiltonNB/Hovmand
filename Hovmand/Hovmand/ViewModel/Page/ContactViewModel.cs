using System.Collections.Generic;
using System.Windows.Input;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class ContactViewModel : Base.DataViewModelBase<Contact>
    {
        public ContactViewModel(Contact contact = null)
        {
            ContactDomainObject = contact;
            CreateCommand = new CreateCommand<Contact>();
            DeleteCommand = new DeleteCommand<Contact>();
            UpdateCommand = new UpdateCommand<Contact>();
        }

        public Contact ContactDomainObject { get; set; }

        public int ContactId
        {
            get { return ContactDomainObject.ContactId; }
            set
            {
                ContactDomainObject.ContactId = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get { return ContactDomainObject.Firstname; }
            set
            {
                ContactDomainObject.Firstname = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return ContactDomainObject.Lastname; }
            set
            {
                ContactDomainObject.Lastname = value;
                OnPropertyChanged();
            }
        }

        public string Mail
        {
            get { return ContactDomainObject.Mail; }
            set
            {
                ContactDomainObject.Mail = value;
                OnPropertyChanged();
            }
        }

        public int? Phone
        {
            get { return ContactDomainObject.Phone; }
            set
            {
                ContactDomainObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public ICollection<Customer> Customers
        {
            get { return ContactDomainObject.Customers; }
            set
            {
                ContactDomainObject.Customers = value;
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