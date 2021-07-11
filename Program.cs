using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PG1_Week_1_Challenge_Runner
{
    class Program
    {
        public static Random rng = new Random(); // Must only declare one RNG so all challenges will use this one to avoid random number collisions
        static string[] banner =
        {
            "         |~) _ |_  _  __|_  (~ _ | _ ' _  \\    / _  _ |   '|          ",
            "         |~\\(_)|_)(/_|  |   _)(_||(/_ _\\   \\/\\/ (/_(/_|<  .|.         ",
            "                                                                      ",
            "                      /~`|_  _ || _  _  _  _  _                      ",
            "                      \\_,| |(_|||(/_| |(_|(/__\\                      ",
            "                                        _|                            "
        };
        static string[] TOC =
        {
            "+----------------------------------------------------------+  ",
            "|       1 - Hello World                                    |  ",
            "|       2 - Hello World 2.0                                |**",
            "|       3 - Age to Day Calculator                          |**",
            "|       4 - Integral Divider                               |**",
            "|       5 - Operator Precedence                            |**",
            "|       6 - Temperature Converter                          |**",
            "|       7 - Integral Data Type Specs                       |**",
            "|       8 - Over/Underflow testing                         |**",
            "|       9 - Advanced Over/Underflow testing                |**",
            "|       10 - Gentle Jerry's Generic Goods                  |**",
            "|       11 - Find Hypotenuse                               |**",
            "|       12 - Data Swap                                     |**",
            "|       13 - Adult Game                                    |**",
            "|       14 - Time Zone                                     |**",
            "|       15 - Programming Trivia                            |**",
            "|       16 - Even Numbers                                  |**",
            "|       17 - Modulo Test                                   |**",
            "|       18 - Quote Machine                                 |**",
            "|       19 - Popsicle Game                                 |**",
            "|       20 - Magic 8-Ball                                  |**",
            "|       21 - Difficulty Simulator                          |**",
            "|       22 - Gentle Jerry's Generic Goods Part Deux        |**",
            "|       23 - Random Character                              |**",
            "|       24 - ScreenSaver                                   |**",
            "+----------------------------------------------------------+**",
            "  ************************************************************",
            "  ************************************************************"
        };
        static void PrintArray(string[] input)
        {
            foreach (string line in input) { Console.WriteLine(line); } // Simple one-liner for printing my ASCII art

        }
        static void PrintMenu()
        {
            Console.Clear();
            PrintArray(banner);
            PrintArray(TOC);
            Console.Write("Pick a challenge to run: ");
        }
        static void RunChallenge(string opt)
        {
            Console.Clear();
            try // Catch any undefined behavior or errors from bad input and return to main menu (I'm lazy!)
            {
                switch (opt) {
                    case "1": Challenges.Challenge1.Run(); break;
                    case "2": Console.WriteLine("This challenge is unfinished :-("); Console.ReadKey(); break;
                    case "3": Challenges.Challenge3.Run(); break;
                    case "4": Challenges.Challenge4.Run(); break;
                    case "5": Challenges.Challenge5.Run(); break;
                    case "6": Challenges.Challenge6.Run(); break;
                    case "7": Challenges.Challenge7.Run(); break;
                    case "8": Challenges.Challenge8.Run(); break;
                    case "9": Challenges.Challenge9.Run(); break;
                    case "10": Challenges.Challenge10.Run(); break;
                    case "11": Challenges.Challenge11.Run(); break;
                    case "12": Challenges.Challenge12.Run(); break;
                    case "13": Challenges.Challenge13.Run(); break;
                    case "14": Challenges.Challenge14.Run(); break;
                    case "15": Challenges.Challenge15.Run(); break;
                    case "16": Challenges.Challenge16.Run(); break;
                    case "17": Challenges.Challenge17.Run(); break;
                    case "18": Challenges.Challenge18.Run(); break;
                    case "19": Challenges.Challenge19.Run(); break;
                    case "20": Challenges.Challenge20.Run(); break;
                    case "21": Challenges.Challenge21.Run(); break;
                    case "22": Challenges.Challenge22.Run(); break;
                    case "23": Console.WriteLine("This challenge is unfinished :-("); Console.ReadKey(); break;
                    case "24": Console.WriteLine("This challenge is unfinished :-("); Console.ReadKey(); break;
                }
            } catch (Exception e)
            {
                return;
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                PrintMenu();
                RunChallenge(Console.ReadLine());
            }
        }
    }
}
