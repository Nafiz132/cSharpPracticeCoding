using PracticeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise
{
    class Encapsulation
    {
        public string Name
        {  get; set; }
    }

    class Test01()
    {
        static void Main(string[] args)
        {
            Encapsulation myObj = new Encapsulation();
            myObj.Name = "Siam";
            Console.WriteLine("The name of that boy is {0}", myObj.Name);
        }
    }
}
