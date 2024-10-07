//using static System.Runtime.InteropServices.JavaScript.JSType;

//1 - When you post a message on Facebook, depending on the number of people
//who like your post, Facebook displays different information.

//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays:
//[Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names,
//until the user presses Enter (without supplying a name). Depending on the number of names provided,
//display a message based on the above pattern.



//2- Write a program and ask the user to enter their name.
//Use an array to reverse the name and then store the result in a new string.
//Display the reversed name on the console.



//3- Write a program and ask the user to enter 5 numbers.
//If a number has been previously entered, display an error message and ask the user to re-try.
//Once the user successfully enters 5 unique numbers, sort them and display the result on the console.



//4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
//The list of numbers may include duplicates. Display the unique numbers that the user has entered.



//5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
//If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
//otherwise, display the 3 smallest numbers in the list.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise
{
    //internal class Exercise5
    //{
    //}
    class Program05
    {
        public static void Exercise01()
        {

            var names = new List<string>();
            while (true)
            {
                Console.Write("Enter name (or hit Enter to end) : ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                names.Add(input);
            }
            if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post", names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            }
            else if (names.Count > 2)
            {
                Console.WriteLine("{0},{1} and {2} others like your post", names[0], names[1], ((names.Count) - 2));
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public static void Exercise02()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            var reverseStore = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                reverseStore[name.Length - i] = name[i - 1];
            }
            var reversedName = new string(reverseStore);
            Console.WriteLine("The reversed name is : " + reversedName);
        }
        public static void Exercise03()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter a number to the list : ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("This number is already in the list. Try a different number.");
                    continue;
                }
                numbers.Add(number);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise04()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or Exit be typing 'quit' : ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }
            var uniqueList = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueList.Contains(number))
                {
                    uniqueList.Add(number);
                }
            }
            foreach (var unique in uniqueList)
            {
                Console.WriteLine(unique);
            }

        }
        static void Main(string[] args)
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            Exercise04();
        }
    }
}
