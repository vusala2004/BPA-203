

namespace _14_StatiClassExtensionMethodsException.Models
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; }
        public int FailedAttempts { get; set; }
        public User(string username, string password)
        {
            username = Username;
            Password = password;
            IsLocked = false;
            FailedAttempts = 0;
        }
    }
}
