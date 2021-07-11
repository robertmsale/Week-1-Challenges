using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge7
    {
        public static void Run()
        {
            Console.WriteLine("Table of integral variable type ranges in C#\n");
            Console.WriteLine("=======================================");
            Console.WriteLine("type\trange");
            Console.WriteLine("=======================================\n");

            Console.WriteLine($"sbyte\t{SByte.MinValue} to {SByte.MaxValue}");
            Console.WriteLine($"byte\t{Byte.MinValue} to {Byte.MaxValue}");

            Console.WriteLine($"short\t{Int16.MinValue} to {Int16.MaxValue}");
            Console.WriteLine($"ushort\t{UInt16.MinValue} to {UInt16.MaxValue}");

            Console.WriteLine($"int\t{Int32.MinValue} to {Int32.MaxValue}");
            Console.WriteLine($"uint\t{UInt32.MinValue} to {UInt32.MaxValue}");

            Console.WriteLine($"long\t{Int64.MinValue} to {Int64.MaxValue}");
            Console.WriteLine($"ulong\t{UInt64.MinValue} to {UInt64.MaxValue}");

            Console.ReadKey();
        }
    }
}
