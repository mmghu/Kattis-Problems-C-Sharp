using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis_Problems
{
    class twostones
    {
        public static void Main()
        {
            // creates an int variable, takes in a string, converts to int and assigns
            int num = Convert.ToInt32(Console.ReadLine());

            // if the number is divisible by two
            if(num % 2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}
