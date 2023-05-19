using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();

            var truck = new Car();
            truck.Year = 1999;
            truck.Make = "Ford";
            truck.Model = "F150";
            truck.EngineNoise = "Rubmle Rumble, Vroom Vroom!";
            truck.HonkNoise = "Honk Honk!";
            truck.IsDriveable = true;

            truck.MakeEngineNoise();
            truck.MakeHonkNoise();
            carLot.Cars.Add(truck);

            Console.WriteLine("-------------------------");

            var convertible = new Car()
            {
                Year = 2011,
                Make = "Chevrolet",
                Model = "Corvette",
                EngineNoise = "Vroooom-vroooom, purrrrrrrrrr!",
                HonkNoise = "Beep-beep-beeeeeeeeep!",
                IsDriveable = true
            };

            convertible.MakeEngineNoise();
            convertible.MakeHonkNoise();
            carLot.Cars.Add(convertible);

            Console.WriteLine("-------------------------");

            var suv = new Car(2022, "Subaru", "Outback", "Vroom-vroom-vroom, hummmmmm!", "Meep-meep-beep!", true);

            suv.MakeEngineNoise();
            suv.MakeHonkNoise();
            carLot.Cars.Add(suv);

            Console.WriteLine("-------------------------");

            Console.WriteLine("We have the following cars on the lot:");
            foreach (Car car in carLot.Cars)
            {
                Console.WriteLine($"A {car.Year} {car.Make} {car.Model}");
            }
        }
    }
}
