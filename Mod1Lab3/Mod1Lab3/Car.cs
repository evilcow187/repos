using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Lab3
{
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
