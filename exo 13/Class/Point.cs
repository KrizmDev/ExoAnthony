using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_13.Class
{
    internal class Point
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void Deplacer(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public override string ToString()
        {
            return $" les coordonné du point sont {X}=x {Y}=y";
        }
    }
}
