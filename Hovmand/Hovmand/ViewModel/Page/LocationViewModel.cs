using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Data
{
    public class LocationDataViewModel : DataViewModelBase<Location>
    {
        public LocationDataViewModel(Location domainObject = null)
        {
            LocationDomainObject = domainObject;
            CreateCommand = new CreateCommand<Location>();
            DeleteCommand = new DeleteCommand<Location>();
            UpdateCommand = new UpdateCommand<Location>();
        }

        public Location LocationDomainObject { get; set; }

        public int LocationId
        {
            get { return LocationDomainObject.LocationId; }
            set
            {
                LocationDomainObject.LocationId = value;
                OnPropertyChanged();
            }
        }

        public string Country
        {
            get { return LocationDomainObject.Country; }
            set
            {
                LocationDomainObject.Country = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return LocationDomainObject.City; }
            set
            {
                LocationDomainObject.City = value;
                OnPropertyChanged();
            }
        }

        public int Areacode
        {
            get { return LocationDomainObject.Areacode; }
            set
            {
                LocationDomainObject.Areacode = value;
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