namespace ManaZoo {
    abstract class Animal {
        protected string AnimalName;
        public Animal(string name) {
            AnimalName = name;
            Console.WriteLine($"안녕하세요, 저는 {AnimalName}입니다");
        }
        public abstract void MakeSound();

    }

    class Dog : Animal {
        public Dog(string name) : base(name) { }
        public override void MakeSound() {
            Console.WriteLine("멍멍!");
            Console.WriteLine();
        }
    }
    class Cat : Animal {
        public Cat(string name) : base(name) { }
        public override void MakeSound() {
            Console.WriteLine("애옹");
            Console.WriteLine();
        }
    }
    class Cow : Animal {
        public Cow(string name) : base(name) { }
        public override void MakeSound() {
            Console.WriteLine("가챠 1트럭에 10만원이면 싸다고 생각해요");
            Console.WriteLine();
        }
    }

    internal class Program {
        static void Main(string[] args) {
            Animal dog = new Dog("댕댕이");
            dog.MakeSound();

            Animal cat = new Cat("나비");
            cat.MakeSound();

            Animal cow = new Cow("흑우");
            cow.MakeSound();
        }
    }
}