using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputManager
{
    class Program
    {
        static void OnInput()
        {
            Console.WriteLine("Input Detected");
        }
        static void Main()
        {
            InputManager inputManager = new InputManager();

            //inputManager.InputKey += OnInput();

            while (true)
            {
                inputManager.Update();
            }

        }
    }
}
