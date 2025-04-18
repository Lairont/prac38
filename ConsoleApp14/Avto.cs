using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    abstract class Avto
    {
        private string model;
        private int speed;
        private string dop;

        public string Model { get => model; set => model = value; }
        public int Speed { get => speed; set => speed = value; }
        public string Dop { get => dop; set => dop = value; }
        public Avto(string model, int speed, string dop)
        {
            this.Model = model;
            this.Speed = speed;
            this.Dop = dop;
        }
        public abstract void Drive();
        public virtual void Show()
        {
            Console.WriteLine($"Можель: {Model}\nСкорость: {Speed}\nДоп: {Dop}");
        }
        
    }
}

    

