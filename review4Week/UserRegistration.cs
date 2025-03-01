using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace review4Week
{
    //Test User Registration: Validate user input (name, email, age) using NUnit tests.

    public class UserRegistration
    {
        public bool ValidateName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-z]{3,}$");

            Match match = regex.Match(name);

            if (match.Success) { 
                return true;
            }
            return false;

        }

        public bool ValidateAge(int age)
        {
            if (age < 18) { 
                return false;
            }
            return true;

        }

        public bool  ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.+[a-zA-Z0-9]+$";

            Match match = Regex.Match(email, emailPattern);

            if (match.Success)
            {
               return true;
            }
            else
            {
               return false;
            }
        }

       


    }
}
