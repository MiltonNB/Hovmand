using System;
using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class LeadViewModel : DataViewModelBase<Lead>
    {
        public LeadViewModel(Lead domainObject = null)
        {
            LeadDomainObject = domainObject;
            CreateCommand = new CreateCommand<Lead>();
            DeleteCommand = new DeleteCommand<Lead>();
            UpdateCommand = new UpdateCommand<Lead>();
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