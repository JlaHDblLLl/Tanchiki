﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
namespace WoT
{
    public class Bullet : ITick
    {
        const double g = 9.8;
        public double X { get; set; }
        public double BeginX { get; set; }
        public double Y { get; set; }
        public double BeginY { get; set; }
        public int Count { get; set; } //подумать над каунтом(как его задавать)

        Tanchik TankWhoShoot;

        public Bullet(Tanchik tank)
        {
            this.X = tank.X;
            this.Y = tank.Y;
            this.TankWhoShoot = tank;
        }

        public void Tick(TimeSpan span)
        {
            double t = (double)(span.Seconds + span.Milliseconds / 1000.0);
            this.X += (TankWhoShoot.gun.Force * Math.Cos(TankWhoShoot.gun.Angle)) * t;
            this.Y += (TankWhoShoot.gun.Force * Math.Sin(TankWhoShoot.gun.Angle)) * t - g * t * t / 2;

            Console.WriteLine($"{this.X}, {this.Y}");
        }
        public void Check(Map map, ICollection<Bullet> bulcontr) 
        {
            double y = map.Funk(X);
            if (y >= this.Y) 
            {
                Console.WriteLine("Popal v map");
                bulcontr.Remove(this);
            }
            else if(y < 0)
            {
                Console.WriteLine("Yletel");
                bulcontr.Remove(this);
            }
        }
        public void Check(Tanchik tank, ICollection<Bullet> bulcontr)
        {
            if (Math.Abs(tank.Y - this.Y) <= 1 && Math.Abs(tank.X - this.X) <= 1 && this.TankWhoShoot != tank)
            {
                Console.WriteLine("Popal v Tank");
                bulcontr.Remove(this);
            }
        }

        //private void Fly(Object source, ElapsedEventArgs e)
        //{
        //    t += 0.01;
        //this.X = (gun.Forse* Math.Cos(gun.Angle)) * t + this.x;
        //this.Y = (gun.Forse* Math.Sin(gun.Angle)) * t - g* t * t / 2 + this.y;
        //    Console.WriteLine($"Y: {this.Y}, X: {this.X}");
        //    this.Count--;
        //    if (this.Count == 0) // сюда поместить IsHit
        //    {
        //        timer.Stop();
        //        timer.Dispose();
        //        this.Count--;
        //    }
        //}
    }
}