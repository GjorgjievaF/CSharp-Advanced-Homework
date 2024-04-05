using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Domain.Interfaces
{
    public interface IRepairService
    {
        public void CheckVehicle();

        public void FixVehicle();
    }
}
