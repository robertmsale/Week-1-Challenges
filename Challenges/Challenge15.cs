using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges

{
    struct QA
    {
        public string question;
        public bool answer;
        public string explanation;

        public void checkAnswer(bool input, ref ushort score)
        {
            if (answer == input)
            {
                score += 1;
                Console.WriteLine($"\nCongrats! Your score is now {score}\n");
            }
            else
            {
                Console.WriteLine($"\n{explanation}\n");
            }
            Console.ReadKey();
        }

        public QA(string question, bool answer, string explanation)
        {
            this.question = question;
            this.answer = answer;
            this.explanation = explanation;
        }
    }
    class Challenge15
    {
        static HashSet<int> done = new HashSet<int>();
        static ushort correct = 0;

        static QA[] questions =
        {
            new QA("Regular expressions are used to manipulate strings of text.", true, "INCORRECT! Regular expressions are used in many programming languages as a way to easily search, manipulate, and filter text."),
            new QA("x86 and ARM64 are assembly languages", false, "INCORRECT! x86 and ARM64 are CPU architectures used in modern computer systems. Each CPU architecture has its own assembly language dialect, and each dialect has an assortment of languages to choose from (i.e. MASM & NASM)"),
            new QA("C# using .NET Core compiles to machine code", false, "INCORRECT! C# is compiled to byte-code (or intermediary code) which is read by a virtual machine. This allows the code to run on any machine which can run C#'s VM."),
            new QA("Debugging is the process of removing insects from your computer's chasis to fix errors.", false, "INCORRECT! Debugging is the process of fixing erroneous code using software tools such as Visual Studios."),
            new QA("The long data type stores 64 bits worth of memory", true, "INCORRECT! A long, or better known as an Int64, uses 64 bits of memory to store an integer. Hence the name Int64."),
            new QA("Static properties are initialized at compile-time.", false, "INCORRECT! Static properties are initialized during run-time right before the containing class is referenced for the first time."),
            new QA("Generic classes are classes which programmers use to define bland, regular objects.", false, "INCORRECT! Generic classes are a way for programmers to create objects which can deal with multiple, different data types with shared functionality.")
        };

        public static void Run()
        {
            Console.WriteLine("PROGRAMMING QUIZ!");
            Console.WriteLine("Prepare yourself to be tested!\n");
            for (int i = 0; i < 3; i++)
            {
                int ask = -1;
                do
                {
                    ask = Program.rng.Next(7);
                } while (done.Contains(ask));
                Console.WriteLine($"{questions[ask].question} <T/(F)>");
                char opt = Console.ReadKey().KeyChar;
                bool input = opt == 't' || opt == 'T';
                questions[ask].checkAnswer(input, ref correct);
                done.Add(ask);
            }
            Console.Write($"Final Score: {correct} of 3");
            Console.ReadKey();
        }
    }
}
