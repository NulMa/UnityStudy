using System.Threading;
using UnityStudy;

namespace Mudgame {
    class Program {
        enum ClassType {
            None,
            Knight,
            Mage,
            Rogue
        }
        
        enum MonsterType {
            None,
            Slime,
            Orc,
            Skeleton
        }

        struct Player {
            public ClassType classType;
            public int hp;
            public int atk;
        }
        struct Monster {
            public string name;
            public int hp;
            public int atk;
            public int Difficult;
        }
        static void Main(string[] args) {
            ClassType choice = ClassType.None;

            while (true) {
                choice = ClassChoice();
                if (choice != ClassType.None) {
                    // 캐릭터 생성
                    int hp;
                    int atk;
                    CreatePlayer(choice, out hp, out atk);

                    Console.Clear();

                    Console.WriteLine($"당신의 직업 : {choice}");
                    Console.WriteLine($"HP {hp}, ATK {atk}");

                    Console.Clear();
                    CreateRandomMonster(out Monster monster);
                }
            }
        }
        static ClassType ClassChoice() {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 마법사");
            Console.WriteLine("[3] 도둑");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();

            switch (input) {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Mage;
                    break;
                case "3":
                    choice = ClassType.Rogue;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out int hp, out int atk) {
            // 기사(100/10), 마법사(50/15), 도둑(75/12)
            switch (choice) {
                case ClassType.Knight:
                    hp = 100;
                    atk = 10;
                    break;

                case ClassType.Mage:
                    hp = 50;
                    atk = 15;
                    break;

                case ClassType.Rogue:
                    hp = 75;
                    atk = 12;
                    break;

                default:
                    hp = 75;
                    atk = 1;
                    break;
            }
        }

        static int SetMonsterDiff() {
            Random rand = new Random();
            int difficult = rand.Next(1, 101);
            switch (rand.Next(1, 101)) {
                case int n when (n >= 0 && n <= 60):
                    difficult = 1;
                    break;

                case int n when (n >= 61 && n <= 85):
                    difficult = 2;
                    break;

                case int n when (n >= 86 && n <= 90):
                    difficult = 3;
                    break;

                default:
                    difficult = 0;
                    break;
            }
            return difficult;
        }
        static void CreateRandomMonster(out Monster monster) {
            Random rand = new Random();
            int diff = SetMonsterDiff();
            monster.Difficult = diff;

            MonsterType monsterType = (MonsterType)rand.Next(1, 4);
            switch (monsterType) {
                case MonsterType.Slime:
                    monster.name = "Slime";
                    monster.hp = 20;
                    monster.atk = 2;
                    break;

                case MonsterType.Orc:
                    monster.name = "Orc";
                    monster.hp = 40;
                    monster.atk = 4;
                    break;

                case MonsterType.Skeleton:
                    monster.name = "Skeleton";
                    monster.hp = 30;
                    monster.atk = 3;
                    break;

                default:
                    monster.name = "Unknown";
                    monster.hp = 10;
                    monster.atk = 1;
                    break;
            }

            monster.hp *= diff;
            monster.atk *= diff;

            if(diff == 0) {
                Console.WriteLine("Nothing is here.");
                return;
            }

            Console.WriteLine($"Grade : {diff}\n{monsterType} is Spawned\nHp : {monster.hp}\nAtk : {monster.atk}");
        }
    }
}
