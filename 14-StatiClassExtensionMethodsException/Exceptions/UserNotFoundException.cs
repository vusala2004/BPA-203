
namespace _14_StatiClassExtensionMethodsException.Exceptions
{
    internal class UserNotFoundException:Exception
    {
        public UserNotFoundException() : base("User not found.")
        {
        }
        public UserNotFoundException(string username) : base($"User '{username}' not found.")
        { 
        }
    }
}
