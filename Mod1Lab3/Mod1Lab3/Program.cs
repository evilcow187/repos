using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Lab3

{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaniating an object of the Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            //Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();

            //Output to the console window
            Console.WriteLine($"There are {carCount} cars on the inventory right now");

        }
    }

}