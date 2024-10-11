namespace CarRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (exit)
            {
                Console.Clear();
                Console.WriteLine("carManagementSystem");
                Console.WriteLine("1. Add a car");
                Console.WriteLine("2. View All cars");
                Console.WriteLine("3. Update a car");
                Console.WriteLine("4. Delete a car");
                Console.WriteLine("5. Exit");
                Console.Write("\nChoose an option: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter car brand: ");
                        string brand = _carRepository.Capitalizebrand(Console.ReadLine());
                        Console.Write("Enter car Model: ");
                        string Model = Console.ReadLine();

                        decimal RentrentalPrice = _carManager.ValidatecarRentrentalPrice();


                        _carRepository.Insert(brand, Model, RentrentalPrice);

                        break;
                    case "2":
                        Console.Clear();


                        _carRepository.GetAllData();

                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Enter car Id to Update: ");
                        int carId = int.Parse(Console.ReadLine());
                        Console.Write("Enter car brand: ");
                        string newbrand = _carRepository.Capitalizebrand(Console.ReadLine());
                        Console.Write("Enter car Model: ");
                        string newModel = Console.ReadLine();
                        decimal newRentrentalPrice = _carManager.ValidatecarRentrentalPrice();


                        _carRepository.Update(carId, newbrand, newModel, newRentrentalPrice);

                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Enter car Id to Update: ");
                        int deleteId = int.Parse(Console.ReadLine());

                        _carRepository.Delete(deleteId);

                        break;
                    case "5":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                Console.ReadLine();



            }
        }
    }
}