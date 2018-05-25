using System;
using System.Windows.Input;
using Hovmand.Model.Catalog.Base;

namespace Hovmand.ViewModel.Commands
{
    public class CreateCommand : ICommand
    {
        private CatalogBase<Contact> _contactCatalog;

        public CreateCommand(CatalogBase<Contact> contactCatalog)
        {
            _contactCatalog = contactCatalog;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _contactCatalog.Create(new Contact()
            {
                Firstname = "",

            });
        }

        public event EventHandler CanExecuteChanged;
    }
}