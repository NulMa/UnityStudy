using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;

namespace ForeachPrac
{
    internal class Program
    {
        class MyArrayEnumerator : IEnumerator
        {
            private int[] _container;
            private int _index = -1;

            public object Current{
                get
                {
                    if (_index < 0 || _index >= _container.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    return _container[_index];
                }
            }

            public bool MoveNext()
            {
                _index++;

                return _index < _container.Length;
            }

            public void Reset()
            {
                _index = -1;
            }
        }

        // 인터페이스 상속
        class MyArray : IEnumerable
        {
            // 우리 타입 내부에 있는 _container 순회
            private int[] _container = { 1, 2, 3, 4, 5 };

            // MyArray를 순회할 수 있는 열거자를 반환한다.
            public IEnumerator GetEnumerator()
            {
                // IEnumerator 타입의 객체를 반환한다.
                throw new NotImplementedException();
            }
        }


        static void Main()
        {
            MyArray myArray = new MyArray();


            List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
            for (int i = 0; i < fibNumbers.Count; i++)
            {
                int fibNumber = fibNumbers[i];
                Console.WriteLine(fibNumbers[i]);
            }

            foreach (int fibNumber in myArray)
            {
                Console.WriteLine(fibNumber);
            }

            IEnumerator enumerator = myArray.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int fibNumber = (int)enumerator.Current;
                Console.WriteLine(fibNumber);
            }


            // var enumerator = myArray.GetEnumerator();

            //IEnumerator<int> enumerator = fibNumbers.GetEnumerator();

            //foreach (int fibNumber in fibNumbers)
            //{
            //    Console.WriteLine(fibNumber);
            //}

        }
    }
}