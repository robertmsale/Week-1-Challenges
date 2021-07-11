using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges

{
    struct Totals
    {
        public int? sword;
        public int? shield;
        public float? potion;
    }
    class Challenge10
    {
        public static int? swordPrice;
        public static int? shieldPrice;
        public static float? potionPrice;
        public static void Run()
        {
            string[] banner = {
                "                                                                                 ",
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
                "                                                                                 ",
            };
            // Prices may vary :-)
            swordPrice = Program.rng.Next(20);
            shieldPrice = Program.rng.Next(20);
            potionPrice = ((float)Program.rng.NextDouble() * 10.0f);

            int swords = 0;
            int shields = 0;
            float potion = 0.0f;
            foreach (string line in banner) { Console.WriteLine(line); }
            Console.WriteLine($"Sword\t- {swordPrice} gold each\nShield\t- {shieldPrice} gold each\nPotion\t- {potionPrice} per ounce\n");
            Console.Write("How many Swords would you like? ");
            swords = Int32.Parse(Console.ReadLine());
            Console.Write("How many Shields would you like? ");
            shields = Int32.Parse(Console.ReadLine());
            Console.Write("How much Potion would you like? ");
            potion = Single.Parse(Console.ReadLine());

            Totals totals = new Totals();
            totals.sword = swords * swordPrice;
            totals.shield = shields * shieldPrice;
            totals.potion = potion * potionPrice;

            Console.WriteLine($"{swords} Swords = {totals.sword} gold");
            Console.WriteLine($"{shields} Shields = {totals.shield} gold");
            Console.WriteLine($"{potion} Ounces of Potion = {totals.potion} gold");
            Console.WriteLine("================================");
            Console.WriteLine($"Total Cost = {((float)totals.sword) + ((float)totals.shield) + ((float)totals.potion)}");

            Console.ReadKey();

        }
    }
}
