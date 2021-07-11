using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge8
    {
        public static void Run()
        {
            unchecked
            {
                Console.WriteLine($"Max Value of SByte: {SByte.MaxValue}");
                Console.WriteLine($"Max Value of SByte+1: {(SByte)(SByte.MaxValue + 1)}");
                Console.WriteLine($"Min Value of SByte: {SByte.MinValue}");
                Console.WriteLine($"Min Value of SByte-1: {(SByte)(SByte.MinValue - 1)}\n");

                Console.WriteLine($"Max Value of Byte: {Byte.MaxValue}");
                Console.WriteLine($"Max Value of Byte+1: {(Byte)(Byte.MaxValue + 1)}");
                Console.WriteLine($"Min Value of Byte: {Byte.MinValue}");
                Console.WriteLine($"Min Value of Byte-1: {(Byte)(Byte.MinValue - 1)}\n");

                Console.WriteLine($"Max Value of Int16: {Int16.MaxValue}");
                Console.WriteLine($"Max Value of Int16+1: {(Int16)(Int16.MaxValue + 1)}");
                Console.WriteLine($"Min Value of Int16: {Int16.MinValue}");
                Console.WriteLine($"Min Value of Int16-1: {(Int16)(Int16.MinValue - 1)}\n");

                Console.WriteLine($"Max Value of UInt16: {UInt16.MaxValue}");
                Console.WriteLine($"Max Value of UInt16+1: {(UInt16)(UInt16.MaxValue + 1)}");
                Console.WriteLine($"Min Value of UInt16: {UInt16.MinValue}");
                Console.WriteLine($"Min Value of UInt16-1: {(UInt16)(UInt16.MinValue - 1)}\n");

                Console.WriteLine($"Max Value of Int32: {Int32.MaxValue}");
                Console.WriteLine($"Max Value of Int32+1: {(Int32)(Int32.MaxValue + 1)}");
                Console.WriteLine($"Min Value of Int32: {Int32.MinValue}");
                Console.WriteLine($"Min Value of Int32-1: {(Int32)(Int32.MinValue - 1)}\n");

                Console.WriteLine($"Max Value of UInt32: {UInt32.MaxValue}");
                Console.WriteLine($"Max Value of UInt32+1: {(UInt32)(UInt32.MaxValue + 1)}");
                Console.WriteLine($"Min Value of UInt32: {UInt32.MinValue}");
                Console.WriteLine($"Min Value of UInt32-1: {(UInt32)(UInt32.MinValue - 1)}\n");

                Console.WriteLine($"Max Value of Int64: {Int64.MaxValue}");
                Console.WriteLine($"Max Value of Int64+1: {(Int64)(Int64.MaxValue + 1)}");
                Console.WriteLine($"Min Value of Int64: {Int64.MinValue}");
                Console.WriteLine($"Min Value of Int64-1: {(Int64)(Int64.MinValue - 1)}\n");

                Console.WriteLine($"Max Value of UInt64: {UInt64.MaxValue}");
                Console.WriteLine($"Max Value of UInt64+1: {(UInt64)(UInt64.MaxValue + 1)}");
                Console.WriteLine($"Min Value of UInt64: {UInt64.MinValue}");
                Console.WriteLine($"Min Value of UInt64-1: {(UInt64)(UInt64.MinValue - 1)}\n");

                Console.ReadKey();
            }
        }
    }
}
