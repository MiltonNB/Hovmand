using System.Windows.Input;
using Hovmand.ViewModel.Base;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Data
{
    public class UserViewModel : DataViewModelBase<User>
    {
        public UserViewModel(User user = null)
        {
            UserDomainObject = user;
            CreateCommand = new CreateCommand<User>();
            DeleteCommand = new DeleteCommand<User>();
            UpdateCommand = new UpdateCommand<User>();
        }

        public User UserDomainObject { get; set; }

        public int UserId
        {
            get => UserDomainObject.UserId;
            set
            {
                UserDomainObject.UserId = value;
                OnPropertyChanged();
            }
        }

        public string Firstname
        {
            get => UserDomainObject.Firstname;
            set
            {
                UserDomainObject.Firstname = value;
                OnPropertyChanged();
            }
        }

        public string Lastname
        {
            get => UserDomainObject.Lastname;
            set
            {
                UserDomainObject.Lastname = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => UserDomainObject.Title;
            set
            {
                UserDomainObject.Title = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => UserDomainObject.Email;
            set
            {
                UserDomainObject.Email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => UserDomainObject.Password;
            set
            {
                UserDomainObject.Password = value;
                OnPropertyChanged();
            }
        }

        public ICommand CreateCommand
        {
            get { return CreateCommand; }
            set { CreateCommand = value; }
        }

        public ICommand DeleteCommand
        {
            get { return DeleteCommand; }
            set { DeleteCommand = value; }
        }

        public ICommand UpdateCommand
        {
            get { return UpdateCommand; }
            set { UpdateCommand = value; }
        }
    }
}