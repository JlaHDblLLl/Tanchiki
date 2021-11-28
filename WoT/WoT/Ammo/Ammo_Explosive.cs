using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanchiki_maket_
{
    class Ammo_Explosive : Ammo
    {
        private int ExplosionRadius;

        public Ammo_Explosive() : base("Explosive") { }

        public override int GetDamage()
        {
            return base.GetDamage();
        }
    }
}
