//#define BARK
#define DOG
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace StaticPrac
{
    class Knight
    {

        public int Hp       // property
        {
            get { return Hp; }
            set { Hp = value; }
        }

    }


    class Test
    {
        [Conditional("DOG")]
        public static void Dog()
        {
            Bark();
        }

        [Conditional("BARK")]
        public static void Bark()
        {
            Console.WriteLine("Baw-Wow");
        }

        [Obsolete("No")]
        public static void TestFunc00()
        {

        }

        [Obsolete("I Said No", true)]
        public static void TestFunc01()
        {

        }

        public static void TestFunc02()
        {

        }

        [DllImport("User32.dll")]
        public static extern int MessageBox(int hand, string text, string caption, int type);


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.Dog();
            Test.TestFunc00();
            //Test.TestFunc01();
            Test.TestFunc02();

            Test.MessageBox(0, "우학학", "메세지니라", 0);
        }
    }
}
