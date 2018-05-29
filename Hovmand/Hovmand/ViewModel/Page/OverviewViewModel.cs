using System.Windows.Input;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class OverviewViewModel
    {
        private CreateCommand<Lead> _createCommand = new CreateCommand<Lead>();
        private DeleteCommand<Lead> _deleteCommand = new DeleteCommand<Lead>();
        private UpdateCommand<Lead> _updateCommand = new UpdateCommand<Lead>();

        public ICommand CreateCommand
        {
            get { return _createCommand; }
        }

        public ICommand DeleteCommand
        {
            get { return _deleteCommand; }
        }

        public ICommand UpdateCommand
        {
            get { return _updateCommand; }
        }
    }
}