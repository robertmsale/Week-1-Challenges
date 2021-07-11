using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge3
    {
        public static string name = "";
        public static string age = "";

        static void PrintAndRead(string message, ref string value) // Convenience method for printing to Standard Output with special color formating
        {
            Console.ForegroundColor = ConsoleColor.Gray; // Set message to darker color
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.White; // Set user input to brighter color to make it more distinguishable
            value = Console.ReadLine();
        }
        public static void Run()
        {
            int ageNum = -1; // I prefer initializing numerical values as impossible numbers (i.e. nobody is less than 0 years old) to make debugging easier

            // Set colors and clear console
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();

            PrintAndRead("What is your name?\n\t-> ", ref name); // Get name with zero validation

            while (true) // Initiate infinite loop of doom
            {
                PrintAndRead("Now, what is your age in years?\n\t-> ", ref age); // Get age
                try
                {
                    ageNum = Int32.Parse(age);
                }
                catch (Exception e) // Catch error from parsing an invalid number
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nAge must be a number! Please try again.\n");
                    continue;
                }
                if (ageNum <= 0) // User must be >= 1 years old
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"\nThat's impossible! You must be older than {age} years old! Please try again.\n");
                }
                else
                {
                    break; // If all validation is successful, break from the venerable infinite loop of doom
                }
            }

            Console.Write($"Fun fact: You, {name}, are at least {(int)(ageNum * 365.25)} days old!"); // Used 365.25 instead of 365 to compensate for leap years
            Console.ReadKey(); // Obligatory pause so user can view results
        }
    }
}
