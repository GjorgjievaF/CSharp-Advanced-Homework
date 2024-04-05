using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public static class Validator
    {

        public static bool Validate(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;
            if (vehicle.Id == 0)
                return false;
            if (vehicle.Type == string.Empty)
                return false;
            if (vehicle.YearOfProduction == 0)
                return false;
            return true;

            


        }
    }
}
