using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1_Week_1_Challenge_Runner.Challenges
{
    public enum CharacterType
    {
        Warrior,
        Mage,
        Thief,
        Deprived
    }
    public static class Extensions
    {
        public static Character CreateCharacter(this CharacterType type)
        {
            Character result = null;
            switch (type)
            {
                case CharacterType.Warrior:
                    result = new Character("Warrior", 200, 15);
                    break;
                case CharacterType.Mage:
                    result = new Character("Mage", 100, 100);
                    break;
                case CharacterType.Thief:
                    result = new Character("Thief", 80, 40);
                    break;
                case CharacterType.Deprived:
                    result = new Character("Deprived", 30, 0);
                    break;
            }
            return result;
        }
    }
    public class Character
    {
        public string type;
        private int HP;
        public int hp { get { return HP; } }
        private int MP;
        public int mp { get { return mp; } }
        public Character(string type, int HP, int MP)
        {
            this.type = type;
            this.HP = HP;
            this.MP = MP;
        }
    }
    class Challenge23
    {

        public static void Run()
        {
            Console.WriteLine("Press any key to generate a character");
            char opt = Console.ReadKey().KeyChar;
            CharacterType? ct = null;
        }
    }
}
