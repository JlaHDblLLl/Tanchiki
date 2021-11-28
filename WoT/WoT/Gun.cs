using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tanchiki_maket_
{


    

    class Gun
    {
        public double Angle { get; set; }
        public int Forse { get; set; }


        public bool IsOnTarget()
        {
            return true;           //полет снаряда по формуле 
        }

        public Gun(double angle, int forse)
        {
            Angle = angle;
            Forse = forse;
        }

    }
}
