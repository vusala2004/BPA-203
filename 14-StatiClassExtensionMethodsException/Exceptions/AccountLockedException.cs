

namespace _14_StatiClassExtensionMethodsException.Exceptions
{
    internal class AccountLockedException:Exception
    {
        public AccountLockedException() : base("Account is locked. Please contact admin.")
        {

        }
    }
}
