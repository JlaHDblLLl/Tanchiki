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
        public int Forse { get; set; }


        public bool IsOnTarget()
        {
            return true;
        }

        public Gun(double angle, int forse)
        {
            Angle = angle;
            Forse = forse;
        }

    }
}
