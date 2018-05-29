using System;
using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class OfferViewModel : DataViewModelBase<Offer>
    {

        public OfferViewModel(Offer offer = null)
        {
            OfferDomainObject = offer;
            CreateCommand = new CreateCommand<Offer>();
            DeleteCommand = new DeleteCommand<Offer>();
            UpdateCommand = new UpdateCommand<Offer>();
        }

        public Offer OfferDomainObject { get; set; }

        public int OfferId
        {
            get => OfferDomainObject.OfferId;
            set
            {
                OfferId = value;
                OnPropertyChanged();
            }
        }

        public string Information
        {
            get => OfferDomainObject.Information;
            set
            {
                OfferDomainObject.Information = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get => OfferDomainObject.Price;
            set
            {
                OfferDomainObject.Price = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => OfferDomainObject.Date;
            set
            {
                OfferDomainObject.Date = value;
                OnPropertyChanged();
            }
        }

        public int ProductAmount
        {
            get => OfferDomainObject.ProductAmount;
            set
            {
                OfferDomainObject.ProductAmount = value;
                OnPropertyChanged();
            }
        }

        public int FkProductId
        {
            get => OfferDomainObject.FkProductId;
            set
            {
                OfferDomainObject.FkProductId = value;
                OnPropertyChanged();
            }
        }

        public int FkLeadId
        {
            get => OfferDomainObject.FkLeadId;
            set
            {
                OfferDomainObject.FkLeadId = value;
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