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
        public void Check(Map map)
        {
            int i = 0;
            while( i < Bullets.Count )
            {
                int temp = Bullets.Count;
                Bullets.ElementAt(i).Check(map, Bullets);

                i = temp == Bullets.Count ? i+1 : i;
            }
        }

        public void Check(Tanchik tank)
        {
            int i = 0;
            while (i < Bullets.Count)
            {
                int temp = Bullets.Count;
                Bullets.ElementAt(i).Check(tank, Bullets);
                i = temp == Bullets.Count ? i + 1 : i;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Bullets).GetEnumerator();
        }
    }
}