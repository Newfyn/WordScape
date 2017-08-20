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

        class Sample
        {
            public static void Chatloop()
            {
                string str = Console.ReadLine();
                Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
                Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

                int length = str.Length;
                Console.WriteLine("3) The length of '{0}' is '{1}'", str, length);



            }
        }


        static void Chatloop(string playername)
        {
            Console.WriteLine("Welcome to WordScape.");

            while (true)
            {
                
                var input = Console.ReadLine();
                if (input.Length <= Console.BufferWidth)
                    {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {playername}: {input}");
                }
                if (input.Length > Console.BufferWidth && input.Length <= Console.BufferWidth*2)
                    {
                    for (var i = 0; i < 2;)
                        {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        i++;
                        }
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {playername}: {input}");
                }
                if (input.Length > Console.BufferWidth*2 && input.Length <= Console.BufferWidth*3)
                    {
                    for (var i = 0; i < 3;)
                        {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        i++;
                        }
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {playername}: {input}");
                }
                if (input.Length > Console.BufferWidth*3 && input.Length <= 254)
                    {
                    for (var i = 0; i < 4;)
                        {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        i++;
                        }
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {playername}: {input}");
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
        
    }
}
