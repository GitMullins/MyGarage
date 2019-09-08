using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Car : Vehicle
    {
        public Car()
        {
            FuelCapacity = 18;
            Color = Color.red;
            PassengerOccupancy = 4;
        }

        public void Refueling()
        {
            base.Refueling();
        }

        public override void Driving()
        {
            Console.WriteLine("Driving the car");
        }
        public void Braking()
        {
            Console.WriteLine("Braking the car");
        }

    }

}
