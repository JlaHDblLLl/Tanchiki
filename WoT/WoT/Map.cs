using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WoT
{
    
    public static class Map
    {
        static public List<Tuple<double, double>> Points;
        static public bool IsHit(Bullet bullet, Tanchik tank)
        {
            return true;

        }
        static Map()
        {
            Points.Add(new Tuple<double, double>(0, 1));
            Points.Add(new Tuple<double, double>(1, 1));
            Points.Add(new Tuple<double, double>(3, 3));
            Points.Add(new Tuple<double, double>(5, 5));
            Points.Add(new Tuple<double, double>(7, 5));
            Points.Add(new Tuple<double, double>(9, 4));
            Points.Add(new Tuple<double, double>(11, 1));
            Points.Add(new Tuple<double, double>(13, 7));
            Points.Add(new Tuple<double, double>(15, 7));
            Points.Add(new Tuple<double, double>(17, 6));
        }
        static double Funk(double x, List<Tuple<double, double>> points)
        {
            Tuple<double, double> t1 = null;
            Tuple<double, double> t2 = null;
            for (int i = 0; i < 9; i++)
            {
                if (x >= points[i].Item1)
                {
                    t1 = points[i];
                    t2 = points[i + 1];
                    break;
                }
                else
                {
                    throw new Exception("Вышло за пределы");
                }
            }
            double y = ((x - t1.Item1) * (t2.Item2 - t1.Item1)) / (t2.Item1 - t1.Item1);
            return y;
        }
    }
   
}