

using _14_StatiClassExtensionMethodsException.Exceptions;
using System.Security.Cryptography.X509Certificates;

namespace _14_StatiClassExtensionMethodsException.Models
{
    internal class LoginSystem
    {
        private User[] Users;
        private const int MaxAttempts = 3;
        public LoginSystem()
        {



            Users = new User[]
            {
               new User("admin", "admin123"),
               new User("student" ," student123"),
               new User("teacher" ," teacher123")
            };


        }
        public void ValidateUsername(string username)
        {
            if (username == null || username.Length < 3)
            {
                throw new InvalidUsernameException();
            }
        }
        public void ValidatePassword(string password)
        {
            if (password == null || password.Length < 6)
            {
                throw new InvalidPasswordException();
            }
        }
        private User FindUser(string username)
        {
          string searchUsername = username.ToLower();

           
            for (int i = 0; i < username.Length; i++)
            {

                if (Users[i].Username.ToLower() == searchUsername)
                {
                    return Users[i];
                }
            }

            
            return null;
        }
        public bool Login(string username, string password)   
        {       
           ValidateUsername(username);
           ValidatePassword(password);
           User user = FindUser(username);

            if (user == null)
            {
                throw new UserNotFoundException(username);
            }

            if (user.IsLocked)
            {
                throw new AccountLockedException();
            }

            if (user.Password == password)
            {
                user.FailedAttempts = 0; 

                Console.WriteLine($"Login successful! Welcome, {user.Username}!");
               return true;
           }
            else
           {
                user.FailedAttempts++;
                int attemptsLeft = MaxAttempts - user.FailedAttempts;

                if (attemptsLeft > 0)
                {
                    throw new IncorrectPasswordException(attemptsLeft);
                }
                else
                {
                    user.IsLocked = true;
                   throw new AccountLockedException();
               }
           }   
        }

       
    }
}

