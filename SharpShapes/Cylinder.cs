using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Cylinder
    {
        public const double pi = 3.14159;
        public double volume(double radius, double height)
        {
            return pi * Math.Pow(radius, 2) * height;
        }
        public double area(double radius, double height)
        {
            return (2 * pi * radius * height) + 2 * pi * Math.Pow(radius, 2);
        }
    }
}
