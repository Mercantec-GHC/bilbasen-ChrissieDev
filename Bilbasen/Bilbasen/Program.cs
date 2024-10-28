using DomainModels;
using System.Collections.Generic;

namespace Bilbasen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carInventory = new List<Car>
            {

                new Car("Ford", "Mustang", 1963, 123456, "Red", "Gasoline", 1500, "Coupe"),
                new Car("Toyota", "Camry", 2020, 34567, "Blue", "Hybrid", 1600, "Sedan"),
                new Car("Chevrolet", "Corvette", 2022, 1234, "Silver", "Gasoline", 1300, "Sport"),
                new Car("BMW", "3 Series", 2019, 76543, "Black", "Diesel", 1550, "Sedan"),
                new Car("Audi", "A4", 2018, 65432, "White", "Gasoline", 1500, "Sedan"),
                new Car("Mercedes-Benz", "C-Class", 2021, 34567, "Blue", "Hybrid", 1600, "Sedan"),
                new Car("Tesla", "Model S", 2022, 12345, "Red", "Electric", 2000, "Sedan"),
                new Car("Honda", "Civic", 2020, 45678, "Gray", "Gasoline", 1400, "Hatchback"),
                new Car("Mazda", "MX-5", 2019, 54321, "Yellow", "Gasoline", 1300, "Convertible"),
                new Car("Porsche", "911", 2022, 1234, "Green", "Gasoline", 1600, "Sport"),
                new Car("Nissan", "Altima", 2019, 67890, "Black", "Gasoline", 1500, "Sedan"),
                new Car("Volkswagen", "Golf", 2021, 12345, "White", "Diesel", 1400, "Hatchback"),
                new Car("Kia", "Sorento", 2020, 54321, "Blue", "Gasoline", 1600, "SUV"),
                new Car("Hyundai", "Tucson", 2021, 23456, "Gray", "Hybrid", 1500, "SUV"),
                new Car("Subaru", "Forester", 2020, 34567, "Silver", "Gasoline", 1600, "SUV"),
                new Car("Volvo", "XC90", 2022, 56789, "Black", "Diesel", 2000, "SUV"),
                new Car("Jaguar", "F-Pace", 2019, 67890, "Red", "Gasoline", 1700, "SUV"),
                new Car("Land Rover", "Range Rover", 2021, 45678, "Green", "Diesel", 2500, "SUV"),
                new Car("Peugeot", "308", 2020, 23456, "Blue", "Diesel", 1500, "Hatchback"),
                new Car("Renault", "Clio", 2019, 54321, "White", "Gasoline", 1300, "Hatchback"),
                new Car("Fiat", "500", 2021, 12345, "Yellow", "Gasoline", 1200, "Hatchback"),
                new Car("Mini", "Cooper", 2022, 67890, "Green", "Gasoline", 1400, "Hatchback"),
                new Car("Toyota", "Corolla", 2020, 34567, "Silver", "Hybrid", 1500, "Sedan"),
                new Car("Ford", "F-150", 2021, 45678, "Black", "Gasoline", 2500, "Pickup"),
                new Car("Chevrolet", "Silverado", 2019, 56789, "Blue", "Diesel", 2600, "Pickup"),
                new Car("Ram", "1500", 2020, 67890, "Gray", "Gasoline", 2400, "Pickup"),
                new Car("GMC", "Sierra", 2021, 23456, "Red", "Diesel", 2500, "Pickup"),
                new Car("Nissan", "Frontier", 2019, 34567, "Silver", "Gasoline", 2200, "Pickup"),
                new Car("Toyota", "Tacoma", 2021, 45678, "Black", "Gasoline", 2300, "Pickup"),
                new Car("Honda", "Ridgeline", 2022, 54321, "White", "Gasoline", 2400, "Pickup"),
                new Car("Ford", "Ranger", 2020, 56789, "Blue", "Diesel", 2100, "Pickup"),
                new Car("Chevrolet", "Colorado", 2019, 67890, "Gray", "Gasoline", 2200, "Pickup"),
                new Car("Jeep", "Wrangler", 2021, 23456, "Green", "Gasoline", 2000, "SUV"),
                new Car("Ford", "Explorer", 2020, 12345, "Blue", "Gasoline", 2400, "SUV"),
                new Car("Chevrolet", "Equinox", 2019, 34567, "Black", "Gasoline", 2300, "SUV"),
                new Car("Honda", "CR-V", 2021, 45678, "White", "Hybrid", 2100, "SUV"),
                new Car("Toyota", "RAV4", 2022, 54321, "Silver", "Hybrid", 2200, "SUV"),
                new Car("Nissan", "Rogue", 2020, 67890, "Gray", "Gasoline", 2000, "SUV"),
                new Car("Mazda", "CX-5", 2019, 23456, "Red", "Gasoline", 1900, "SUV"),
                new Car("Hyundai", "Santa Fe", 2021, 34567, "Blue", "Hybrid", 2100, "SUV"),
                new Car("Kia", "Sportage", 2020, 45678, "Green", "Gasoline", 2000, "SUV"),
                new Car("Subaru", "Outback", 2021, 54321, "White", "Gasoline", 2200, "SUV"),
                new Car("Volkswagen", "Tiguan", 2022, 67890, "Black", "Diesel", 2100, "SUV"),
                new Car("Audi", "Q5", 2020, 34567, "Silver", "Gasoline", 2300, "SUV"),
                new Car("BMW", "X3", 2021, 23456, "Gray", "Diesel", 2200, "SUV"),
                new Car("Mercedes-Benz", "GLC", 2020, 12345, "Blue", "Hybrid", 2400, "SUV"),
                new Car("Volvo", "XC60", 2021, 56789, "Black", "Diesel", 2500, "SUV"),
                new Car("Porsche", "Macan", 2022, 67890, "Red", "Gasoline", 2600, "SUV"),
                new Car("Jaguar", "E-Pace", 2020, 45678, "White", "Gasoline", 2200, "SUV"),
                new Car("Land Rover", "Discovery", 2019, 34567, "Green", "Diesel", 2700, "SUV"),
                new Car("Toyota", "Highlander", 2021, 12345, "Silver", "Hybrid", 2500, "SUV"),
                new Car("Honda", "Pilot", 2022, 54321, "Gray", "Gasoline", 2400, "SUV"),
                new Car("Ford", "Edge", 2020, 67890, "Blue", "Gasoline", 2300, "SUV"),
                new Car("Chevrolet", "Traverse", 2019, 23456, "Black", "Gasoline", 2200, "SUV"),
                new Car("Nissan", "Pathfinder", 2021, 34567, "Red", "Gasoline", 2100, "SUV"),
                new Car("Mazda", "CX-9", 2020, 45678, "White", "Gasoline", 2000, "SUV"),
                new Car("Hyundai", "Palisade", 2021, 12345, "Gray", "Hybrid", 2400, "SUV"),
                new Car("Kia", "Telluride", 2022, 54321, "Silver", "Gasoline", 2300, "SUV"),
                new Car("Subaru", "Ascent", 2020, 67890, "Blue", "Gasoline", 2200, "SUV"),
                new Car("Volkswagen", "Atlas", 2019, 23456, "Black", "Diesel", 2300, "SUV"),
                new Car("Audi", "Q7", 2021, 12345, "Blue", "Gasoline", 2500, "SUV"),
                new Car("BMW", "X5", 2022, 54321, "Silver", "Diesel", 2600, "SUV"),
                new Car("Mercedes-Benz", "GLE", 2020, 67890, "Black", "Hybrid", 2700, "SUV"),
                new Car("Volvo", "XC90", 2019, 23456, "Gray", "Diesel", 2800, "SUV"),
                new Car("Land Rover", "Defender", 2021, 34567, "Green", "Gasoline", 2900, "SUV"),
                new Car("Porsche", "Cayenne", 2022, 45678, "Red", "Gasoline", 3000, "SUV"),
                new Car("Lexus", "RX", 2020, 56789, "White", "Hybrid", 3100, "SUV"),
                new Car("Infiniti", "QX60", 2019, 67890, "Blue", "Gasoline", 3200, "SUV"),
                new Car("Acura", "MDX", 2021, 23456, "Silver", "Gasoline", 3300, "SUV"),
                new Car("Lincoln", "Navigator", 2022, 34567, "Black", "Gasoline", 3400, "SUV"),
                new Car("Cadillac", "Escalade", 2020, 45678, "Gray", "Diesel", 3500, "SUV"),
                new Car("GMC", "Yukon", 2019, 56789, "Red", "Gasoline", 3600, "SUV"),
                new Car("Chevrolet", "Tahoe", 2021, 67890, "Green", "Gasoline", 3700, "SUV"),
                new Car("Ford", "Expedition", 2022, 23456, "Blue", "Hybrid", 3800, "SUV"),
                new Car("Toyota", "Sequoia", 2020, 34567, "Silver", "Gasoline", 3900, "SUV"),
                new Car("Nissan", "Armada", 2021, 45678, "White", "Gasoline", 4000, "SUV"),
                new Car("Jeep", "Grand Cherokee", 2019, 56789, "Black", "Diesel", 4100, "SUV"),
                new Car("Dodge", "Durango", 2022, 67890, "Gray", "Gasoline", 4200, "SUV"),
                new Car("Subaru", "Crosstrek", 2020, 23456, "Red", "Gasoline", 4300, "SUV"),
                new Car("Hyundai", "Kona", 2021, 34567, "Blue", "Hybrid", 4400, "SUV"),
                new Car("Kia", "Niro", 2022, 45678, "Green", "Electric", 4500, "SUV"),
                new Car("Ford", "Bronco", 2021, 56789, "Yellow", "Gasoline", 4600, "SUV"),
                new Car("Chevrolet", "Blazer", 2020, 67890, "White", "Gasoline", 4700, "SUV"),
                new Car("Jeep", "Cherokee", 2019, 23456, "Black", "Diesel", 4800, "SUV"),
                new Car("GMC", "Acadia", 2022, 34567, "Silver", "Gasoline", 4900, "SUV"),
                new Car("Nissan", "Murano", 2021, 45678, "Red", "Gasoline", 5000, "SUV"),
                new Car("Toyota", "Venza", 2020, 56789, "Gray", "Hybrid", 5100, "SUV"),
                new Car("Honda", "HR-V", 2019, 67890, "Blue", "Gasoline", 5200, "SUV"),
                new Car("Mazda", "CX-3", 2021, 23456, "Silver", "Gasoline", 5300, "SUV"),
                new Car("Hyundai", "Venue", 2022, 34567, "White", "Gasoline", 5400, "SUV"),
                new Car("Kia", "Seltos", 2020, 45678, "Black", "Gasoline", 5500, "SUV"),
                new Car("Subaru", "Impreza", 2019, 56789, "Red", "Gasoline", 5600, "Hatchback"),
                new Car("Volkswagen", "Passat", 2021, 67890, "Gray", "Diesel", 5700, "Sedan"),
                new Car("Audi", "A6", 2022, 23456, "Blue", "Gasoline", 5800, "Sedan"),
                new Car("BMW", "5 Series", 2020, 34567, "Silver", "Diesel", 5900, "Sedan"),
                new Car("Mercedes-Benz", "E-Class", 2021, 45678, "Black", "Hybrid", 6000, "Sedan"),
                new Car("Volvo", "S90", 2022, 56789, "White", "Gasoline", 6100, "Sedan"),
                new Car("Jaguar", "XF", 2020, 67890, "Red", "Diesel", 6200, "Sedan"),
                new Car("Lexus", "ES", 2019, 23456, "Green", "Hybrid", 6300, "Sedan"),
                new Car("Tesla", "Model 3", 2021, 34567, "Blue", "Electric", 6400, "Sedan"),
                new Car("Nissan", "Maxima", 2022, 45678, "Silver", "Gasoline", 6500, "Sedan"),
                new Car("Chevrolet", "Malibu", 2020, 56789, "Black", "Gasoline", 6600, "Sedan"),
                new Car("Hyundai", "Sonata", 2019, 67890, "White", "Hybrid", 6700, "Sedan"),
                new Car("Kia", "Optima", 2021, 23456, "Gray", "Gasoline", 6800, "Sedan"),
                new Car("Mazda", "6", 2022, 34567, "Red", "Gasoline", 6900, "Sedan"),
                new Car("Honda", "Accord", 2020, 45678, "Blue", "Hybrid", 7000, "Sedan"),
                new Car("Toyota", "Avalon", 2021, 56789, "Green", "Gasoline", 7100, "Sedan"),
                new Car("Ford", "Fusion", 2022, 67890, "Silver", "Gasoline", 7200, "Sedan"),
                new Car("Subaru", "Legacy", 2020, 23456, "Black", "Gasoline", 7300, "Sedan"),
                new Car("Volkswagen", "Jetta", 2021, 34567, "White", "Diesel", 7400, "Sedan"),
                new Car("Audi", "A3", 2022, 45678, "Gray", "Gasoline", 7500, "Sedan"),
                new Car("BMW", "2 Series", 2019, 56789, "Red", "Diesel", 7600, "Coupe"),
                new Car("Mercedes-Benz", "CLA", 2020, 67890, "Blue", "Gasoline", 7700, "Coupe"),
                new Car("Porsche", "718 Cayman", 2021, 23456, "Silver", "Gasoline", 7800, "Coupe"),
                new Car("Chevrolet", "Camaro", 2022, 34567, "Black", "Gasoline", 7900, "Coupe"),
                new Car("Ford", "Mustang", 2020, 45678, "White", "Gasoline", 8000, "Coupe"),
                new Car("Dodge", "Challenger", 2021, 56789, "Gray", "Gasoline", 8100, "Coupe"),
                new Car("Nissan", "370Z", 2022, 67890, "Red", "Gasoline", 8200, "Coupe"),
                new Car("Mazda", "MX-5 Miata", 2020, 23456, "Blue", "Gasoline", 8300, "Convertible"),
                new Car("Fiat", "124 Spider", 2021, 34567, "Yellow", "Gasoline", 8400, "Convertible"),
                new Car("Chevrolet", "Corvette", 2022, 45678, "Black", "Gasoline", 8500, "Sport"),
                new Car("Porsche", "911", 2020, 34567, "Silver", "Gasoline", 8600, "Sport"),
                new Car("Lamborghini", "Huracan", 2021, 45678, "Green", "Gasoline", 8700, "Sport"),
                new Car("Ferrari", "488", 2022, 56789, "Red", "Gasoline", 8800, "Sport"),
                new Car("McLaren", "720S", 2020, 67890, "Orange", "Gasoline", 8900, "Sport"),
                new Car("Aston Martin", "DB11", 2021, 23456, "Blue", "Gasoline", 9000, "Sport"),
                new Car("Bentley", "Continental GT", 2022, 34567, "Silver", "Gasoline", 9100, "Sport"),
                new Car("Rolls-Royce", "Phantom", 2020, 45678, "Black", "Gasoline", 9200, "Luxury"),
                new Car("Bugatti", "Chiron", 2021, 56789, "Blue", "Gasoline", 9300, "Sport"),
                new Car("Pagani", "Huayra", 2022, 67890, "Red", "Gasoline", 9400, "Sport"),
                new Car("Koenigsegg", "Agera RS", 2020, 23456, "Silver", "Gasoline", 9500, "Sport"),
                new Car("Mercedes-Benz", "S-Class", 2021, 34567, "Black", "Hybrid", 9600, "Luxury"),
                new Car("BMW", "7 Series", 2022, 45678, "White", "Diesel", 9700, "Luxury"),
                new Car("Audi", "A8", 2020, 56789, "Gray", "Gasoline", 9800, "Luxury"),
                new Car("Lexus", "LS", 2021, 67890, "Blue", "Hybrid", 9900, "Luxury"),
                new Car("Genesis", "G90", 2022, 23456, "Silver", "Gasoline", 10000, "Luxury")
            };

            Console.WriteLine("Enter the attribute to filter by (Brand, Model, Year, Mileage, Color, FuelType, Weight, CarType):");
            string attribute = Console.ReadLine();

            Console.WriteLine("Enter the value to filter by:");
            string value = Console.ReadLine();

            foreach (var car in carInventory)
            {
                if (IsMatch(car, attribute, value))
                {
                    PrintCarDetails(car);
                }
            }
        }

        static bool IsMatch(Car car, string attribute, string value)
        {
            switch (attribute.ToLower())
            {
                case "brand":
                    return car.GetBrand().Equals(value, StringComparison.OrdinalIgnoreCase);
                case "model":
                    return car.GetModel().Equals(value, StringComparison.OrdinalIgnoreCase);
                case "year":
                    return car.GetYear().ToString().Equals(value, StringComparison.OrdinalIgnoreCase);
                case "mileage":
                    return car.GetMileage().ToString().Equals(value, StringComparison.OrdinalIgnoreCase);
                case "color":
                    return car.GetColor().Equals(value, StringComparison.OrdinalIgnoreCase);
                case "fueltype":
                    return car.GetFuelType().Equals(value, StringComparison.OrdinalIgnoreCase);
                case "weight":
                    return car.GetWeight().ToString().Equals(value, StringComparison.OrdinalIgnoreCase);
                case "cartype":
                    return car.GetCarType().Equals(value, StringComparison.OrdinalIgnoreCase);
                default:
                    return false;
            }
        }

        static void PrintCarDetails(Car car)
        {
            Console.WriteLine($"Brand: {car.GetBrand()}");
            Console.WriteLine($"Model: {car.GetModel()}");
            Console.WriteLine($"Year: {car.GetYear()}");
            Console.WriteLine($"Mileage: {car.GetMileage()}");
            Console.WriteLine($"Color: {car.GetColor()}");
            Console.WriteLine($"Fuel Type: {car.GetFuelType()}");
            Console.WriteLine($"Weight: {car.GetWeight()} kg");
            Console.WriteLine($"Car Type: {car.GetCarType()}");
            Console.WriteLine("---------------------------");
        }
    }
}