using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge4
    {
        public static string input = "";

        static void InitConsole()
        {
            string[] Banner =
            {
                "     _                                  _      ____                              ",
                "    | |                                | |    (|   \\ o       o     |             ",
                "    | | _  _  _|_  _   __,  ,_    __,  | |     |    |            __|   _   ,_    ",
                "  _ |/ / |/ |  |  |/  /  | /  |  /  |  |/     _|    ||  |  |_|  /  |  |/  /  |   ",
                "  \\_/\\/  |  |_/|_/|__/\\_/|/   |_/\\_/|_/|__/  (/\\___/ |_/ \\/  |_/\\_/|_/|__/   |_/ ",
                "                        /|                                                       ",
                "                        \\|                                                       ",
            };
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            foreach (string line in Banner)
            {
                Console.WriteLine(line);
            }
        }

        public static void Run()
        {
            bool restart = true;
            InitConsole();
            Console.Write("Enter a number\n\t-> ");
            Console.ForegroundColor = ConsoleColor.White;
            input = Console.ReadLine();
            int parsed = -1;
            bool success = true;
            while (true)
            {
                try
                {
                    parsed = Int32.Parse(input);
                }
                catch (Exception e)
                {
                    success = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("You must enter an actual number! Press any key to restart or press ESC to quit.");
                    char opt = Console.ReadKey().KeyChar;
                    if (opt == 27)
                    {
                        restart = false;
                    }
                    break;
                }
                break;
            }
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                int[] divisors = { 1, 2, 4, 8 };
                foreach (int d in divisors) { Console.WriteLine($"{parsed} / {d} = {(int)(parsed / d)}"); }
                Console.Write("Would you like to go again? Y/(N)");
                char opt = Console.ReadKey().KeyChar;
                if (opt != 'y' && opt != 'Y')
                {
                    restart = false;
                }
            }
        }
    }
}
