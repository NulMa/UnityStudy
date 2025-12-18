namespace InputManager
{
	class InputManager
	{
        public delegate void OnInputKey();
        public event OnInputKey? InputKey;
        public void Update()
		{
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                if(info.Key == ConsoleKey.A)
                {
                    InputKey();
                }
            }
        }
	}
}
