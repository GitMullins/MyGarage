using System;
using System.Collections.Generic;

namespace MyGarage
{
    class Program
    {
        public static void Main()
        {
            var cars = new Bmw5series();
            cars.DriftAndDrag();
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
