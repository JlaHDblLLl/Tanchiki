﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace WoT
{
    public class Game : ITick
    {
        readonly TimeSpan detT = new TimeSpan(0,0,0,0,1);
        TimeSpan WorldTime;
        Player Player1, Player2;
        Map map = new Map();
        Timer timer = new Timer();
        BulletController Bullets = new BulletController(new List<Bullet>());
        public void Run()
        {
            WorldTime = new TimeSpan(0, 0, 0);

            Tanchik Tank1 = new Tanchik(4, 5, new Gun(1, 1), Bullets);
            Tanchik Tank2 = new Tanchik(14, 7, new Gun(2.5, 1), Bullets);
            Player1 = new Player(Tank1);
            Player2 = new Player(Tank2);
            Player1.Fire();
            Player2.Fire();
            for (int i = 0; i < 1000; i++)
            {
                Tick(detT);
            }

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
            Bullets.Check(map);
            Bullets.Check(Player1.Tank);
            Bullets.Check(Player2.Tank);

        }

        public void OnTick(object sender, ElapsedEventArgs args)
        {
            Tick(detT);
        }
        public Game()
        {
            //timer.Interval = 100;
            //timer.Elapsed += OnTick;
            //timer.Enabled = true;
            //this.Run();
        }

    }
}