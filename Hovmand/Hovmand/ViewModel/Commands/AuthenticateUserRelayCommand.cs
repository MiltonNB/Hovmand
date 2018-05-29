using System;
using Windows.UI.Xaml.Controls;
using Commands.Implementation;
using Hovmand.Model.App;
using Hovmand.Model.Database;

namespace Hovmand.ViewModel.Commands
{
    public class AuthenticateUserRelayCommand : RelayCommand
    {
        private PasswordHash pwHash;
        private HovmanddbContext dbContext;


        public AuthenticateUserRelayCommand(Action execute) : base(execute)
        {
            
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public AuthenticateUserRelayCommand(Action execute, Func<bool> canExecute) : base(execute, canExecute)
        {
        }
    }
}