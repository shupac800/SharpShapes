using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Rhombus
    {
        public static double area(double side1)
        {
            return Math.Pow(side1, 2);
        }
        public static double perimeter(double side1)
        {
            return 4 * side1;
        }
        public static void inputAndCompute()
        {
            Console.WriteLine("Enter side");
            var side = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Area is {0}", area(side));
            Console.WriteLine("Perimeter is {0}", perimeter(side));
        }
    }
}
