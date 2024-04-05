using Exercise02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Domain.Model
{
    public  class Car : Vehicle,ICarWash,IRepairService
    {
        public string Owner { get; set; }

        public Car(string type, string color,int speed,string owner) : base(type, color, speed)
        {
            Owner = owner;
        }

        public override void Drive()
        {
            Console.WriteLine($"The car form type {Type} with color {Color} is with speed {Speed} p/h");
        }

        public void WashCar()
        {
            Console.WriteLine("The car is washed.");
        }

        public void WashTrailer()
        {
            Console.WriteLine("The truck is washed.");
        }

        public void CheckVehicle()
        {
            Console.WriteLine("The vehicle is checked");
        }

        public void FixVehicle()
        {
            Console.WriteLine("The vehicle is fixed");
        }
    }
}
