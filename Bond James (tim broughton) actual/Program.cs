using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bond_James__tim_broughton__actual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first and last name:");

            string userInput = Console.ReadLine();

            string[] firstAndLast = userInput.Split(null);

            string firstName = firstAndLast[0];

            string lastName = firstAndLast[1];

            Console.WriteLine("{0} {1}", lastName, firstName);



            Console.ReadKey();
        }

        
    }
}
