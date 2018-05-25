using System.Windows.Input;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class CustomerPageViewModel
    {
        private ICommand _createCommand;

        public CustomerPageViewModel()
        {
            _createCommand = new CreateCommand<Customer>();
        }
    }
}