using System;
using System.Timers;

namespace WoT
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();

            Console.ReadLine();
        }

    }
}
