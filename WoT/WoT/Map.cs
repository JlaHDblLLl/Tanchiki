using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace WoT
{
    
    public class Map
    {
        public List<Point> Points;
        public bool IsHit(Bullet bullet, Tanchik tank)
        {
            return true;

        }
        public Map()
        {
            Points.Add(new Point(0,1));
            Points.Add(new Point(1, 1));
            Points.Add(new Point(3, 3));
            Points.Add(new Point(5, 5));
            Points.Add(new Point(7, 5));
            Points.Add(new Point(9, 4));
            Points.Add(new Point(11, 1));
            Points.Add(new Point(13, 7));
            Points.Add(new Point(15, 7));
            Points.Add(new Point(17, 6));
        }
        public double Funk(double x, List<Point> points)
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