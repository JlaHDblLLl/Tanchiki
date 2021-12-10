using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace WoT
{
    public class BulletController : ITick, IEnumerable<Bullet>
    {
        private ICollection<Bullet> Bullets;
        public BulletController(ICollection<Bullet> bullets)
        {
            Bullets = bullets;
        }

        public void Add(Bullet b)
        {
            Bullets.Add(b);
        }

        public IEnumerator<Bullet> GetEnumerator()
        {
            return Bullets.GetEnumerator();
        }

        public void Remove(Bullet bullet)
        {
            Bullets.Remove(bullet);
        }

        public void Tick(TimeSpan span)
        {
            foreach(var b in Bullets)
            {
                b.Tick(span);
            }
        }
        public void Check(Tanchik tank)
        {
            foreach(var b in Bullets)
            {
                b.Check(tank);
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Bullets).GetEnumerator();
        }
    }
}