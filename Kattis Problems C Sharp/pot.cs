using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis_Problems
{
    class pot
    {
        public static void Main()
        {
            string line;
            double sum = 0;

            // loop through unspecified amount of input
            while ((line = Console.ReadLine()) != null && line != "")
            {
                // skip numbers less than 10
                if(line.Length == 1)
                {
                    continue;
                }

                // get all characters except the last
                int num = Convert.ToInt32(line.Substring(0, line.Length-1));
                
                // get the last character
                int pow = Convert.ToInt32(line.Substring(line.Length - 1));

                // add num ^ pow to the sum
                sum += Math.Pow(num, pow);
            }

            // ouput the sum
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
