using Exercise02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Domain.Model
{
    public class Truck :Vehicle,ICarWash,IGusPump
    {
        public string PlateNumber { get; set; }

        public Truck(string type,string color,int speed,string platenumber) : base(type, color, speed)
        {
            PlateNumber = platenumber;
        }

        public override void Drive()
        {
            Console.WriteLine($"The truck form type {Type} with color {Color} is with speed {Speed} p/h and palte number {PlateNumber}");
        }

        public void WashCar()
        {
            Console.WriteLine("The car is washed.");
        }

        public void WashTrailer()
        {
            Console.WriteLine("The truck is washed.");
        }

        public void PumpGas()
        {
            Console.WriteLine($"Gas for the truck with platenumber {PlateNumber} is pumped.");
        }
    }
}
