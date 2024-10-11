using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class PetrolCar:Car
    {
        public PetrolCar(string fuelTankCapacity, string engineCapacity) :base( carId, brand, Model, rentalPrice)
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }

        private string FuelTankCapacity { get; set; }
        private string EngineCapacity { get; set; }

        public override string DisplayPetrolCarInfo()
        {
            return base.DisplayPetrolCarInfo() + $"FuelTankCapacity:{FuelTankCapacity},EngineCapacity:{EngineCapacity}"
        }
    }
}
