using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace WoT
{
    public class Game : ITick
    {
        readonly TimeSpan detT = new TimeSpan(0,0,1);
        TimeSpan WorldTime;
        Player Player1, Player2;

        BulletController Bullets;
        public void Run()
        {
            WorldTime = new TimeSpan(0, 0, 0);

            Tanchik Tank1 = new Tanchik(10, 10, new Gun(0, 0));
            Tanchik Tank2 = new Tanchik(10, 100, new Gun(0, 0));
            Player1 = new Player(Tank1);
            Player2 = new Player(Tank2);


        }

        public void Tick(TimeSpan span)
        {
            // modify model
            WorldTime += span;
            Player1.Tick(span);
            Player2.Tick(span);
            Bullets.Tick(span);

            // check conditions
            Check();
        }


        public void Check()
        {
            Player1.Tank.Check();
            Player2.Tank.Check();
            Bullets.Check(Player1.Tank);
            Bullets.Check(Player2.Tank);
        }

        protected bool Check(Bullet b, Tanchik t)
        {

        }


        public void OnTick(object sender, ElapsedEventArgs args)
        {
            WorldTime += detT;
        }
    }
}