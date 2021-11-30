using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace WoT
{
    public static class Traking
    {
        static double t = 0;
        const double g = 9.8;
        static double X;
        static double Y;


        static Timer timer = new Timer();
        static Gun gun;

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        { 
            t += 0.01;
            X = (gun.Forse * Math.Cos(gun.Angle)) * t;
            Y = (gun.Forse * Math.Sin(gun.Angle)) * t - g * t * t / 2;
            Console.WriteLine($"Y: {Y}, X: {X}");

        }

        public static void Start(Gun gun)
        {
            Traking.gun = gun;
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Start();
        }

    }

}