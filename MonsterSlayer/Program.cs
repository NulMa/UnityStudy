using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace MonsterSlayer {

    class Character {
        public string Name;
        public int Hp;
        public int Atk;
        Random rand = new Random();

        public Character(string name, int hp, int atk) {    }

        public virtual void Attack(Character target) {

        }

        public bool IsDead() {
            if (Hp <= 0)
                return true;
            return false;
        }
    }

    class Player : Character {

        public int Exp = 0;

        public Player(string name, int hp, int atk) : base(name, hp, atk) {
            Name = name;
            Hp = hp;
            Atk = atk;
        }

        public void GainExp(int amount) {
            Exp += amount;
        }

        public override void Attack(Character target) {
            Random rand = new Random();
            int damage = rand.Next(Atk - 5, Atk + 15);
            target.Hp -= damage;

            Thread.Sleep(100);
            if (damage > 20) {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n     <<Critical Hit!>>");
                Console.ResetColor();
            }
            Console.WriteLine($"You Attack {target.Name} with {damage}DMG\n");

        }
    }

    class Monster : Character {
        public Monster(string name) : base(name, 0, 0) {
            Name = RandomName();
            Random rand = new Random();
            Hp = rand.Next(20, 51);
            Atk = rand.Next(2, 7);
        }
        static string RandomName() {
            string[] names = { "Slime", "Goblin", "Wolf", "Bat" };
            return names[new Random().Next(names.Length)];
        }
        public override void Attack(Character target) {
            Random rand = new Random();
            target.Hp -= rand.Next(Atk - 5, Atk + 2);
            Thread.Sleep(100);
            Console.WriteLine($"{Name}'s Attack, {Atk}DMG");
        }

    }



    internal class Program {
        public static bool AskToContinue() {
            Console.WriteLine("Do you want to continue? (y/n)");
            string input = Console.ReadLine();
            if (input.ToLower() == "y") {
                return true;
            }
            else {
                return false;
            }
        }

        static void Main(string[] args) {
            Random rand = new Random();
            Player player = new Player("Player", 100, 10);

            bool gameRunning = true;

            while (gameRunning) {
                Monster monster = new Monster("");
                Console.WriteLine($"\n\nYou Found {monster.Name}!\n (HP: {monster.Hp}, ATK: {monster.Atk})");
                Thread.Sleep(300);
                while (!monster.IsDead()) {
                    player.Attack(monster);
                    if (monster.IsDead()) {
                        Console.WriteLine($"You Slay {monster.Name}.");
                        player.GainExp(10);
                        Console.WriteLine($"gain 10 EXP! Current EXP: {player.Exp}");
                        Console.WriteLine($"Your HP is {player.Hp}\n\n");
                        gameRunning = AskToContinue();
                        Thread.Sleep(1000);
                        break;
                    }
                    monster.Attack(player);
                    if (player.IsDead()) {
                        Console.WriteLine("YOU DIED.");
                        return;
                    }
                }

            }
        }
    }
}
