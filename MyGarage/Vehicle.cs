using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    abstract class Vehicle
    {
        public int FuelCapacity { get; set; }
        public CarColor CarColor { get; set; }
        public int PassengerOccupancy { get; set; }

        public void Refueling()
        {
            Console.WriteLine("Refueling");
        }

        public abstract void Driving();

    }

    enum CarColor
    {
        red,
        black,
        blue,
        white,
        orange,
    }

}
