using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
      
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
            
        }

        public string Model { get; set; }
        public double FuelAmount  { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTravelled)
        {
            double fuelNeeded = distanceTravelled * FuelConsumptionPerKilometer;

            if(fuelNeeded > FuelAmount)
            {
                return false;
            }
            else
            {
                TravelledDistance += distanceTravelled;
                FuelAmount -= fuelNeeded;
                return true;
            }
        }
    }
}
