using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_24_count_number_of_words_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {

            //count the number of words in a string

            string input = "I am doing my best to try and code every day!";
            int wordCount = 1;

            for (int i = 0; i < input.Length -1 ; i++)
            {
                if ( input[i] == ' ' )
                {
                    wordCount++;
                }
            }

            Console.WriteLine("The word count is " + wordCount);
            Console.ReadLine();

        }
    }
}
