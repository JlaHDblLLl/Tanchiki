using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace WoT
{
    public class God
    {
        Bullet bullet { get; set; }
        Tanchik FirstTank = new Tanchik(10, 10, new Gun(0, 0));
        Tanchik SecondTank = new Tanchik(10, 100, new Gun(0, 0));

        Timer timer = new Timer();


    }
}