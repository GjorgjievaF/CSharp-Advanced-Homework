using Exercise02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Domain.Model
{
    public class CarCenter : ICarWash, IGusPump, IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("The vehicle is checked");
        }

        public void FixVehicle()
        {
            Console.WriteLine("The vehicle is fixed");
        }

        public void PumpGas()
        {
            Console.WriteLine("The gas is pumped.");
        }

        public void WashCar()
        {
            Console.WriteLine("The car is washed.");
        }

        public void WashTrailer()
        {
            Console.WriteLine("The truck is washed.");
        }
    }
}
