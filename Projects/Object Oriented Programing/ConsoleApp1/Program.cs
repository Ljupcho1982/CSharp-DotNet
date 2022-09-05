using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.Drive();
            Car.Drive();
            Car.Stop();
           

        }

        public static class Car
        {
            static int speed;
            static string color;
            static float price;

            public static void Start()
            {

                Console.WriteLine("CarStarted");
            }

            public static void Drive()
            {

                Console.WriteLine("Car is driving");
            }

            public static void Stop()
            {

                Console.WriteLine("Car stoped");
            }
        }
    }
}
