using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    class Program
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
            Console.WriteLine("you chose {0}",  (string)Shapes[choice - 1]);
     
        }
    }
}
