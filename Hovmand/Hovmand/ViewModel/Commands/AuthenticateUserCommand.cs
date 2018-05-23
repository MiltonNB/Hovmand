using System;
using System.Windows.Input;

namespace Hovmand.ViewModel.Commands
{
    public class AuthenticateUserCommand : ICommand
    {
        public ICommand AuthenticateUser
        {
            get { return new AuthenticateUserCommand();}
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            //throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}