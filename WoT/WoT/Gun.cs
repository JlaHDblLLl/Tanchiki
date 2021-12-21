using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WoT
{
    public class Gun
    {
        public double Angle { get; set; }
        public int Force { get; set; }


        public Gun(double angle, int forse)
        {
            Angle = angle;
            Force = forse;
        }

    }
}
