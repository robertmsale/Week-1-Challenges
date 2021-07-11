using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    class Challenge22
    {
        public class Prices
        {
            public int sword;
            public int shield;
            public int potion;

            public Prices()
            {
                sword = Program.rng.Next(4, 21);
                shield = Program.rng.Next(9, 16);
                potion = Program.rng.Next(4, 11);
            }
        }
        public class TickerTape
        {
            public int sword = 0;
            public int shield = 0;
            public float potion = 0.0f;
            private Prices prices;

            public TickerTape(Prices prices)
            {
                this.prices = prices;
            }

            public string DeriveCurrency(float total)
            {
                int gold = 0;
                int silver = 0;
                gold = (int)total;
                silver = (int)((total - gold) * 100);
                return $"{gold} Gold {silver} Silver";
            }
            public string StringifyCurrency((int, int) currency)
            {
                return $"{currency.Item1} Gold {currency.Item2} Silver";
            }

            public bool DisplayTicker()
            {
                bool exit = false;
                Console.WriteLine("\nItem\t\tPrice");
                Console.WriteLine("====================");
                float sub = 0.0f;
                if (sword > 0)
                {
                    Console.WriteLine($"{sword} Swords\t\t{prices.sword * sword} Gold");
                    sub += prices.sword * sword;
                }
                if (shield > 0)
                {
                    Console.WriteLine($"{shield} Shields\t\t{prices.shield * shield} Gold");
                    sub += prices.shield * shield;
                }
                if (potion > 0)
                {
                    Console.WriteLine($"{potion}oz Potion\t\t{DeriveCurrency(prices.potion * potion)}");
                    sub += prices.potion * potion;
                }
                Console.Write("\n--------------------\n");
                Console.WriteLine($"SubTotal\t\t\t{DeriveCurrency(sub)}");
                Console.WriteLine($"5% Sales tax\t\t\t{DeriveCurrency(sub * 0.05f)}");
                Console.Write("--------------------\n");
                Console.WriteLine($"Total\t\t\t\t{DeriveCurrency(sub * 1.05f)}");
                Console.Write("Buy more goods? <Y/(N)> ");
                char opt = Console.ReadKey().KeyChar;
                if (opt != 'y' && opt != 'Y')
                {
                    exit = true;
                }
                return exit;
            }

        }
        public static string[] banner =
        {
                "          ______           __  __            __                    _             ",
                "         / ____/__  ____  / /_/ /__         / /__  ____________  _( )_____       ",
                "        / / __/ _ \\/ __ \\/ __/ / _ \\   __  / / _ \\/ ___/ ___/ / / /// ___/       ",
                "       / /_/ /  __/ / / / /_/ /  __/  / /_/ /  __/ /  / /  / /_/ / (__  )        ",
                "       \\____/\\___/_/ /_/\\__/_/\\___/   \\____/\\___/_/  /_/   \\__, / /____/         ",
                "                                                          /____/                 ",
                "          ______                     _         ______                __          ",
                "         / ____/__  ____  ___  _____(_)____   / ____/___  ____  ____/ /____      ",
                "        / / __/ _ \\/ __ \\/ _ \\/ ___/ / ___/  / / __/ __ \\/ __ \\/ __  / ___/      ",
                "       / /_/ /  __/ / / /  __/ /  / / /__   / /_/ / /_/ / /_/ / /_/ (__  )       ",
                "       \\____/\\___/_/ /_/\\___/_/  /_/\\___/   \\____/\\____/\\____/\\__,_/____/        ",
                "                                Press esc to exit                                ",
        };
        public static void DisplayMenu(Prices prices)
        {
            Console.Clear();
            foreach (string line in banner) { Console.WriteLine(line); }
            Console.WriteLine("\nBuy some goods now (and experience tax)");
            Console.WriteLine($"1) Sword\t- {(int)prices.sword} gold");
            Console.WriteLine($"2) Shield\t- {(int)prices.shield} gold");
            Console.WriteLine($"3) Potion\t- {(int)prices.potion} gold/ounce");
        }
        public static void Run()
        {
            Prices prices = new Prices();
            TickerTape ticker = new TickerTape(prices);
            while (true)
            {
                DisplayMenu(prices);
                Console.Write("What would you like to buy? ");
                char opt = Console.ReadKey().KeyChar;
                if (opt == 27)
                {
                    Console.WriteLine("\nBuh-bye now!");
                    Console.ReadKey();
                }
                else if (opt != '1' && opt != '2' && opt != '3')
                {
                    Console.Write("You gotta make a valid choice...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("\nHow many? ");
                float amt = Single.Parse(Console.ReadLine());
                switch (opt)
                {
                    case '1':
                        ticker.sword += (int)amt;
                        break;
                    case '2':
                        ticker.shield += (int)amt;
                        break;
                    case '3':
                        ticker.potion += amt;
                        break;
                }
                Console.WriteLine();
                DisplayMenu(prices);
                if (ticker.DisplayTicker()) { return; }
            }
        }
    }
}
