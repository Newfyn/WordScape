using System;

namespace WordScape
{
    class Program
    {
        static void Main(string[] args)
        {
            var playername = GetPlayerName();
            Chatloop(playername);
        }

        static void Chatloop(string playerName)
        {
            Console.WriteLine("Welcome to WordScape.");

            while (true)
            {
                
                var input = Console.ReadLine();
                if (input.Length <= Console.BufferWidth)
                {
                    ClearLines(1);
                    PrintMessage(playerName, input);
                }
                if (input.Length > Console.BufferWidth && input.Length <= Console.BufferWidth*2)
                {
                    ClearLines(2);
                    PrintMessage(playerName, input);
                }
                if (input.Length > Console.BufferWidth*2 && input.Length <= Console.BufferWidth*3)
                {
                    ClearLines(3);
                    PrintMessage(playerName, input);
                }
                if (input.Length > Console.BufferWidth*3 && input.Length <= 254)
                {
                    ClearLines(4);
                    PrintMessage(playerName, input);
                }
            }
            
        }
        static string GetPlayerName()

        {
            Console.Write("Please enter your username: ");
            var playername = Console.ReadLine();
            Console.Clear();
            return playername;
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void ClearLines(int numberOfLines)
        {
            for (var i = 0; i < numberOfLines;)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                i++;
            }
        }

        public static void PrintMessage(string playerName, string input)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {playerName}: {input}");
        }

    }
}
