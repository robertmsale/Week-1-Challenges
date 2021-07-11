using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge6
    {
        public static void Run()
        {
            Console.Write("Temp converter!\nTemperature in F: ");
            double F = Double.Parse(Console.ReadLine());
            Console.Write($"Temperature in C: {(F - 32.0d) * (5.0d / 9.0d)}\n\nTemperature in C: ");
            double C = Double.Parse(Console.ReadLine());
            Console.Write($"Temperature in F: {(C * 9.0d) / 5.0d + 32.0d}\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
