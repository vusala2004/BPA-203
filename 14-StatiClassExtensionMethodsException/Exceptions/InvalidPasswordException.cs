

namespace _14_StatiClassExtensionMethodsException.Exceptions
{
    internal class InvalidPasswordException:Exception
    {
        public InvalidPasswordException() : base("Password cannot be empty or less than 6 characters.") 
        { 

        }
        public InvalidPasswordException(string message) : base(message)
        { 
        
        }
    }
}
