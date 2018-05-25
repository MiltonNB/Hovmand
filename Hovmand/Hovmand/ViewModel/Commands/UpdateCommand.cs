using System;
using System.Windows.Input;
using Windows.ApplicationModel.Contacts;
using Hovmand.Model.Catalog.Base;

namespace Hovmand.ViewModel.Commands
{
    public class UpdateCommand<T> : ICommand where T : class
    {
        private CatalogBase<T> _catalogBase;

        public UpdateCommand()
        {
            _catalogBase = new CatalogBase<T>();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _catalogBase.Update((T)parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}