using System;
using System.Timers;

namespace WoT
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(1, 10);
            Ammo_Default ammo = new Ammo_Default();
            Traking trak = new Traking();
            trak.Start(gun, ammo);
            Console.ReadLine();
        }

    }
}
