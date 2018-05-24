using System.Collections.Generic;
using Hovmand.ViewModel.Base;

namespace Hovmand.ViewModel.Data
{
    public class CustomerDataViewModel : DataViewModelBase
    {
        private Customer _domainObject;

        public CustomerDataViewModel(Customer domainObject)
        {
            _domainObject = domainObject;
        }

        public Customer CustomerDomainObject
        {
            get { return _domainObject; }
        }

        public int CustomerId
        {
            get { return _domainObject.CustomerId; }
        }

        public int Cvr
        {
            get { return _domainObject.Cvr; }
            set
            {
                _domainObject.Cvr = value;
                OnPropertyChanged();
            }
        }

        public string CompanyName
        {
            get { return _domainObject.CompanyName; }
            set
            {
                _domainObject.CompanyName = value; 
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get { return _domainObject.Address; }
            set
            {
                _domainObject.Address = value;
                OnPropertyChanged();
            }
        }

        public int Phone
        {
            get { return _domainObject.Phone; }
            set
            {
                _domainObject.Phone = value;
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

        public int FkContactId
        {
            get { return _domainObject.FkContactId; }
        }

        public int FkLocationId
        {
            get { return _domainObject.FkLocationId; }
        }

        public Contact FkContact
        {
            get { return _domainObject.FkContact; }
        }

        public Location FkLocation
        {
            get { return _domainObject.FkLocation; }
        }

        public ICollection<Lead> Leads
        {
            get { return _domainObject.Leads; }
        }
    }
}