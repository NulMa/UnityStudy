namespace RecursiveChatBot {
    internal class Program {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
            RecursiveCall(0, count, "");
        }

        static void RecursiveCall(int currentDepth, int maxDepth, string indent)
        {
            if (currentDepth == maxDepth)
            {
                Console.WriteLine($"{indent}\"재귀함수가 뭔가요?\"");
                Console.WriteLine($"{indent}\"재귀함수는 자기 자신을 호출하는 함수라네\"");
                Console.WriteLine($"{indent}라고 답변하였지.");
                return;
            }

            string nextIndent = indent + "____";
            Console.WriteLine($"{indent}\"재귀함수가 뭔가요?\"");
            Console.WriteLine($"{indent}\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
            Console.WriteLine($"{indent}마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
            Console.WriteLine($"{indent}그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");


            RecursiveCall(currentDepth + 1, maxDepth, nextIndent);
            Console.WriteLine($"{indent}라고 답변하였지.");
        }
    }
}


/*
 * 
 *  curD = 0, maxD = 4 indent = ""
 *      **dont write base case
 *      write lines
 *      
 *      curD = 1, maxD = 4 indent = "____"
 *          **dont write base case
 *          write lines
 *          
 *          curD = 2, maxD = 4 indent = "________"
 *              **dont write base case
 *              write lines
 *              
 *              curD = 3, maxD = 4 indent = "____________"
 *                  **dont write base case
 *                  write lines
 *                  
 *                  curD = 4, maxD = 4 indent = "________________"
                        base case
 *                      **don't write lines
 *                      
 *              "____________"라고 답변하였지.                             close curD = 3
 *          "________"라고 답변하였지.                                     close curD = 2
 *      "____"라고 답변하였지.                                             close curD = 1
 *  ""라고 답변하였지.                                                     close curD = 0
 *  
 *  
 *  ===========================================================================================


어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.
"재귀함수가 뭔가요?"
"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.
마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.
그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어."
____"재귀함수가 뭔가요?"
____"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.
____마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.
____그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어."
________"재귀함수가 뭔가요?"
________"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.
________마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.
________그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어."
____________"재귀함수가 뭔가요?"
____________"재귀함수는 자기 자신을 호출하는 함수라네"
____________라고 답변하였지.
________라고 답변하였지.
____라고 답변하였지.
라고 답변하였지.
 * 
 */