using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Car car = new Car();
            List<Car> myList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputCars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputCars[0];
                double fuelAmount = double.Parse(inputCars[1]);
                double fuelPerKm = double.Parse(inputCars[2]);

                Car currentCar = new Car(model, fuelAmount, fuelPerKm);
                myList.Add(currentCar);
               
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split();
                string curentModel = cmdArg[1];
                double distanceTraveled = double.Parse(cmdArg[2]);

                Car current = myList.FirstOrDefault(c => c.Model == curentModel);

                bool IsDrive = current.Drive(distanceTraveled);

                if(!IsDrive)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            foreach (var car in myList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

        }
    }
}
