using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalOfAllValuesThatAreEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //given an array of ints, write a C# method to total all the values that are even numbers.


            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int total = 0;

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] % 2 == 0 )
                {
                    total+= test[i];
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
