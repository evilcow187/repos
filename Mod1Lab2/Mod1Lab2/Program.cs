using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Lab2
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

            var Car2 = new Car("Red",2008);

            int carCount = Car.CountCars();

            //Output to the console window
            Console.WriteLine($"There are {carCount} cars on he inventory right now");

        }
    }

    //Declaring The Car() Class
    //This class has 3 properies: Color, Year, and Mileage
    public class Car
    {
        //Defining properies
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //Adding a Constructor
        //This consructor instatiates a Car() object while only having he car's color and year information available
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            //Every ime the consructor runs, incriment "instances"
            instances++;
        }

        //Adding another Constructor
        //This constructor instantiates a Car() object while only having he car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;

            //Every ime the consructor runs, incriment "instances"
            instances++;
        }

        //Creates integer variable called "instances" and assignes value to 0
        private static int instances = 0;

        public Car()
        {
            //Every time the consructor runs, increment "instances"
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}
