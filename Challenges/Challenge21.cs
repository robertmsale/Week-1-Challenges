using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges

{
    class Challenge21
    {
        public static string[] banner =
        {
            " ,---.                  ,,--.      ,-_/,.           .                 ",
            " |  -'  ,-. ,-,-. ,-.   |`, | ,\"   ' |_|/ ,-. ,-. ,-| ,-. ,-. ,-. ,-. ",
            " |  ,-' ,-| | | | |-'   |   | |-    /| |  ,-| |   | | | | |-' `-. `-. ",
            " `---|  `-^ ' ' ' `-'   `---' |     `' `' `-^ '   `-^ ' ' `-' `-' `-' ",
            "  ,-.|                        '                                       ",
            "  `-+'                                                                ",
        };
        public static void Run()
        {
            foreach (string line in banner) { Console.WriteLine(line); }
            Console.Write("Select your difficulty! (if you dare)\n");
            Console.WriteLine("1) Least hard");
            Console.WriteLine("2) Somewhat hard");
            Console.WriteLine("3) Very hard");
            Console.WriteLine("4) How dare you!");
            Console.Write("\t-> ");
            char opt = Console.ReadKey().KeyChar;
            int enemies = 0;
            switch (opt)
            {
                case '1':
                    enemies = Program.rng.Next(100, 1000);
                    break;
                case '2':
                    enemies = Program.rng.Next(1000, 10000);
                    break;
                case '3':
                    enemies = Program.rng.Next(10000, 100000);
                    break;
                default:
                    enemies = Program.rng.Next(100000, Int32.MaxValue);
                    break;
            }
            Console.Write($"\nYou will be facing precisely {enemies} bad guys. Good luck :-(");
            Console.ReadKey();
        }
    }
}
