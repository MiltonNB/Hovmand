using System;
using System.Diagnostics;
using System.Windows.Input;
using Hovmand.Model.Catalog.Base;

namespace Hovmand.ViewModel.Commands
{
    public class ReadCommand<T> : ICommand where T : class
    {
        private CatalogBase<T> _catalogBase;

        public ReadCommand()
        {
            _catalogBase = new CatalogBase<T>();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }

        public event EventHandler CanExecuteChanged;
    }
}