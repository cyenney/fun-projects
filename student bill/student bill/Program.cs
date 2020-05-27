using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace student_bill
{
    class Program
    {
        /*prompt a student for their student ID and the titles of the three classes
        they want to add. The solution should display the students ID and a total Bill
        Bill a student using the following rules:
        1. Students can only add up to 3 classes at a time.
        2. each class costs $150.00
        3.a 5% technology fee will be added to the total cost. 
        4. if a student is taking 3 classes and working for mroe than 20 hours a week, 
        a message displays prompting they make an appointment with their faculty advisor.
        5. If the student adds more than 3 classes, an error message is printed. 

    */
        static void Main(string[] args)
        {
            string studentID;
            int numberOfClasses;
            Console.WriteLine("Please enter your student ID");
            studentID = Console.ReadLine();
            string class1;
            string class2;
            string class3;

            Console.WriteLine("How many classes are you taking this semester?");
            numberOfClasses = int.Parse((Console.ReadLine()));

            if ( numberOfClasses == 1 )
            {
                Console.WriteLine("Please enter the name of the class");
                class1 = Console.ReadLine();

                Console.WriteLine("Total bill for student # " + studentID + "is" + numberOfClasses * 150 * 1.05);
                Console.ReadLine();
            }

            else if ( numberOfClasses == 2 )
            {
                Console.WriteLine("Please enter the name of the first class");
                class1 = Console.ReadLine();
                Console.WriteLine("Please enter the name of the second class");
                class2 = Console.ReadLine();
                Console.WriteLine("Total bill for student # " + studentID + "is" + numberOfClasses * 150 * 1.05);
                Console.ReadLine();
            }

            else if ( numberOfClasses == 3 )
            {
                Console.WriteLine("Please enter the name of your first class");
                class1 = Console.ReadLine();
                Console.WriteLine("Please enter the name of your second class");
                class2 = Console.ReadLine();
                Console.WriteLine("Please enter the name of your third class");
                class3 = Console.ReadLine();
                Console.WriteLine("If you are taking 3 classes and working more than 20 hours a week, you have to make an appointment with your faculty advisor.");
               
                Console.WriteLine("Total bill for student # " + studentID + " is " + numberOfClasses * 150 * 1.05);
            }

            else
            {
                Console.WriteLine("Please enter how man classes you are taking. You may only enter up to 3.");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
            




        
    }
}
