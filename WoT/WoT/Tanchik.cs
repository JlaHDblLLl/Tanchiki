using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoT
{
    public class Tanchik : ITick
    {
        const double K = 3;
        private BulletController Bullets;
        public double X { get; set; }
        public double Y { get; set; } 
        public Gun gun;
        public int HP { get; set; }
        public void Check()//проверка для езды
        {
            
        }
        public void Fire(double x, double y)
        {
            Bullet bullet = new Bullet(x, y, this);
            Bullets.Add(bullet);
            
        }
        public Tanchik(double x, double y, Gun gun, BulletController bullets)
        {
            this.Y = y;
            this.X = x;
            this.gun = gun;
            this.Bullets = bullets;
        }
        public void Tick(TimeSpan span)
        {
            X += span.Seconds * K;
        }
    }
}
