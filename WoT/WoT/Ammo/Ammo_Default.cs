using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WoT
{
    public class Ammo_Default : Ammo
    {
        public Ammo_Default() : base("Default") { }

        public override int GetDamage()
        {
            return base.GetDamage();
        }
    }
}