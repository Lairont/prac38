using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class BMW : Avto, ITurbo, IEco
    {
        private int power;
        private double fuelConsumption;
        public int Power { get => power; set => power = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }

        public BMW(string dop, string model, int speed, int power, double fuelConsumption) : base(model, speed, dop)

        {
            Power = power;
            FuelConsumption = fuelConsumption;
        }

        public override void Drive()
        {
            Console.WriteLine($"{Model} разгоняется до {Speed} км/ч");
        }

        public void Turbo()
        {
            Power = (int)(Power * 1.2);  
            Speed = (int)(Speed * 1.1);
            Console.WriteLine();
            Console.WriteLine("Турбо включен");
            Console.WriteLine($"Мощность двигателя: {Power}");
            Console.WriteLine($"Максимальная скорость: {Speed} км/ч");
            Console.WriteLine();
        }

        public void Eco()
        {
            FuelConsumption = FuelConsumption * 0.80;
            Console.WriteLine("Экономичный режим включен");
            Console.WriteLine($"Расход топлива: {FuelConsumption} л/100 км");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Расход топлива: {FuelConsumption} л/100 км");
        }
    }
}
