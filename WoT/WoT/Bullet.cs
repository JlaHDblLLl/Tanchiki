using System;
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
        public double Y { get; set; }
        public int Count { get; set; } //подумать над каунтом(как его задавать)

        Tanchik TankWhoShoot;

        public Bullet(double x, double y, Tanchik tank)
        {
            this.X = x;
            this.Y = y;
            this.TankWhoShoot = tank;

            //timer.Interval = 100;
            //timer.Elapsed += Fly;
            //timer.AutoReset = true;
            //timer.Enabled = true;
        }

        public void Tick(TimeSpan span)
        {
            this.X = (TankWhoShoot.gun.Forse * Math.Cos(TankWhoShoot.gun.Angle)) * span.Seconds/*что будет если изменить спан*/ + TankWhoShoot.X;
            this.Y = (TankWhoShoot.gun.Forse * Math.Sin(TankWhoShoot.gun.Angle)) * span.Seconds - g * span.Seconds * span.Seconds / 2 + TankWhoShoot.Y;
        }
        public void Check(Tanchik tank) //Нужен рабочий Мап
        {
            //if () ;
            //else ;
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