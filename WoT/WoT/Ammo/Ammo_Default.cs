using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanchiki_maket_
{
    public class Ammo_Default : Ammo
    {
        public Ammo_Default() : base("HomingMissile") { }

        public override int GetDamage()
        {
            return base.GetDamage();
        }
    }
}