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
    }
}