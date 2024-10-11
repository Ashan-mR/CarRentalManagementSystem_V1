using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class PetrolCar:Car
    {
        public PetrolCar(string fuelTankCapacity, string engineCapacity)
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }

        private string FuelTankCapacity { get; set; }
        private string EngineCapacity { get; set; }

    }
}
