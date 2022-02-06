using System;

namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constant options for validation
            const int passwordMinLength = 6;
            const int passwordMaxLength = 10;
            const int passwordDigitsMinCount = 2;

            //Read password from the Console
            string password = Console.ReadLine();

            //TODO: Validate given password
            bool isPasswordValid = ValidatePassword(password, passwordMinLength, passwordMaxLength, passwordDigitsMinCount);

            //Print if it is valid
            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        /// <summary>
        /// The given method validates password. It prints any validation errors and return boolean whether the password is valid
        /// </summary>
        static bool ValidatePassword(string password, int passwordMinLength, int passwordMaxLength, int passwordDigitsMinCount)
        {
            bool isPasswordValid = true;
            if (!ValidatePasswordLength(password, passwordMinLength, passwordMaxLength))
            {
                Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters");
                isPasswordValid = false;
            }
            if (!ValidatePasswordIsAlphaNumerical(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid = false;
            }
            if (!ValidatePasswordDigitsMinCount(password, passwordDigitsMinCount))
            {
                Console.WriteLine($"Password must have at least {passwordDigitsMinCount} digits");
                isPasswordValid = false;
            }

            return isPasswordValid;
        }

        static bool ValidatePasswordLength(string password, int minLength, int maxLength)
        {
            if (password.Length >= minLength && password.Length <= maxLength)
            {
                return true;
            }

            return false;
        }

        static bool ValidatePasswordIsAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }

        static bool ValidatePasswordDigitsMinCount(string password, int minDigitsCount)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }

            return digitsCount >= minDigitsCount;
        }
    }
}
