using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace review4Week
{
    //Validate Email Format: Write a function using Regex to validate email addresses (e.g., example@domain.com).
    internal class ValidateEmailFormat
    {
        public static void ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.+[a-zA-Z0-9]+$";

            Match match = Regex.Match(email, emailPattern);

            if (match.Success)
            {
                Console.WriteLine("valid email input");
            }
            else
            {
                Console.WriteLine("Invalid email input");
            }
        }

        //Extract Phone Numbers: Parse a string and extract 10-digit phone numbers.


        public static void ExtractPhoneNum(string phoneNumstr) {

           

            string regexPattern = @"\b\d{10}\b";

           var matches = Regex.Matches(phoneNumstr, regexPattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        //Check Strong Password: Validate a password that must contain at least 1 uppercase,
        //1 lowercase, 1 digit, and 1 special character.

        public static void CheckStrongPassword(string password) {

            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[\da-zA-z]).{8,}$";

            Match match = Regex.Match (password, passwordPattern);

            if (match.Success) {

                Console.WriteLine("strong passoord input");
            }
            else
            {
                Console.WriteLine(" provide strong passoord input");
            }
        }

        //Find Dates in Text: Extract dates in formats like dd/mm/yyyy or yyyy-mm-dd.

        public static void ExactDateFormat() {

            string str = "Find Dates in Text: Extract dates in formats like 12/02/2025 or 2025-03-23";

            string datePattern = @"\b(?:\d{2}/\d{2}/\d{4}|\d{4}-\d{2}-\d{2})\b";

            var dates = Regex.Matches(str, datePattern);

            foreach (Match match in dates) { 
                Console.WriteLine(match.Value);
            }

        }

        //Replace Multiple Whitespaces: Convert multiple spaces in a string into a single space.
        public static void ReplaceWhiteSpaces()
        {
            string str = "Convert   multiple     spaces in a     string   into a single   space.";

            string strPattern = @"\s+";

            string result = Regex.Replace(str, strPattern, " ");

            Console.WriteLine("Initial string :" + str);

            Console.WriteLine("After Removing mulitiple WhiteSpaces :" + result);

        }

        //Custom File Read Exception: Raise a custom exception if a file size is too large.
        public static void CheckFileSize()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\review4Week\review4Week\file.txt";

            long maxFileSize = 1 *1024;
         
            try
            {
                    FileInfo fileInfo = new FileInfo(path);
                    long fileSize = fileInfo.Length;
                    Console.WriteLine(fileSize);

                    if (fileSize > maxFileSize)
                    {
                        throw new FileSizeTooLargeException("File size too large");
                    }
            
                
            }catch(FileSizeTooLargeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CheckPlaindromeString()
        {
            Func<string, bool> isPalindrome = str =>
            {
                string initialStr = str.Replace(" ", "").ToLower();
                return str == new string(str.Reverse().ToArray());
            };

            
            string input = "nayan";
            bool result = isPalindrome(input);

            Console.WriteLine($"is '{input}' a palindrome? : {result}");
        }

        


    }
}
