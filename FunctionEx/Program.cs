namespace FunctionEx {
    internal class Program {
        static void Output(int fnA, int fnB) {
            Console.WriteLine(fnA + fnB);
        }

        static int Test(int  fnA) {
            return fnA + 1;
        }

        static int ExplanationFunc(int exA, int exB) {
            return exA + exB;
        }

        static string TextTest() {
            string text = Console.ReadLine();
            text = text + "<- is your answer";
            return text;
        }
        
        static void Main(string[] args) {
            int a = 10;
            int b = 20;

            Output(a, b);
            
            int result = Test(a);
            Console.WriteLine(result);

            string userText = TextTest();
            Console.WriteLine(userText);
        }
    }
}
