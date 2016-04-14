using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Cube
    {
        public static double volume(double side)
        {
            return Math.Pow(side, 3);
        }
        public static double area(double side)
        {
            return 6 * Math.Pow(side, 2);
        }
    }
}
