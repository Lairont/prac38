using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Disk : IShape
    {
        private double radius;
        public double Radius { get => radius; set => radius = value; }
        public Disk(double radius)
        {
            this.Radius = radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
