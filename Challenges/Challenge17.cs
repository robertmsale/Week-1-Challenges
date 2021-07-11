using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge17
    {
        public static void Run()
        {
            int check = -1;
            Console.Write("Divisor checker\n\nPlease enter a divisor: ");
            int input = Math.Abs((int)Int32.Parse(Console.ReadLine()));
            for (int i = 0; i < 3; i++)
            {
                check = Program.rng.Next();
                Console.WriteLine($"{check}\t\t- {check % input == 0}");
            }
            Console.ReadKey();
        }
    }
}
