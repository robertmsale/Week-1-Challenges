using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge9
    {
        public static int x = 0;
        public static int y = 0;
        public static void Run()
        {
            Console.Write("Please Enter a number: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Now another number: ");
            y = Int32.Parse(Console.ReadLine());
            Console.Write($"Result: {x + y}");

            // This flow structure checks Y to see if the sum moves towards max or towards min, then checks for overflow/underflow, giving an explaination for the result of the operation
            if (y > 0)
            {
                // Because adding the two operators causes an overflow, I must subtract the larger number from max and see if it is less than the smaller number to determine whether an overflow occurred
                if (Int32.MaxValue - Math.Max(x, y) < Math.Min(x, y))
                {
                    Console.Write($"\nAdding {x} to {y} causes an overflow, hence the result");
                }
                else
                {
                    Console.Write($"\n\nAdding {x} to {y} does not exceed Int32's max value, and therefore adds without overflowing.");
                }
            }
            else
            {
                // Same operation as above but in reverse
                if (Int32.MinValue - Math.Min(x, y) > Math.Max(x, y))
                {
                    Console.Write($"\nAdding {x} to {y} causes an underflow, hence the result");
                }
                else
                {
                    Console.Write($"\n\nAdding {x} to {y} does not exceed Int32's min value, and therefore adds without underflowing.");
                }
            }
            Console.ReadKey();
        }
    }
}
