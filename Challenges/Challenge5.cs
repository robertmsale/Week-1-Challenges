using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge5
    {
        public static double a;
        public static double b;
        public static double c;

        static void GetVal(string name, ref double val)
        {
            Console.Write($"{name} = ");
            Console.ForegroundColor = ConsoleColor.White;
            val = Double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void Run()
        {
            Console.WriteLine("Operator Precedence!\nPlease fill out the values for { a, b, c }\n");
            GetVal("a", ref a);
            GetVal("b", ref b);
            GetVal("c", ref c);
            Console.WriteLine($"\na + 1 * b + 2 - c = {a + 1 * b + 2 - c}");
            Console.WriteLine($"(a + 1) * (b + 2) - c = {(a + 1) * (b + 2) - c}");
            Console.ReadKey();
        }
    }
}
