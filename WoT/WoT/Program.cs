﻿using System;
using System.Timers;

namespace WoT
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(1, 10);
            Tanchik tank = new Tanchik(0, 0, gun);
            tank.Fire();
            Console.ReadLine();
        }

    }
}
