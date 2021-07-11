using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge16
    {
        public static void Run()
        {
            Console.WriteLine("Even number checker! (type \"exit\" at any time to quit)\n");
            while (true)
            {
                Console.Write("Please enter an even number: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Buh-bye now!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    if (Int32.Parse(input) % 2 == 0)
                    {
                        Console.WriteLine(":-)\n");
                    }
                    else
                    {
                        Console.WriteLine(":-(\n");
                    }
                }
            }

        }
    }
}
