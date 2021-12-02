using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoT
{
    public class Tanchik
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Gun gun;
        public ICollection<Bullet> Bullets;
        public int HP { get; set; }

        public void Fire()
        {
            gun.Fire(this.X, this.Y);
        }
        public bool IsHit(Tanchik tank_whoFire)
        {
            if (( tank_whoFire.gun.Fire(tank_whoFire.X, tank_whoFire.Y).X) - this.X <= 1 && (tank_whoFire.gun.Fire(tank_whoFire.X, tank_whoFire.Y).Y) - this.Y <= 1) return true;
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
