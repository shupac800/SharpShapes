using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Rhombus
    {
        public double area(double side1)
        {
            return Math.Pow(side1, 2);
        }
        public double perimeter(double side1)
        {
            return 4 * side1;
        }
    }
}
