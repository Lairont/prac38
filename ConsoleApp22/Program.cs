using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Avto> avto = new List<Avto>();

            avto.Add(new BMW("Черный", "M5", 250, 600, 12.9));

            while (true)
            {
                Console.WriteLine("1. Добавить Maz");
                Console.WriteLine("2. Добавить Vaz");
                Console.WriteLine("3. Показать все автомобили");
                Console.WriteLine("4. Выйти");

                int choice = Console.ReadKey(true).KeyChar - 48;

                switch (choice)
                {
                    case 1:
                        Console.Write("Модель: ");
                        string mazModel = Console.ReadLine();
                        Console.Write("Скорость: ");
                        int mazSpeed = int.Parse(Console.ReadLine());
                        Console.Write("Дополнительное: ");
                        string mazDop = Console.ReadLine();
                        avto.Add(new Maz(mazModel, mazSpeed, mazDop));
                        break;

                    case 2:
                        Console.Write("Модель: ");
                        string vazModel = Console.ReadLine();
                        Console.Write("Скорость: ");
                        int vazSpeed = int.Parse(Console.ReadLine());
                        Console.Write("Дополнительное: ");
                        string vazDop = Console.ReadLine();
                        avto.Add(new Vaz(vazModel, vazSpeed, vazDop));

                        break;

                    case 3:
                        Console.WriteLine("\nСписок автомобилей:");
                        foreach (Avto car in avto)
                        {
                            GetAvto(car);

                            if (car is ITurbo turbo)
                                turbo.Turbo();

                            if (car is IEco eco)
                                eco.Eco();

                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine(".");
                        break;
                }
            }
        }

        static void GetAvto(Avto car)
        {
            car.Show();
            car.Drive();
        }
    }
}
