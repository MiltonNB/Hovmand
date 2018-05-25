using Hovmand.ViewModel.Base;

namespace Hovmand.ViewModel.Data
{
    public class LeadDataViewModel : DataViewModelBase
    {
        private Lead _domainObject;

        public LeadDataViewModel(Lead domainObject)
        {
            _domainObject = domainObject;
        }

        public Lead LeadDomainObject
        {
            get { return _domainObject; }
        }


    }
}