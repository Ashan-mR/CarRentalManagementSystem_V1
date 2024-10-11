using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class ElectricCar :Car
    {
        public ElectricCar(string batteryCapacity, string motorPower) : base(carId, brand, Model, rentalPrice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorPower;
        }

        private string BatteryCapacity { get; set; }
        private string MotorPower { get; set; }

        public override string DisplayPetrolCarInfo()
        {
            return base.DisplayPetrolCarInfo() + $"BatteryCapacity:{BatteryCapacity},MotorPower:{MotorPower}"
        }
    }
}
