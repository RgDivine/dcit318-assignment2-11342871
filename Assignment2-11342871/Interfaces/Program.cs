using System;

namespace Assignment2
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBike = new Bicycle();

            myCar.Move();    // Outputs: Car is moving
            myBike.Move();   // Outputs: Bicycle is moving
        }
    }
}
