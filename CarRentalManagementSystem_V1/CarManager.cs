using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    public class CarManager: Car
    {
        private List<Car> cars = new List<Car>();
        

        public void CreateCar(string carID,string brand, string Model, decimal rentalPrice)
        {
            var car = new Car(carID, brand, Model, rentalPrice);
            cars.Add(car);
            Console.WriteLine("Car Added Successfully");
        }
        public void ReadCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No Cars Adeed");
            }
            foreach (var car in cars)
            {
                Console.WriteLine("List of Cars");
                Console.WriteLine(car);
            }
        }
        public void UpdateCars(string carId, string brand, string Model, decimal rentalPrice)
        {
            var car = cars.Find(c => c.carId == carId);

            if (car == null)
            {
                Console.WriteLine("Car Not found");
                return;
            }
            cars.Remove(car);
            CreateCar(brand, Model, rentalPrice);
            Console.WriteLine("Car updated succesfully");

        }
        public void DeleteCars(string carId)
        {
            var car = cars.Find(c => c.carId == carId);
            if (car == null)
            {
                Console.WriteLine("Car Not found");
                return;
            }
            cars.Remove(car);
            Console.WriteLine("Car deletedd succesfully");

        }

    }
}
