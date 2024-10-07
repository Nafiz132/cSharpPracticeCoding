using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

                           //***    Constructor    ***//

namespace PracticeExercise
{
    class Person
    {
        public string Name, gender;
        public int age;

        public Person(string name, string gender, int age)
        {
            Name = name;
            this.gender = gender;
            this.age = age;
        }
        public void showInformation()
        {
            Console.WriteLine("The name of the Person is : " + Name + ", the person is a " + gender + ", and age is :" + age);
        }
    }
    class Test()
    {
        static void Main(string[] args)
        {
            Person car1 = new Person("Nafiz", "Male", 24);
            Person car2 = new Person("Najmul", "Male", 27);
            Person car3 = new Person("Nasrin", "Female", 28);
            car1.showInformation();
            car2.showInformation();
            car3.showInformation();
        }
    }
}
