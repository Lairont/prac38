using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BMW : Avto, ITurbo, IEco
    {
        private int power;
        private double fuelConsumption;
        public int Power { get => power; set => power = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }

        public BMW(string dop, string model, int speed, int power, double fuelConsumption) : base(model, speed, dop )
           
        {
            Power = power;
            FuelConsumption = fuelConsumption;
        }

        public override void Drive()
        {
            Console.WriteLine("BMW едет!");
        }

        public void Turbo()
        {
            Console.WriteLine("BMW: Турбонаддув включен!");
        }

        public void Eco()
        {
            Console.WriteLine("BMW: Экономичный режим включен!");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Мощность двигателя: {Power} л.с.");
            Console.WriteLine($"Расход топлива: {FuelConsumption} л/100 км");
        }
    }
}
