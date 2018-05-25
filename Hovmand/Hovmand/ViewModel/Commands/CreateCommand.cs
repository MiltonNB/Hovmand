using System;
using System.ServiceModel.Channels;
using System.Windows.Input;
using Windows.UI.Popups;
using Hovmand.Model.Catalog.Base;

namespace Hovmand.ViewModel.Commands
{
    public class CreateCommand<T> : ICommand where T : class
    {
        private CatalogBase<T> _catalogBase;

        public CreateCommand()
        {
            _catalogBase = new CatalogBase<T>();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            try
            {
                _catalogBase.Create((T)parameter);
            }
            catch (InvalidCastException c)
            {
                var dialog = new MessageDialog($"Error converting {parameter.ToString()} to {typeof(T)}", $"{c}");
                await dialog.ShowAsync();
                throw;
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}