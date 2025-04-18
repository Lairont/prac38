using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Disk(25.2)); 
            shapes.Add(new Triangle(15, 15, 20));
            foreach (var sh in shapes)
            {
                Console.WriteLine($"Периметр: {sh.Perimeter():F2}");
                Console.WriteLine($"Площадь: {sh.Area():F2}");
                Console.WriteLine();
            }
            Console.Read();
         }
    }    
}
