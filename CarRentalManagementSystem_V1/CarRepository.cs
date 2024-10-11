using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{

    private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CarRentalManagement;Trusted_Connection=true;TrustServerCertificate=true;";

    public void Insert(string carID, string brand, string Model, decimal rentalPrice)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Courses(ID,Brand,Model,RentalPrice) VALUES(@carId,@brand,@Model,@rentalPrice)";
            command.Parameters.AddWithValue("@carId", carId);
            command.Parameters.AddWithValue("@brand", brand);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@rentalPrice", rentalPrice);
            command.ExecuteNonQuery();
        }

        Console.WriteLine("\nCar Added Successfully.");
    }

    public void GetAllData()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Cars";
            using (var reader = command.ExecuteReader())
            {
                Console.WriteLine("-- Cars List --\n");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader.GetInt32(0)}, Brand: {reader.GetString(1)}, Model: {reader.GetString(2)}, RentalPrice: {reader.GetDecimal(3)}");
                }
            }
        }
    }

}
}
