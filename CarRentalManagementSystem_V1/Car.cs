using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    public class Car
    {

        private int carId { get; set; }
        private string brand { get; set; }
        private string Model { get; set; }
        private decimal rentalPrice { get; set; }

        public Car(int carId, string brand, string model, decimal rentalPrice)
        {
            this.carId = carId;
            this.brand = brand;
            Model = model;
            this.rentalPrice = rentalPrice;
        }

        public override string ToString()
        {

            return $"ID: {carId}, Brand: {brand}, Model: {Model}, RentalPrice: {rentalPrice}";
        }


    }
}