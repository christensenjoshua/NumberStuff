using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            int number = 1234;
            int numIterations = 0;
            while (!done)
            {
                numIterations++;
                var largeS = number.ToString().ToCharArray().OrderByDescending(d => d);
                var smallS = number.ToString().ToCharArray().OrderBy(d => d);
                int.TryParse(String.Join("",largeS), out int large);
                int.TryParse(String.Join("",smallS), out int small);
                number = large - small;
                if(number == 6174)
                {
                    Console.WriteLine("You did it in " + numIterations + " iterations!");
                    done = true;
                    continue;
                }
                if(numIterations > 8)
                {
                    Console.WriteLine("You failed to get the number in 8 iterations or less!");
                    done = true;
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
