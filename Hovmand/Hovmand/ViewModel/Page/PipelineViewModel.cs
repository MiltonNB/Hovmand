using System;
using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Data
{
    public class PipelineViewModel : DataViewModelBase<Pipeline>
    {
        public PipelineViewModel(Pipeline pipeline = null)
        {
            PipelineDomainObject = pipeline;
            CreateCommand = new CreateCommand<Pipeline>();
            DeleteCommand = new DeleteCommand<Pipeline>();
            UpdateCommand = new UpdateCommand<Pipeline>();
        }

        public Pipeline PipelineDomainObject { get; set; }

        public int PipelineId
        {
            get => PipelineDomainObject.PipelineId;
            set
            {
                PipelineDomainObject.PipelineId = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get => PipelineDomainObject.Status;
            set
            {
                PipelineDomainObject.Status = value;
                OnPropertyChanged();
            }
        }

        public string Information
        {
            get => PipelineDomainObject.Information;
            set
            {
                PipelineDomainObject.Information = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => PipelineDomainObject.Date;
            set
            {
                PipelineDomainObject.Date = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateLastEdit
        {
            get => PipelineDomainObject.DateLastEdit;
            set
            {
                PipelineDomainObject.DateLastEdit = value;
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