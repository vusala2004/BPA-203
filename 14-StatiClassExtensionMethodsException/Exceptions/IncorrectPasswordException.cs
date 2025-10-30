using System;
using System.Collections.Generic;
using System.Linq;


namespace _14_StatiClassExtensionMethodsException.Exceptions
{
    internal class IncorrectPasswordException:Exception
    {
        public int AttemptsLeft { get; set; }

        public IncorrectPasswordException(int attemptsLeft)
             : base($"Incorrect password. Attempts left: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
