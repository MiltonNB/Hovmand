using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Data
{
    public class ProductViewModel : DataViewModelBase<Product>
    {
        public ProductViewModel(Product product = null)
        {
            ProductDomainObject = product;
            CreateCommand = new CreateCommand<Product>();
            DeleteCommand = new DeleteCommand<Product>();
            UpdateCommand = new UpdateCommand<Product>();
        }

        public Product ProductDomainObject { get; set; }

        public int ProductId
        {
            get => ProductDomainObject.ProductId;
            set
            {
                ProductDomainObject.ProductId = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => ProductDomainObject.Title;
            set
            {
                ProductDomainObject.Title = value;
                OnPropertyChanged();
            }
        }

        public string Information
        {
            get => ProductDomainObject.Information;
            set
            {
                ProductDomainObject.Information = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get => ProductDomainObject.Price;
            set
            {
                ProductDomainObject.Price = value;
                OnPropertyChanged();
            }
        }

        public int InStock
        {
            get => ProductDomainObject.InStock;
            set
            {
                ProductDomainObject.InStock = value;
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