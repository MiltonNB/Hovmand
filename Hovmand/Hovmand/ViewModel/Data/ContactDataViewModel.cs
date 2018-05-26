using System.Collections.Generic;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Hovmand.ViewModel.Base;
using ViewModel.Data.Implementation;
using System;

namespace Hovmand.ViewModel.Data
{
    public class ContactDataViewModel : Base.DataViewModelBase<Contact>
    {
        private Contact _domainObject;

        public ContactDataViewModel(Contact domainObject)
        {
            _domainObject = domainObject;
        }

        public Contact ContactDomainObject
        {
            get { return _domainObject; }
        }

        public int ContactId
        {
            get { return _domainObject.ContactId; }

        }

        public string FirstName
        {
            get { return _domainObject.Firstname; }
            set
            {
                _domainObject.Firstname = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _domainObject.Lastname; }
            set
            {
                _domainObject.Lastname = value;
                OnPropertyChanged();
            }
        }

        public string Mail
        {
            get { return _domainObject.Mail; }
            set
            {
                _domainObject.Mail = value;
                OnPropertyChanged();
            }
        }

        public int? Phone
        {
            get { return _domainObject.Phone; }
            set
            {
                _domainObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public ICollection<Customer> Customers
        {
            get { return _domainObject.Customers; }
            set
            {
                _domainObject.Customers = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }
    }
}