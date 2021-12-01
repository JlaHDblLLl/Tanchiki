using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoT
{
    class Tanchik
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Gun gun;
        public ICollection<Bullet> Bullets;
        public int HP { get; set; }

        public void Fire()
        {
            Bullet bullet = gun.Fire(this.X, this.Y);
        }
        public bool IsHit()
        {
            if (gun.Fire(this.X, this.Y).X - this.X <= 10 && gun.Fire(this.X, this.Y).Y - this.Y <= 10) return true;
            else return false;
        }
        public Tanchik(double x, double y, Gun gun)
        {
            this.Y = y;
            this.X = x;
            this.gun = gun;
        }

    }
}
