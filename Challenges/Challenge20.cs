using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    public enum EightBall
    {
        Yep,
        Nope,
        TryAgainLater,
        Perhaps,
        OK,
        Sure,
        Uhhhh
    }
    public static class MagicExtension
    {
        public static string predict(this EightBall prediction)
        {
            string result = "";
            switch (prediction)
            {
                case EightBall.Yep: result = "Yep"; break;
                case EightBall.Nope: result = "Nope"; break;
                case EightBall.TryAgainLater: result = "Try again later"; break;
                case EightBall.Perhaps: result = "Perhaps"; break;
                case EightBall.OK: result = "OK"; break;
                case EightBall.Sure: result = "Sure"; break;
                case EightBall.Uhhhh: result = "Uhhhh"; break;
            }
            return result;
        }
    }
    class Challenge20
    {
        public static string[] banner =
        {
            " .::       .::                              .::::::::                      .::   ",
            " .: .::   .:::                    .:        .::       .:         .::       .::   ",
            " .:: .:: . .::   .::       .::         .::: .::            .::   .::     .:.: .: ",
            " .::  .::  .:: .::  .::  .::  .::.:: .::    .::::::  .:: .::  .::.: .:     .::   ",
            " .::   .:  .::.::   .:: .::   .::.::.::     .::      .::.::   .::.::  .::  .::   ",
            " .::       .::.::   .::  .::  .::.:: .::    .::      .:: .::  .::.:   .::  .::   ",
            " .::       .::  .:: .:::     .:: .::   .::: .::::::::.::     .:: .::  .::   .::  ",
            "                          .::                             .::                    ",
            "                           .:: .::              .:: .::                          ",
            "                           .:    .::            .:: .::                          ",
            "                           .:     .::   .::     .:: .::                          ",
            "                           .::: .:    .::  .::  .:: .::                          ",
            "                           .:     .::.::   .::  .:: .::                          ",
            "                           .:      .:.::   .::  .:: .::                          ",
            "                           .:::: .::   .:: .:::.:::.:::                          ",
        };
        public static string[] ateball =
        {
            "        ____",
            "    ,dP9CGG88@b,",
            "  ,IP  _   Y888@@b,",
            " dIi  (_)   G8888@b",
            "dCII  (_)   G8888@@b",
            "GCCIi     ,GG8888@@@",
            "GGCCCCCCCGGG88888@@@",
            "GGGGCCCGGGG88888@@@@...",
            "Y8GGGGGG8888888@@@@P.....",
            " Y88888888888@@@@@P......",
            " `Y8888888@@@@@@@P'......",
            "    `@@@@@@@@@P'.......",
            "        \"\"\"\"........",
        };
        public static void Run()
        {
            foreach (string line in banner) { Console.WriteLine(line); }
            foreach (string line in ateball) { Console.WriteLine(line); }
            Console.Write("\n\nAsk me anything and I will answer!\n\n\t-> ");
            Console.ReadLine();
            Console.Write(((EightBall)Program.rng.Next(7)).predict());
            Console.ReadKey();
        }
    }
}
