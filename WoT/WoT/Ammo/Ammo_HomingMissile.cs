using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanchiki_maket_
{
    public class Ammo_HomingMissile : Ammo
    {
        private int TriggerRadius;

        public Ammo_HomingMissile() : base("HomingMissile") { }

        public override int GetDamage()
        {
            return base.GetDamage();
        }
    }
}