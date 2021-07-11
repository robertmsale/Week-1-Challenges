using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge19

    {
        static string[] popsicle =
        {
            "         _.-.",
            "       ,'/ //\\",
            "      /// // /)",
            "     /// // //|",
            "    /// // ///",
            "   /// // ///",
            "  (`: // ///",
            "   `;`: ///",
            "   / /:`:/",
            "  / /  `'",
            " / /",
            "(_/ ",
        };
        public static void Run()
        {
            Console.Write("What kinda popsicle you want homie!?\n1) Red\n2) Green\n3) Cyan\n4) Yellow\n");
            char opt = Console.ReadKey().KeyChar;
            Console.WriteLine();
            ConsoleColor? pick;
            switch (opt)
            {
                case '1':
                    Console.WriteLine("Woah there buddy! I had no idea you were a person of substance! Here you go!");
                    pick = ConsoleColor.Red;
                    break;
                case '2':
                    Console.WriteLine("Now we're talking! Here you go pal!");
                    pick = ConsoleColor.Green;
                    break;
                case '3':
                    Console.WriteLine("Now that's a good choice I'll tell you h'wat.");
                    pick = ConsoleColor.Cyan;
                    break;
                default:
                    Console.WriteLine("Not sure who made this one, but here you go!");
                    pick = ConsoleColor.Yellow;
                    break;
            }
            Console.ForegroundColor = pick.Value;
            foreach (string line in popsicle)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
