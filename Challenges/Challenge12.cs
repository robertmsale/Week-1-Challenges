using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge12

    {
        static T Swap<T>(T x, ref T y)
        {
            T oldY = y;
            y = x;
            return oldY;
        }
        public static void Run()
        {
            string first = "";
            string last = "";

            Console.Write("Enter your first name: ");
            first = Console.ReadLine();
            Console.Write("Enter your last name: ");
            last = Console.ReadLine();

            Console.Write($"\nThe value of the first variable: {first}\n");
            Console.Write($"The value of the last variable: {last}\nSwapping...\n");

            first = Swap(first, ref last);

            Console.Write($"\nThe value of the first variable: {first}\n");
            Console.Write($"The value of the last variable: {last}");

            Console.ReadKey();
        }
    }
}
