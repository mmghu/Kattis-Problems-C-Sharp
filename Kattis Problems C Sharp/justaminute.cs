using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis_Problems_C_Sharp
{
    class justaminute
    {
        public static void Main()
        {
            // get number of trials
            int trials = Convert.ToInt32(Console.ReadLine());

            // keep track of some variables
            double totalMinutes = 0;
            double sum = 0;

            // loop through trial times and collect rest of the data
            for(int i = 0; i < trials; i++)
            {
                // split input 
                string[] line = Console.ReadLine().Split(' ');

                // convert splitted input
                double minute = Convert.ToInt32(line[0]);
                double seconds = Convert.ToInt32(line[1]);

                // track running minutes
                totalMinutes += minute;

                // calculate the average and add to sum
                sum += (seconds / (minute * 60)) * minute;
            }

            // combine all the averages
            double averageMinute = sum / totalMinutes;

            // if its less than a real minute
            if(averageMinute <= 1)
            {
                Console.WriteLine("measurement error");
            }
            else
            {
                // otherwise no error and print averageMinute
                Console.WriteLine(averageMinute);
            }

        }
    }
}
