using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis_Problems
{
    class carrots
    {
       public static void Main()
        {
            // read the first line in
            string firstLine = Console.ReadLine();

            // split the line on the space character
            string[] splitLine = firstLine.Split(' ');

            // take in a description splitLine[0] times
            for(int i = 0; i < Convert.ToInt32(splitLine[0]); i++)
            {
                // this doesn't have to actually be stored anywhere
                Console.ReadLine();
            }

            // output splitLine[1]
            Console.WriteLine(splitLine[1]);
            
        }
    }
}
