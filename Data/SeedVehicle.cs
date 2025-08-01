using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSE325_team.Models;

namespace CSE325_team.Data
{
    public class SeedVehicle
    {
        public static async Task InitializeAsync(ApplicationDbContext context)
        {

            if (await context.Vehicle.AnyAsync())
                return;

            var vehicles = new List<Vehicle>
{
    new Vehicle
    {
        Make = "Honda",
        Model = "Civic Si",
        Year = 2012,
        Color = "Black",
        VehicleType = "Coupe",
        Transmission = "Manual",
        DailyRate = 49.99m,
        Status = "Available",
        Capacity = 5,
        Mileage = 85000,
        FuelType = "Gasoline",
        ImageFileName = "coupe1.png"
    },
    new Vehicle
    {
        Make = "BMW",
        Model = "M4 Coupe",
        Year = 2023,
        Color = "White",
        VehicleType = "Coupe",
        Transmission = "Automatic",
        DailyRate = 159.99m,
        Status = "Available",
        Capacity = 4,
        Mileage = 15000,
        FuelType = "Gasoline",
        ImageFileName = "coupe2.png"
    },
    new Vehicle
    {
        Make = "Subaru",
        Model = "BRZ",
        Year = 2016,
        Color = "Red",
        VehicleType = "Coupe",
        Transmission = "Manual",
        DailyRate = 64.99m,
        Status = "Available",
        Capacity = 4,
        Mileage = 72000,
        FuelType = "Gasoline",
        ImageFileName = "coupe3.png"
    },
    new Vehicle
    {
        Make = "Nissan",
        Model = "370Z NISMO",
        Year = 2019,
        Color = "Silver",
        VehicleType = "Coupe",
        Transmission = "Manual",
        DailyRate = 79.99m,
        Status = "Available",
        Capacity = 2,
        Mileage = 52000,
        FuelType = "Gasoline",
        ImageFileName = "coupe4.png"
    },
new Vehicle
    {
        Make = "Audi",
        Model = "R8",
        Year = 2020,
        Color = "Black",
        VehicleType = "Coupe",
        Transmission = "Automatic",
        DailyRate = 239.99m,
        Status = "Available",
        Capacity = 2,
        Mileage = 22000,
        FuelType = "Gasoline",
        ImageFileName = "coupe5.png"
    },
    new Vehicle
    {
        Make = "Lamborghini",
        Model = "Huracan Spyder",
        Year = 2022,
        Color = "Green",
        VehicleType = "Convertible",
        Transmission = "Automatic",
        DailyRate = 459.99m,
        Status = "Available",
        Capacity = 2,
        Mileage = 8000,
        FuelType = "Gasoline",
        ImageFileName = "luxury1.png"
    },
    new Vehicle
    {
        Make = "McLaren",
        Model = "720S",
        Year = 2021,
        Color = "Blue",
        VehicleType = "Coupe",
        Transmission = "Automatic",
        DailyRate = 399.99m,
        Status = "Available",
        Capacity = 2,
        Mileage = 12000,
        FuelType = "Gasoline",
        ImageFileName = "luxury2.png"
    },
    new Vehicle
    {
        Make = "Porsche",
        Model = "911 GT3 RS",
        Year = 2018,
        Color = "Orange",
        VehicleType = "Coupe",
        Transmission = "Manual",
        DailyRate = 289.99m,
        Status = "Available",
        Capacity = 2,
        Mileage = 34000,
        FuelType = "Gasoline",
        ImageFileName = "luxury3.png"
    },
    new Vehicle
    {
        Make = "Lamborghini",
        Model = "Gallardo",
        Year = 2013,
        Color = "Blue",
        VehicleType = "Coupe",
        Transmission = "Automatic",
        DailyRate = 299.99m,
        Status = "Available",
        Capacity = 2,
        Mileage = 48000,
        FuelType = "Gasoline",
        ImageFileName = "luxury4.png"
    },

    new Vehicle
{
    Make = "Suzuki",
    Model = "GSX-R1000",
    Year = 2020,
    Color = "Blue/White",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 99.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 12000,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle1.png"
},
new Vehicle
{
    Make = "Harley-Davidson",
    Model = "Fat Boy",
    Year = 2012,
    Color = "Red/Chrome",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 109.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 26000,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle2.png"
},
new Vehicle
{
    Make = "Harley-Davidson",
    Model = "Softail Slim",
    Year = 2018,
    Color = "Black",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 119.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 18000,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle3.png"
},
new Vehicle
{
    Make = "Triumph",
    Model = "Bonneville Bobber",
    Year = 2021,
    Color = "Black/Orange",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 129.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 9500,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle4.png"
},
new Vehicle
{
    Make = "Yamaha",
    Model = "YZF-R1",
    Year = 2019,
    Color = "White/Black",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 109.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 14000,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle5.png"
},

new Vehicle
{
    Make = "Suzuki",
    Model = "GSX-R1000",
    Year = 2021,
    Color = "Blue/White",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 109.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 5500,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle1.png"
},
new Vehicle
{
    Make = "Harley-Davidson",
    Model = "Fat Boy",
    Year = 2016,
    Color = "Red/Chrome",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 119.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 8800,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle2.png"
},
new Vehicle
{
    Make = "Harley-Davidson",
    Model = "Fat Boy Special",
    Year = 2020,
    Color = "Matte Black",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 139.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 7200,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle3.png"
},
new Vehicle
{
    Make = "Triumph",
    Model = "Bobber",
    Year = 2022,
    Color = "Orange/Black",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 129.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 4300,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle4.png"
},
new Vehicle
{
    Make = "Yamaha",
    Model = "YZF-R1",
    Year = 2020,
    Color = "White/Black",
    VehicleType = "Motorcycle",
    Transmission = "Manual",
    DailyRate = 124.99m,
    Status = "Available",
    Capacity = 2,
    Mileage = 6300,
    FuelType = "Gasoline",
    ImageFileName = "motorcycle5.png"
},
new Vehicle
{
    Make = "Jeep",
    Model = "Wrangler Unlimited",
    Year = 2020,
    Color = "Blue",
    VehicleType = "SUV",
    Transmission = "Automatic",
    DailyRate = 119.99m,
    Status = "Available",
    Capacity = 5,
    Mileage = 35000,
    FuelType = "Gasoline",
    ImageFileName = "truck1.png"
},
new Vehicle
{
    Make = "Jeep",
    Model = "Wrangler Willys",
    Year = 2021,
    Color = "White",
    VehicleType = "SUV",
    Transmission = "Manual",
    DailyRate = 109.99m,
    Status = "Available",
    Capacity = 4,
    Mileage = 28000,
    FuelType = "Gasoline",
    ImageFileName = "truck2.png"
},
new Vehicle
{
    Make = "Chevrolet",
    Model = "Colorado Extended Cab",
    Year = 2019,
    Color = "Navy Blue",
    VehicleType = "Truck",
    Transmission = "Automatic",
    DailyRate = 89.99m,
    Status = "Available",
    Capacity = 4,
    Mileage = 40000,
    FuelType = "Gasoline",
    ImageFileName = "truck3.png"
},
new Vehicle
{
    Make = "Chevrolet",
    Model = "Colorado Crew Cab",
    Year = 2020,
    Color = "Red",
    VehicleType = "Truck",
    Transmission = "Automatic",
    DailyRate = 94.99m,
    Status = "Available",
    Capacity = 5,
    Mileage = 37000,
    FuelType = "Gasoline",
    ImageFileName = "truck4.png"
},
new Vehicle
{
    Make = "Chevrolet",
    Model = "Colorado Extended Cab",
    Year = 2018,
    Color = "Silver",
    VehicleType = "Truck",
    Transmission = "Automatic",
    DailyRate = 84.99m,
    Status = "Available",
    Capacity = 4,
    Mileage = 52000,
    FuelType = "Gasoline",
    ImageFileName = "truck5.png"
}



            };

            context.Vehicle.AddRange(vehicles);
await context.SaveChangesAsync();
        }

        }

    }