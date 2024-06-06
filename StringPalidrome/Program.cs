using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    public class Program
    {
        public static bool IsPalindrome(string s)
        {
            // Base case: If the string has 0 or 1 character, it's a palindrome
            if (s.Length <= 1)
            {
                return true;
            }

            // Compare the first and last characters
            if (s[0] != s[s.Length - 1])
            {
                return false; // Not a palindrome
            }

            // Recur for the substring without the first and last characters
            return IsPalindrome(s.Substring(1, s.Length - 2));
        }

        public static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            bool isPalindrome = IsPalindrome(input);

            if (isPalindrome)
            {
                Console.WriteLine("The string is Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not Palindrome.");
            }
            Console.ReadKey();
        }
    }
}
