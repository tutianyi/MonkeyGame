using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonkeyGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("（1.香蕉  2.波  3.挡  4.拳  5.闪）");
            Console.WriteLine();

            Monkey lived = new Lived("  您", Input);
            Monkey computer = new Computer("电脑");
            Game game = new Game(lived, computer);

            Monkey winner = null;
            int round = 1;
            while (winner == null)
            {
                Console.WriteLine("【第{0}回合】", round++);
                string message;
                winner = game.Round(out message);
                Console.WriteLine(message);
                Console.WriteLine();
            }
            Console.WriteLine("\n胜利的是：{0} ", winner.Name);

            Console.ReadLine();
        }

        static int Input()
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.D1: return 1;
                    case ConsoleKey.D2: return 2;
                    case ConsoleKey.D3: return 3;
                    case ConsoleKey.D4: return 4;
                    case ConsoleKey.D5: return 5;
                }
            }
        }
    }
}
