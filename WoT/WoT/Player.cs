using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WoT
{
    public class Player : ITick
    {
        public Tanchik Tank;
        public Player(Tanchik tank)
        {
            this.Tank = tank;
        }
        public void Fire()
        {
            Tank.Fire(Tank.X, Tank.Y);
        }

        public void Tick(TimeSpan span)
        {
            Tank.Tick(span);
        }
    }
}