using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Vaz : Avto, IEco
    {
        public Vaz(string model, int speed, string dop)
            : base(model, speed, dop) { }

        public override void Drive()
        {
            Console.WriteLine($"{Model} движется экономно со скоростью {Speed} км/ч.");
        }

        public void Eco()
        {
            Console.WriteLine("Экономичный режим включен");
        }

    }
}
