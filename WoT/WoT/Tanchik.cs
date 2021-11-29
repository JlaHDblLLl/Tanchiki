using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoT
{
    class Tanchik
    {
        public Gun gun;
        public ICollection<Ammo> ammos;
        public int HP { get; set; }
    }
}
