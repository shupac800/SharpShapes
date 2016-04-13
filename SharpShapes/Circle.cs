using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Circle
    {
        public const double pi = 3.14159;
        public double area(double radius)
        {
            return Math.Pow(radius, 2) * pi;
        }
        public double diameter(double radius)
        {
            return 2 * pi * radius;
        }
    }
}
