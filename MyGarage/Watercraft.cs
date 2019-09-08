using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Watercraft : Vehicle
    {
        public Watercraft()
        {
            FuelCapacity = 25;
            Color = Color.blue;
            PassengerOccupancy = 6;
        }

        public void Refueling()
        {
            base.Refueling();
        }

        public override void Driving()
        {
            Console.WriteLine("Driving the boat");
        }

    }

}
