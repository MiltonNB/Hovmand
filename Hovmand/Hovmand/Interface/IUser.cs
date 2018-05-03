namespace Hovmand.Interface
{
    public interface IUser
    {
        string Email { get; }

        string Password { get; }

        string UserType { get; }
    }
}
