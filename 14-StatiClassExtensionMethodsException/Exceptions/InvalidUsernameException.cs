

namespace _14_StatiClassExtensionMethodsException.Exceptions
{
    internal class InvalidUsernameException:Exception
    {
        public InvalidUsernameException() : base("Username cannot be empty or less than 3 characters.") 
        { 

        }
        public InvalidUsernameException(string message) : base(message) 
        {

        }
    }
}

