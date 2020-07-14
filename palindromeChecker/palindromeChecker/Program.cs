using System;

namespace palindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter a word and I'll tell you if it's a palindrome!");
            string userInput = Console.ReadLine();
            

            for (int i = 0; i < userInput.Length - 1; i++)
            {
                for (int j = userInput.Length - 1; j > 0; j--)
                {
                    if ( userInput[i] != userInput[j])
                    {
                        Console.WriteLine(userInput + " Is not a palindrome");
                    }

                    else
                    {
                        Console.WriteLine(userInput + " is a palindrome.");


                    }

                    Console.ReadLine();
                }
            }
               

              
        }
    }
}
