using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Commands.Implementation;
using Hovmand.Annotations;
using Hovmand.Model.Catalog.Base;
using Hovmand.Model.Database;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class ContactViewModel
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private HovmanddbContext dbContext = HovmanddbContext.Instance;
        private Contact _contact = new Contact();
        private CatalogBase<Contact> _contactCatalog;
        public ContactViewModel()
        {
            _contactCatalog = new CatalogBase<Contact>();
            CreateContactCommand = new RelayCommand(CreateContact);
            DeleteContactCommand = new RelayCommand(DeleteContact);
            UpdateContactCommand = new RelayCommand(UpdateContact);
        }

        public RelayCommand DeleteContactCommand { get; set; }
        public RelayCommand UpdateContactCommand { get; set; }
        public RelayCommand CreateContactCommand { get; set; }

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

        private void DeleteContact()
        {
            _contactCatalog.Delete(ContactId);
            dbContext.SaveChanges();
        }

        private void UpdateContact()
        {
            _contactCatalog.Update(_contact);
            dbContext.SaveChanges();
        }

        private void CreateContact()
        {
            _contactCatalog.Create(_contact);
            dbContext.SaveChanges();
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    }
