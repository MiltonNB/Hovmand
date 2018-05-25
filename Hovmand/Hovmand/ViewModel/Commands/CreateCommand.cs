using System;
using System.ServiceModel.Channels;
using System.Windows.Input;
using Windows.UI.Popups;
using Hovmand.Model.Catalog.Base;
using Hovmand.ViewModel.Base;

namespace Hovmand.ViewModel.Commands
{
    public class CreateCommand<T> : ICommand where T : class
    {
        private CatalogBase<T> _catalogBase;
        private DataViewModelBase<T> _dataViewModelBase;

        public CreateCommand(DataViewModelBase<T> dataViewModelBase)
        {
            _catalogBase = new CatalogBase<T>();
            _dataViewModelBase = dataViewModelBase;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _catalogBase.Create(_dataViewModelBase.DomainObject);
        }

        public event EventHandler CanExecuteChanged;
    }
}