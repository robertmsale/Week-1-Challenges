using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge1
    {
        public static void Run()
        {
            // Set background and clear console (this sets the whole background to the same color)
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            // Initialize hand-written ASCII art array
            string[] HelloWorldGraphics = {
                "#     #                                    #     #                             ###  ",
                "#     # ###### #      #       ####         #  #  #  ####  #####  #      #####  ###  ",
                "#     # #      #      #      #    #        #  #  # #    # #    # #      #    # ###  ",
                "####### #####  #      #      #    #        #  #  # #    # #    # #      #    #  #   ",
                "#     # #      #      #      #    # ###    #  #  # #    # #####  #      #    #      ",
                "#     # #      #      #      #    # ###    #  #  # #    # #   #  #      #    # ###  ",
                "#     # ###### ###### ######  ####   #      ## ##   ####  #    # ###### #####  ###  ",
                "                                    #                                               " };
            // Initialize console color array of the same size
            ConsoleColor[] HelloWorldColors = {
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.DarkYellow,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
                ConsoleColor.Blue };
            // Loop both arrays, changing console color and writing each line of the hello world ASCII symbols
            for (int i = 0; i < 8; i++)
            {
                Console.ForegroundColor = HelloWorldColors[i];
                Console.WriteLine(HelloWorldGraphics[i]);
            }
            // Pause so the user can enjoy the graphics
            Console.ReadKey();
        }
    }
}
