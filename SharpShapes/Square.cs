using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Square
    {
        public double area(double side)
        {
            return Math.Pow(side, 2);
        }
        public double perimeter(double side)
        {
            return 4 * side;
        }
    }
}
