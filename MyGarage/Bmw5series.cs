using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Bmw5series : Car
    {
        public void DriftAndDrag()
        {
            Console.WriteLine($"Gallons of fuel = {base.FuelCapacity}");
            base.Driving();
            base.Braking();
            Console.WriteLine("drifting and dragging in style");
            Console.WriteLine($"Gallons of fuel now = {base.FuelCapacity - 2}");
        }
    }
}
