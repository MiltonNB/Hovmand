using ViewModel.Data.Implementation;

namespace Hovmand.ViewModel.Data
{
    public class ContactDataViewModel : DataViewModelBase<Contact>
    {
        public ContactDataViewModel(Contact obj) : base (obj)
        {
            
        }

        public int ContactId
        {
            get { return DataObject.ContactId; }
            set
            {
                DataObject.ContactId = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get { return DataObject.Firstname; }
            set
            {
                DataObject.Firstname = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return DataObject.Lastname; }
            set
            {
                DataObject.Lastname = value;
                OnPropertyChanged();
            }
        }

        public string Mail
        {
            get { return DataObject.Mail; }
            set
            {
                DataObject.Mail = value;
                OnPropertyChanged();
            }
        }

        public int? Phone
        {
            get { return DataObject.Phone; }
            set
            {
                DataObject.Phone = value;
                OnPropertyChanged();
            }
        }
    }
}