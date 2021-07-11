using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    struct Quote
    {
        public string name;
        public string quote;
        public Quote(string quote, string name)
        {
            this.name = name;
            this.quote = quote;
        }
    }
    class Challenge18
    {
        static Quote[] db =
        {
            new Quote("The greatest glory in living lies not in never falling, but in rising every time we fall.", "Nelson Mandela"),
            new Quote("The way to get started is to quit talking and begin doing.", "Walt Disney"),
            new Quote("Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma which is living with the results of other people's thinking.", "Steve Jobs"),
            new Quote("If life were predictable it would cease to be life, and be without flavor.", "Eleanor Roosevelt"),
            new Quote("If you look at what you have in life, you'll always have more. If you look at what you don't have in life, you'll never have enough.", "Oprah Winfrey"),
            new Quote("If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success.", "James Cameron"),
            new Quote("Life is what happens when you're busy making other plans.", "John Lennon"),
            new Quote("Spread love everywhere you go. Let no one ever come to you without leaving happier.", "Mother Teresa"),
            new Quote("When you reach the end of your rope, tie a knot in it and hang on.", "Franklin D. Roosevelt"),
            new Quote("Always remember that you are absolutely unique. Just like everyone else.", "Margaret Mead"),
            new Quote("Don't judge each day by the harvest you reap but by the seeds that you plant.", "Robert Louis Stevenson"),
            new Quote("The future belongs to those who believe in the beauty of their dreams.", "Eleanor Roosevelt"),
            new Quote("Tell me and I forget. Teach me and I remember. Involve me and I learn.", "Benjamin Franklin"),
            new Quote("The best and most beautiful things in the world cannot be seen or even touched, they must be felt with the heart.", "Helen Keller"),
            new Quote("It is during our darkest moments that we must focus to see the light.", "Aristotle"),
            new Quote("Whoever is happy will make others happy too.", "Anne Frank"),
            new Quote("Do not go where the path may lead, go instead where there is no path and leave a trail.", "Ralph Waldo Emerson"),
            new Quote("You will face many defeats in life, but never let yourself be defeated.", "Maya Angelou"),
            new Quote("The greatest glory in living lies not in never falling, but in rising every time we fall.", "Nelson Mandela"),
            new Quote("In the end, it's not the years in your life that count. It's the life in your years.", "Abraham Lincoln"),
            new Quote("Never let the fear of striking out keep you from playing the game.", "Babe Ruth"),
            new Quote("You have brains in your head. You have feet in your shoes. You can steer yourself any direction you choose.", "Dr. Seuss"),
            new Quote("Life is either a daring adventure or nothing at all.", "Helen Keller"),
            new Quote("Many of life's failures are people who did not realize how close they were to success when they gave up.", "Thomas A. Edison"),
        };
        static string[] banner =
        {
            "                                                                                 ",
            "                     .d88888b.                 888                               ",
            "                    d88P\" \"Y88b                888                               ",
            "                    888     888                888                               ",
            "                    888     888888  888 .d88b. 888888 .d88b.                     ",
            "                    888     888888  888d88\"\"88b888   d8P  Y8b                    ",
            "                    888 Y8b 888888  888888  888888   88888888                    ",
            "                    Y88b.Y8b88PY88b 888Y88..88PY88b. Y8b.                        ",
            "                     \"Y888888\"  \"Y88888 \"Y88P\"  \"Y888 \"Y8888                     ",
            "                           Y8b                                                   ",
            "                                                                                 ",
            "                                                                                 ",
            "            888b     d888                888     d8b                             ",
            "            8888b   d8888                888     Y8P                             ",
            "            88888b.d88888                888                                     ",
            "            888Y88888P888 8888b.  .d8888b88888b. 88888888b.  .d88b.              ",
            "            888 Y888P 888    \"88bd88P\"   888 \"88b888888 \"88bd8P  Y8b             ",
            "            888  Y8P  888.d888888888     888  888888888  88888888888             ",
            "            888   \"   888888  888Y88b.   888  888888888  888Y8b.                 ",
            "            888       888\"Y888888 \"Y8888P888  888888888  888 \"Y8888              ",
            "                                                                                 ",
        };
        public static void Run()
        {
            List<Quote> choices = new List<Quote>();
            foreach (string line in banner)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("==================");
            for (int i = 0; i < 3; i++)
            {
                choices.Add(db[Program.rng.Next(db.Length)]);
                Console.WriteLine($"{i + 1} - {choices.Last().name}");
            }
            Console.WriteLine("==================");
            Console.Write("Choose a person: ");
            Quote? pick;
            switch (Console.ReadKey().KeyChar)
            {
                case '1': pick = choices[0]; break;
                case '2': pick = choices[1]; break;
                default: pick = choices[2]; break;
            }
            Console.WriteLine($"\n\"{pick.Value.quote}\" -{pick.Value.name}");
            Console.ReadKey();
        }
    }
}
