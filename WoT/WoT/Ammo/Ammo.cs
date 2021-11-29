using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WoT
{
    abstract public class Ammo
    {
        public int Damage;
        public string Type { get; private set; }


        public virtual int GetDamage()
        {
            return 1;  //продумать реализацию
        }

        public Ammo(string type)
        {
            this.Type = type;
            Damage = GetDamage();
        }
    }
}