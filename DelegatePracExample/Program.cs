namespace DelegatePracExample
{
    class Enemy
    {
        public delegate void OnDie(string killerName, int reward);

        string Name;
        int Hp;
        int Reward;
        OnDie onDieCallBack;

        public Enemy(string name, int hp, int reward, OnDie onDieCallback)
        {
            Name = name;
            Hp = hp;
            Reward = reward;
            onDieCallBack = onDieCallback;
        }

        public void TakeDamage(int amount, string attacker)
        {
            Hp -= amount;
            Console.WriteLine($"[{Name}] HP:{Hp}");
            if (Hp <= 0)
            {
                if (onDieCallBack != null)
                {
                    Console.WriteLine($"[{Name}] 처치!");
                    onDieCallBack.Invoke(attacker, Reward);
                }
            }
        }

        public void Heal(int amount)
        {
            Hp += amount;
            Console.WriteLine($"[{Name}] HP:{Hp}");
        }
    }
    internal class Program
    {
        static void OnEnemyDie(string killerName, int reward)
        {
            Console.WriteLine($"[{killerName}]이(가) +{reward}점 획득!");
            Console.WriteLine("[효과음 재생]");
        }
        static void Main(string[] args)
        {
            Enemy slime = new Enemy("Slime", 20, 100, OnEnemyDie);
            slime.TakeDamage(5, "Knight"); 
            slime.Heal(10);
            slime.TakeDamage(30, "Knight");
        }
    }
}
