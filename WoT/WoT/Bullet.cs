﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace WoT
{
    public class Bullet
    {
        double t = 0;
        const double g = 9.8;
        public double X { get; set; }
        public double Y { get; set; }
        public int Count { get; set; } //подумать над каунтом(как его задавать)

        Gun gun; // что делать с этой несостыковкой
        public Ammo Type; // реализовать выбор определенного типа

        private Timer timer = new Timer();
        public Bullet(double x, double y, Gun gun)
        {
            this.X = x;
            this.Y = y;
            this.gun = gun;

            timer.Interval = 100;
            timer.Elapsed += Fly;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void Fly(Object source, System.Timers.ElapsedEventArgs e)
        {
            t += 0.01;
            this.X = (gun.Forse * Math.Cos(gun.Angle)) * t;
            this.Y = (gun.Forse * Math.Sin(gun.Angle)) * t - g * t * t / 2;
            this.Count--;
            Console.WriteLine($"Y: {this.Y}, X: {this.X}");
            if (this.Count == 0)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
    }
}