using System;
using System.Timers;

namespace WoT
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(1, 10);
            Traking.Start(gun);
            Console.ReadLine();
        }

    }
}
