using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Aircraft : Vehicle
    {
        public Aircraft()
        {
            FuelCapacity = 250;
            Color = Color.white;
            PassengerOccupancy = 45;
        }

        public void Refueling()
        {
            base.Refueling();
        }

        public override void Driving()
        {
            Console.WriteLine("Flying the aircraft");
        }
        public void Braking()
        {
            Console.WriteLine("Landing the aircraft");
        }

    }

}
