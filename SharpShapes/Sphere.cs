using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Sphere
    {
        public const double pi = 3.14159;
        public static double volume(double radius)
        {
            return (4 / 3) * pi * Math.Pow(radius, 3);
        }
        public static double area(double radius)
        {
            return 4 * pi * Math.Pow(radius, 2);
        }
    }
}
