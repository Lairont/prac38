using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Vaz");
            Console.WriteLine("2. Maz");
            Console.WriteLine("3. BMW");
            Console.Write("Введите номер автомобиля: ");
            int choice = int.Parse(Console.ReadLine());
            Avto car = GetAvto(choice);

            if (car == null)
            {
                Console.WriteLine("Неверный выбор!");
                return;
            }
            Console.WriteLine("\nИнформация о выбранном автомобиле:");
            car.Show();
            car.Drive();

            if (car is ITurbo turboCar)
            {
                turboCar.Turbo();
            }

            if (car is IEco ecoCar)
            {
                ecoCar.Eco();
            }
            Console.ReadLine();
        }
        public static Avto GetAvto(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Введите дополнительную информацию: ");
                    string vazDop = Console.ReadLine();
                    Console.Write("Введите модель: ");
                    string vazModel = Console.ReadLine();
                    Console.Write("Введите скорость: ");
                    int vazSpeed = int.Parse(Console.ReadLine());
                    return new Vaz(vazModel, vazSpeed, vazDop);

                case 2:
                    Console.Write("Введите дополнительную информацию: ");
                    string mazDop = Console.ReadLine();
                    Console.Write("Введите модель: ");
                    string mazModel = Console.ReadLine();
                    Console.Write("Введите скорость: ");
                    int mazSpeed = int.Parse(Console.ReadLine());
                    return new Maz(mazModel, mazSpeed, mazDop);

                case 3:
                    Console.Write("Введите дополнительную информацию: ");
                    string bmwDop = Console.ReadLine();
                    Console.Write("Введите модель: ");
                    string bmwModel = Console.ReadLine();
                    Console.Write("Введите скорость: ");
                    int bmwSpeed = int.Parse(Console.ReadLine());
                    Console.Write("Введите мощность двигателя (л.с.): ");
                    int bmwPower = int.Parse(Console.ReadLine());
                    Console.Write("Введите расход топлива (л/100 км): ");
                    double bmwFuelConsumption = double.Parse(Console.ReadLine());
                    return new BMW(bmwDop, bmwModel, bmwSpeed, bmwPower, bmwFuelConsumption);

                default:
                    return null;
            }
        }
    }
}
