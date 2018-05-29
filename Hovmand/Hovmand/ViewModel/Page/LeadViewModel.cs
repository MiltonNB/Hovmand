using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class LeadViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private CreateCommand<Lead> _createCommand = new CreateCommand<Lead>();
        private DeleteCommand<Lead> _deleteCommand = new DeleteCommand<Lead>();
        private UpdateCommand<Lead> _updateCommand = new UpdateCommand<Lead>();

        public LeadViewModel()
        {

        }

        public Lead LeadDomainObject { get; set; }

        public int LeadId
        {
            get { return LeadDomainObject.LeadId;}
            set
            {
                LeadDomainObject.LeadId = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get { return LeadDomainObject.Status; }
            set
            {
                LeadDomainObject.Status = value;
                OnPropertyChanged();
            }
        }

        public string Information
        {
            get { return LeadDomainObject.Information; }
            set
            {
                LeadDomainObject.Information = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateAdded
        {
            get { return LeadDomainObject.DateAdded; }
            set
            {
                LeadDomainObject.DateAdded = value;
                OnPropertyChanged();
            }
        }

        public int? FkCustomersId
        {
            get { return LeadDomainObject.FkCustomersId; }
            set
            {
                LeadDomainObject.FkCustomersId = value;
                OnPropertyChanged();
            }
        }

        public int? FkUserId
        {
            get { return LeadDomainObject.FkUserId; }
            set
            {
                LeadDomainObject.FkUserId = value;
                OnPropertyChanged();
            }
        }

        public int? FkPipeLineId
        {
            get { return LeadDomainObject.FkPipelineId; }
            set
            {
                LeadDomainObject.FkPipelineId = value;
                OnPropertyChanged();
            }
        }

        public Customer FkCustomer
        {
            get { return LeadDomainObject.FkCustomers; }
            set
            {
                LeadDomainObject.FkCustomers = value;
                OnPropertyChanged();
            }
        }

        public User FkUser
        {
            get { return LeadDomainObject.FkUser; }
            set
            {
                LeadDomainObject.FkUser = value;
                OnPropertyChanged();
            }
        }

        public Pipeline FkPipeline
        {
            get { return LeadDomainObject.FkPipeline; }
            set
            {
                LeadDomainObject.FkPipeline = value;
                OnPropertyChanged();
            }
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

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}