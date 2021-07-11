using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge13
    {
        public static void Run()
        {
            ushort age = 0;
            Console.WriteLine("How old are you? ");
            age = UInt16.Parse(Console.ReadLine());
            Console.WriteLine();
            if (age < 13) // PG-13
            {
                Console.WriteLine("Sorry but you must be 13 or older to play");
            }
            else
            {
                string[] madeYouLook =
                {
                    "          .--------._              ",      //1
                    "         (`--'  YOU  `-.           ",      //2
                    "          `.______      `.         ",      //3
                    "       ___________`__     \\        ",     //4
                    "    ,-'           `-.\\     |       ",     //5
                    "   //     JUST       \\|    |\\      ",    //6
                    "  (`  .'~~~~~---\\     \\'   | |     ",    //7
                    "   `-'           )     \\   | |     ",     //8
                    "      ,---------' - -.  `  . '     ",      //9
                    "    ,'             `%`\\`     |     ",     //10
                    "   /      LOST            \\  |     ",     //11
                    "  /     \\-----.         \\    `     ",    //12
                    " /|  ,_/      '-._            |    ",      //13
                    "(-'  /           /            `    ",      //14
                    ",`--<           |        \\     \\   ",    //15
                    "\\ |  \\         /%%             `\\  ",   //16
                    " |/   \\____---'--`%        \\     \\ ",   //17
                    " |    '           `               \\",     //18
                    " |      THE GAME                   ",      //19
                    "  `--.__                           ",      //20
                    "        `---._______               ",      //21
                    "                    `.             ",      //22
                    "                      \\            ",     //23
                };
                foreach (string line in madeYouLook)
                {
                    Console.WriteLine(line);
                }

            }
            Console.ReadKey();
        }
    }
}
