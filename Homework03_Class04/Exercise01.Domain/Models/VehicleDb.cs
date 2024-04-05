using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public static class VehicleDb
    {
        public static List<Vehicle> Vehicles { get; set; }


        static VehicleDb()
        {
            Vehicles = new List<Vehicle>();
        }

     

        
    }


}
