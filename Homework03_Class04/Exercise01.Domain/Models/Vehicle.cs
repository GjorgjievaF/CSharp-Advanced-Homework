using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }


        public Vehicle() { 
            Id = new Random().Next(1,10000);
        
        }

        public Vehicle(int id, string type, int yearOfProduction, int batchNumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"The id for the vehicle is : {Id},the type is {Type} and it is produced {YearOfProduction}");
        }
    }
}
