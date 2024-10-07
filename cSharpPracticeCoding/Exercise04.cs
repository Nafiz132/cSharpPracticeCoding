//1 - Write a program and ask the user to enter a number.
//The number should be between 1 to 10.
//If the user enters a valid number, display "Valid" on the console.
//Otherwise, display "Invalid".
//(This logic is used a lot in applications where values entered into input boxes need to be validated.)



//2- Write a program which takes two numbers from the console and displays the maximum of the two.



//3- Write a program and ask the user to enter the width and height of an image.
//Then tell if the image is landscape or portrait.



//4- Your job is to write a program for a speed camera.
//For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
//Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
//If the user enters a value less than the speed limit, program should display Ok on the console.
//If the value is above the speed limit, the program should calculate the number of demerit points.
//For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
//If the number of demerit points is above 12, the program should display License Suspended.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise
{
    class firstClass
    {
        public static void Exercise1()
        {

            Console.WriteLine("Enter a number : ");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Exercise2()
        {
            Console.Write("Enter the first number : ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            //var max = 0;
            //if (num1 > num2)
            //    max = num1;
            //else max = num2;
            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("The maximum number between {0} and {1} is {2}", num1, num2, max);
        }

        public static void Exercise3()
        {
            var height = Convert.ToInt32(Console.ReadLine());
            var width = Convert.ToInt32(Console.ReadLine());
            var ImageType = (height > width) ? ImageOrientation.landscape : ImageOrientation.portrait;
            Console.WriteLine("The type of Image is : " + ImageType);
        }
        public enum ImageOrientation
        {
            landscape,
            portrait
        }


        public static void Exercise4()
        {
            Console.Write("Enter the speed Limit : ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of the car : ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int demeritPerKm = 5;
                var demerit = (carSpeed - speedLimit) / demeritPerKm;
                if (demerit <= 12)
                {
                    Console.WriteLine("You have {0} demerit points", demerit);
                }
                else
                {
                    Console.WriteLine("Liscence Suspended");
                }
            }

        }
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
        }
    }
}
