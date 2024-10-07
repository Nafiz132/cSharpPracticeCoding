using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeCoding
{
    class Vehicle
    {
        public string brand = "Volvo";
        public void honk()
        {
            Console.WriteLine("The sound is \"Tut\" \"Tut\"");
        }
    }
    class Car : Vehicle
    {
        public string ModelName="Mustang";
    }
    class Program03
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.honk();
            Console.WriteLine(car.brand+" "+car.ModelName);
        }
    }
}
