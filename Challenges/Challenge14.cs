using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge14
    {
        static ushort SetAndReturn(string input, ref ushort value)
        {
            value = UInt16.Parse(input);
            return value;
        }
        public static void Run()
        {
            Console.Write("Time zone converter!\n\nEnter the hour to convert from Pacific to Eastern time: ");
            ushort local = 0;
            while (true) // I'm sorry, but I like to live dangerously! 
            {
                ushort check = SetAndReturn(Console.ReadLine(), ref local);
                if (check > 12 || check == 0)
                {
                    Console.Error.Write("You must enter a valid time (1-12): ");
                    continue;
                }
                break;
            }
            Console.WriteLine($"That would be {(local >= 10 ? 3 - (12 - local) : local + 3)} Eastern.");
            Console.ReadKey();
        }
    }
}
