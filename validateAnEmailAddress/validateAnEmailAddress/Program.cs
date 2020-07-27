using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validateAnEmailAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            // validate an email address
            //So whats is considered an email address? IMO the string must contain "@" && ".com" for it to be valid.
       
            string userInput = "test@microsoft.com";

            string @Valid = "@";
            string comValid = ".com";

            bool b = userInput.Contains(@Valid) && userInput.Contains(comValid);


            if (b == true)
            {
                Console.WriteLine(userInput + " is a valid address");
            }

            else
            {
                Console.WriteLine(userInput + " is not a valid address");
            }

  
            Console.ReadLine();

   

        }
    }
}
