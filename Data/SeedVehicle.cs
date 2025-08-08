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
        Make = "BMW",
        Model = "3 Series",
        Year = 2013,
        Color = "blue",
        VehicleType = "Sedan",
        Transmission = "Automatic",
        DailyRate = 75.99m,
        Status = "available",
        Seats = 5,
        Mileage = 62000,
        ImageFileName = "sedan1.png"
    },
    new Vehicle
    {
        Make = "Honda",
        Model = "Civic EX",
        Year = 2019,
        Color = "white",
        VehicleType = "Sedan",
        Transmission = "Automatic",
        DailyRate = 56.99m,
        Status = "available",
        Seats = 5,
        Mileage = 31000,
        ImageFileName = "sedan2.png"
    },
    new Vehicle
    {
        Make = "Nissan",
        Model = "Sentra",
        Year = 2017,
        Color = "grey",
        VehicleType = "Sedan",
        Transmission = "Automatic",
        DailyRate = 72.99m,
        Status = "available",
        Seats = 5,
        Mileage = 62000,
        ImageFileName = "sedan3.png"
    },
    new Vehicle
    {
        Make = "Toyota",
        Model = "Camry",
        Year = 2019,
        Color = "purple",
        VehicleType = "Sedan",
        Transmission = "Automatic",
        DailyRate = 46.99m,
        Status = "available",
        Seats = 5,
        Mileage = 38000,
        ImageFileName = "sedan4.png"
    },
    new Vehicle
    {
        Make = "Volkswagen",
        Model = "Passat",
        Year = 2017,
        Color = "blue",
        VehicleType = "Sedan",
        Transmission = "Automatic",
        DailyRate = 57.99m,
        Status = "available",
        Seats = 5,
        Mileage = 43000,
        ImageFileName = "sedan5.png"
    },
    new Vehicle
    {
        Make = "Mercedes-Benz",
        Model = "C250",
        Year = 2014,
        Color = "White",
        VehicleType = "Coupe",
        Transmission = "Automatic",
        DailyRate = 47.99m,
        Status = "available",
        Seats = 5,
        Mileage = 55000,        
        ImageFileName = "coupe1.png"
    },
    new Vehicle
    {
        Make = "Honda",
        Model = "Civic Si",
        Year = 2012,
        Color = "Black",
        VehicleType = "Coupe",
        Transmission = "Manual",
        DailyRate = 79.99m,
        Status = "available",
        Seats = 5,
        Mileage = 25000,        
        ImageFileName = "coupe2.png"
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
        Status = "available",
        Seats = 4,
        Mileage = 5000,        
        ImageFileName = "coupe3.png"
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
        Status = "available",
        Seats = 4,
        Mileage = 72000,        
        ImageFileName = "coupe4.png"
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
        Status = "available",
        Seats = 2,
        Mileage = 52000,        
        ImageFileName = "coupe5.png"
    },
    new Vehicle
    {
        Make = "Audi",
        Model = "R8",
        Year = 2020,
        Color = "Black",
        VehicleType = "Luxury",
        Transmission = "Automatic",
        DailyRate = 239.99m,
        Status = "available",
        Seats = 2,
        Mileage = 22000,        
        ImageFileName = "luxury1.png"
    },
    new Vehicle
    {
        Make = "Lamborghini",
        Model = "Huracan Spyder",
        Year = 2022,
        Color = "Green",
        VehicleType = "Luxury",
        Transmission = "Automatic",
        DailyRate = 459.99m,
        Status = "available",
        Seats = 2,
        Mileage = 8000,        
        ImageFileName = "luxury2.png"
    },
    new Vehicle
    {
        Make = "McLaren",
        Model = "720S",
        Year = 2021,
        Color = "Blue",
        VehicleType = "Luxury",
        Transmission = "Automatic",
        DailyRate = 399.99m,
        Status = "available",
        Seats = 2,
        Mileage = 12000,        
        ImageFileName = "luxury3.png"
    },
    new Vehicle
    {
        Make = "Porsche",
        Model = "911 GT3 RS",
        Year = 2018,
        Color = "Orange",
        VehicleType = "Luxury",
        Transmission = "Manual",
        DailyRate = 289.99m,
        Status = "available",
        Seats = 2,
        Mileage = 34000,        
        ImageFileName = "luxury4.png"
    },
    new Vehicle
    {
        Make = "Lamborghini",
        Model = "Gallardo",
        Year = 2013,
        Color = "Blue",
        VehicleType = "Luxury",
        Transmission = "Automatic",
        DailyRate = 299.99m,
        Status = "available",
        Seats = 2,
        Mileage = 48000,        
        ImageFileName = "luxury5.png"
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
        Status = "available",
        Seats = 2,
        Mileage = 12000,        
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
        Status = "available",
        Seats = 2,
        Mileage = 26000,        
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
        Status = "available",
        Seats = 2,
        Mileage = 18000,        
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
        Status = "available",
        Seats = 2,
        Mileage = 9500,        
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
        Status = "available",
        Seats = 2,
        Mileage = 14000,        
        ImageFileName = "motorcycle5.png"
    },

    new Vehicle
    {
        Make = "Jeep",
        Model = "Wrangler Unlimited",
        Year = 2020,
        Color = "Blue",
        VehicleType = "Truck",
        Transmission = "Automatic",
        DailyRate = 119.99m,
        Status = "available",
        Seats = 5,
        Mileage = 35000,        
        ImageFileName = "truck1.png"
    },
    new Vehicle
    {
        Make = "Jeep",
        Model = "Wrangler Willys",
        Year = 2021,
        Color = "White",
        VehicleType = "Truck",
        Transmission = "Manual",
        DailyRate = 109.99m,
        Status = "available",
        Seats = 4,
        Mileage = 28000,        
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
        Status = "available",
        Seats = 4,
        Mileage = 40000,        
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
        Status = "available",
        Seats = 5,
        Mileage = 37000,        
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
        Status = "available",
        Seats = 4,
        Mileage = 52000,        
        ImageFileName = "truck5.png"
    }



            };

            context.Vehicle.AddRange(vehicles);
            await context.SaveChangesAsync();
        }

        }

    }