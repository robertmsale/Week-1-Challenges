using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge11
    {
        public static void Run()
        {
            Console.Write("Hypotenuse Calculator!\na = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write($"The hypotenuse c = {Math.Sqrt(a * a + b * b)}");
            Console.ReadKey();
        }
    }
}
