using _14_StatiClassExtensionMethodsException.Exceptions;
using _14_StatiClassExtensionMethodsException.Models;

class Program
    {
        static void Main()
        {
        LoginSystem loginSystem = new LoginSystem();

        while (true)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                try
                {
                    bool success = loginSystem.Login(username, password);
                    if (success)
                        break;
                }
                catch (InvalidUsernameException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (UserNotFoundException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
               
                }
                catch (IncorrectPasswordException ex)
                {
                    Console.WriteLine("WARNING: " + ex.Message);
                }
                catch (AccountLockedException ex)
                {
                    Console.WriteLine("CRITICAL: " + ex.Message + " Contact admin.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
                }

                Console.WriteLine(); 
            }
        }
    }


