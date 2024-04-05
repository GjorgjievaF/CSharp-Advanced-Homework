using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Domain.Model
{
    public abstract class Vehicle
    {
        public string Type { get; set; }
        public string Color { get; set; }

        public int Speed { get; set; }


        public Vehicle(string type, string color, int speed)
        {
            Type = type;
            Color = color;
            Speed = speed;
        }

        public abstract void Drive();
    }
}
