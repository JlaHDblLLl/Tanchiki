using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace WoT
{
    
    public class Map
    {
        private List<Point> Points = new List<Point>();

        public Map()
        {
            Points.Add(new Point(0,1));
            Points.Add(new Point(1, 1));
            Points.Add(new Point(3, 3));
            Points.Add(new Point(5, 4));
            Points.Add(new Point(7, 6));
            Points.Add(new Point(9, 4));
            Points.Add(new Point(11, 1));
            Points.Add(new Point(13, 7));
            Points.Add(new Point(15, 7));
            Points.Add(new Point(17, 6));
        }
        public double Funk(double x)
        {
            Point t1 = new Point();
            Point t2 = new Point();
            for (int i = 0; i < 9; i++)
            {
                if (x >= Points[i].X)
                {
                    t1 = Points[i];
                    t2 = Points[i + 1];
                    break;
                }
            }
            double y = ((x - t1.X) * (t2.Y - t1.Y)) / (t2.X - t1.X) + t1.Y;
            return y;
        }
        public void Check()
        {

        }
    }
   
}