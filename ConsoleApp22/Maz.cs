using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Maz : Avto, ITurbo
    {
        public Maz(string model, int speed, string dop)
            : base(model, speed, dop)
        { 

        }

        public override void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
        }

        public void Turbo()
        {
            Console.WriteLine("Турбо включен");
        }

    }
}
