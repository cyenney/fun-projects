using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeCheck2._0
{
    class Program
    {

        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string to check if it's a palindrome.");
            string input = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            if (input == reverse)
            {
                Console.WriteLine(input + " is a palindrome.");
            }

            else
            {
                Console.WriteLine(input + " is not a palindrome.");
            }

            Console.ReadLine();
       

        }
    }
}
