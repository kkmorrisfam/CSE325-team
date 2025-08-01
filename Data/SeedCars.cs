using CSE325_team.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSE325_team.Data
{
    public static class SeedCars
    {
        public static async Task InitializeAsync(ApplicationDbContext context)
        {
            if (await context.Vehicle.AnyAsync())
                return;

            var vehicles = new List<Vehicle>
            {
                new Vehicle { Make = "Mercedes-Benz", Model = "C250", Year = 2014, VehicleType = "Coupe", Transmission = "Automatic", Color = "white", DailyRate = 85, Status = "available", Capacity = 4, ImageFileName = "coupe1.png" },
                new Vehicle { Make = "Honda", Model = "Civic SI", Year = 2012, VehicleType = "Coupe", Transmission = "Manual", Color = "black", DailyRate = 85, Status = "available", Capacity = 4, ImageFileName = "coupe2.png" },
                new Vehicle { Make = "BMW", Model = "M4", Year = 2025, VehicleType = "Coupe", Transmission = "Automatic", Color = "grey", DailyRate = 85, Status = "available", Capacity = 4, ImageFileName = "coupe3.png" },
                new Vehicle { Make = "Subaru", Model = "BRZ", Year = 2013, VehicleType = "Coupe", Transmission = "Manual", Color = "red", DailyRate = 85, Status = "available", Capacity = 4, ImageFileName = "coupe4.png" },
                new Vehicle { Make = "Nissan", Model = "370z", Year = 2017, VehicleType = "Coupe", Transmission = "Manual", Color = "silver", DailyRate = 85, Status = "available", Capacity = 4, ImageFileName = "coupe5.png" },

                new Vehicle { Make = "Audi", Model = "R8", Year = 2020, VehicleType = "Luxury", Transmission = "Automatic", Color = "black", DailyRate = 130, Status = "available", Capacity = 4, ImageFileName = "luxury1.png" },
                new Vehicle { Make = "Lamborghini", Model = "Huracan", Year = 2019, VehicleType = "Luxury", Transmission = "Automatic", Color = "green", DailyRate = 130, Status = "available", Capacity = 4, ImageFileName = "luxury2.png" },
                new Vehicle { Make = "McLaren", Model = "720S", Year = 2021, VehicleType = "Luxury", Transmission = "Automatic", Color = "blue", DailyRate = 130, Status = "available", Capacity = 4, ImageFileName = "luxury3.png" },
                new Vehicle { Make = "Porsche", Model = "911", Year = 2016, VehicleType = "Luxury", Transmission = "Manual", Color = "orange", DailyRate = 130, Status = "available", Capacity = 4, ImageFileName = "luxury4.png" },
                new Vehicle { Make = "Lamborghini", Model = "Aventador", Year = 2020, VehicleType = "Luxury", Transmission = "Automatic", Color = "blue", DailyRate = 130, Status = "available", Capacity = 4, ImageFileName = "luxury5.png" },

                new Vehicle { Make = "Suzuki", Model = "GSX-R", Year = 2019, VehicleType = "Motorcycle", Transmission = "Manual", Color = "blue", DailyRate = 60, Status = "available", Capacity = 2, ImageFileName = "motorcycle1.png" },
                new Vehicle { Make = "Harley Davidson", Model = "Softail", Year = 2009, VehicleType = "Motorcycle", Transmission = "Manual", Color = "red", DailyRate = 60, Status = "available", Capacity = 2, ImageFileName = "motorcycle2.png" },
                new Vehicle { Make = "Harley Davidson", Model = "Fatboy", Year = 2016, VehicleType = "Motorcycle", Transmission = "Manual", Color = "black", DailyRate = 60, Status = "available", Capacity = 2, ImageFileName = "motorcycle3.png" },
                new Vehicle { Make = "Triumph", Model = "Bonneville Bobber", Year = 2022, VehicleType = "Motorcycle", Transmission = "Manual", Color = "black", DailyRate = 60, Status = "available", Capacity = 2, ImageFileName = "motorcycle4.png" },
                new Vehicle { Make = "Yamaha", Model = "YZF-R6", Year = 2012, VehicleType = "Motorcycle", Transmission = "Manual", Color = "white", DailyRate = 60, Status = "available", Capacity = 2, ImageFileName = "motorcycle5.png" },

                new Vehicle { Make = "BMW", Model = "3 Series", Year = 2013, VehicleType = "Sedan", Transmission = "Automatic", Color = "blue", DailyRate = 75, Status = "available", Capacity = 5, ImageFileName = "sedan1.png" },
                new Vehicle { Make = "Honda", Model = "Civic EX", Year = 2019, VehicleType = "Sedan", Transmission = "Automatic", Color = "white", DailyRate = 75, Status = "available", Capacity = 5, ImageFileName = "sedan2.png" },
                new Vehicle { Make = "Nissan", Model = "Sentra", Year = 2017, VehicleType = "Sedan", Transmission = "Automatic", Color = "grey", DailyRate = 75, Status = "available", Capacity = 5, ImageFileName = "sedan3.png" },
                new Vehicle { Make = "Toyota", Model = "Camry", Year = 2019, VehicleType = "Sedan", Transmission = "Automatic", Color = "purple", DailyRate = 75, Status = "available", Capacity = 5, ImageFileName = "sedan4.png" },
                new Vehicle { Make = "Volkswagen", Model = "Passat", Year = 2017, VehicleType = "Sedan", Transmission = "Automatic", Color = "blue", DailyRate = 75, Status = "available", Capacity = 5, ImageFileName = "sedan5.png" },

                new Vehicle { Make = "Jeep", Model = "Wrangler", Year = 2018, VehicleType = "Truck", Transmission = "Manual", Color = "blue", DailyRate = 100, Status = "available", Capacity = 5, ImageFileName = "truck1.png" },
                new Vehicle { Make = "Jeep", Model = "Wrangler", Year = 2019, VehicleType = "Truck", Transmission = "Manual", Color = "white", DailyRate = 100, Status = "available", Capacity = 5, ImageFileName = "truck2.png" },
                new Vehicle { Make = "Chevy", Model = "Colorado", Year = 2018, VehicleType = "Truck", Transmission = "Automatic", Color = "blue", DailyRate = 100, Status = "available", Capacity = 5, ImageFileName = "truck3.png" },
                new Vehicle { Make = "Chevy", Model = "Colorado", Year = 2019, VehicleType = "Truck", Transmission = "Automatic", Color = "red", DailyRate = 100, Status = "available", Capacity = 5, ImageFileName = "truck4.png" },
                new Vehicle { Make = "Chevy", Model = "Silverado", Year = 2020, VehicleType = "Truck", Transmission = "Automatic", Color = "silver", DailyRate = 100, Status = "available", Capacity = 5, ImageFileName = "truck5.png" }
            };

            context.Vehicle.AddRange(vehicles);
            await context.SaveChangesAsync();
        }
    }
}
