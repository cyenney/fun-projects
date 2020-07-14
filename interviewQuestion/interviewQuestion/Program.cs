using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace interviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lets say an IP address (when broken down to bits) is malicious if it has over 8 1's. 
            //Given an Ip address, determine if it is malicious or not. 

            string ipAddress = "10110010.00000000.01100100.00000001";
            int count = 0;

            for (int i = 0; i < ipAddress.Length; i++)
            {
                if (ipAddress[i] == '1')
                {
                    count++;
                }
            }

            if ( count >= 8)
            {
                Console.WriteLine("That IP address is malicious");
            }

            else
            {
                Console.WriteLine("That IP address is not malicious");
            }

            Console.ReadLine();

        }
    }
}
