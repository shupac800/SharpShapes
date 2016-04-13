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
            List<string> Shapes = new List<string> { "circle", "square", "rhombus", "cylinder", "cube" };
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
                    Circle.inputAndCompute();
                    break;
                case 1:
                    Square.inputAndCompute();
                    break;
                case 2:
                    Rhombus.inputAndCompute();
                    break;
                case 3:
                    Cylinder.inputAndCompute();
                    break;
                case 4:
                    Cube.inputAndCompute();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}
