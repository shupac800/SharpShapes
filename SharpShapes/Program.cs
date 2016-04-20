using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Shapes = new List<string> { "circle", "square", "rhombus", "cylinder", "cube", "sphere" };
            Console.WriteLine("\nGREETINGS PROFESSOR FALKEN\n");
            Console.WriteLine("Select a Shape:");
            int i = 1;
            foreach (string shape in Shapes)
            {
                Console.WriteLine("{0}. {1}", i++, shape);
            }
            int choice = Int32.Parse( Console.ReadLine() );
            string s = Shapes[--choice];
            Console.WriteLine("you chose " + s);
            switch(choice)
            {
                case 0:
                    // circle
                    Console.WriteLine("Enter radius");
                    var circle_radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0}", Circle.area(circle_radius));
                    Console.WriteLine("Circumference is {0}", Circle.circumference(circle_radius));
                    break;
                case 1:
                    // square
                    Console.WriteLine("Enter side");
                    var square_side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0}", Square.area(square_side));
                    Console.WriteLine("Perimeter is {0}", Square.perimeter(square_side));
                    break;
                case 2:
                    // rhombus
                    Console.WriteLine("Enter side");
                    var rhombus_side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0}", Rhombus.area(rhombus_side));
                    Console.WriteLine("Perimeter is {0}", Rhombus.perimeter(rhombus_side));
                    break;
                case 3:
                    // cylinder
                    Console.WriteLine("Enter radius, height");
                    string cyl_values = Console.ReadLine();
                    string[] cyl_arguments = cyl_values.Split(',');
                    double cyl_radius = double.Parse(cyl_arguments[0]);
                    double cyl_height = double.Parse(cyl_arguments[1]);
                    Console.WriteLine("Area is {0}", Cylinder.area(cyl_radius, cyl_height));
                    Console.WriteLine("Volume is {0}", Cylinder.volume(cyl_radius, cyl_height));
                    break;
                case 4:
                    // cube
                    Console.WriteLine("Enter side");
                    var cube_side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0}", Cube.area(cube_side));
                    Console.WriteLine("Volume is {0}", Cube.volume(cube_side));
                    break;
                case 5:
                    // sphere
                    Console.WriteLine("Enter radius");
                    var sphere_radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0}", Sphere.area(sphere_radius));
                    Console.WriteLine("Volume is {0}", Sphere.volume(sphere_radius));
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}
