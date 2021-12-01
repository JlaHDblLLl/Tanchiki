using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace WoT
{
    public class Traking
    {
        double t = 0;
        const double g = 9.8;


        Timer timer = new Timer();
        Gun gun;
        Ammo ammo;

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        { 
            t += 0.01;
            ammo.X = (gun.Forse * Math.Cos(gun.Angle)) * t;
            ammo.Y = (gun.Forse * Math.Sin(gun.Angle)) * t - g * t * t / 2;
            Console.WriteLine($"Y: {ammo.Y}, X: {ammo.X}");

        }

        public void Start(Gun gun, Ammo ammo)
        {
            this.gun = gun;
            this.ammo = ammo;
            timer.Interval = 100;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Start();
        }

    }

}