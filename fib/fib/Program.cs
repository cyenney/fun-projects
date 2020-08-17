using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            fib();
        }

        public static void fib()
        {
            Console.WriteLine("Enter a number to find the nth element in the fib sequence.");
            int nth = Int32.Parse(Console.ReadLine());

            int b = 0;
            int i = 1;
            int a = 0;

            for (int j = 0; j < nth; j++)
            {
                a = b + i;
                Console.WriteLine(" {0}", b);
                b = i;
                i = a;
            }
            Console.ReadLine();
            
        }
    }
}
