﻿using System;
using System.Windows.Input;
using Hovmand.Model.Catalog.Base;

namespace Hovmand.ViewModel.Commands
{
    public class DeleteCommand<T> : ICommand where T : class
    {
        private CatalogBase<T> _catalogBase;

        public DeleteCommand()
        {
            _catalogBase = new CatalogBase<T>();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _catalogBase.Delete((T)parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}