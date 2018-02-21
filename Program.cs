using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1t3to10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* T3
            Console.WriteLine("Give first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Give second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Give third number:");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            double avg = sum / 3;
            Console.WriteLine("The sum of your numbers is " + sum);
            Console.WriteLine("The average of your numbers is " + avg); */

            /* T4
            Console.Write("How old are you? ");
            string line = Console.ReadLine();
            int age;
            bool result = Int32.TryParse(line, out age);
            if (result)
            {
                if (age < 18) Console.WriteLine("You are under-age.");
                else if (age >= 18 && age <= 65) Console.WriteLine("You are an adult.");
                else Console.WriteLine("You are a senior.");
            }
            else
            {
                Console.WriteLine("Are you sure that is your age?");
            } */


            /* T5
            Console.Write("Time in seconds: ");
            string line = Console.ReadLine();
            int seconds;
            bool result = Int32.TryParse(line, out seconds);
            if (result)
            {
                int hour = seconds / 3600;
                int minute = seconds / 60 - hour * 60;
                int second = seconds % 60;
                Console.WriteLine(seconds + " seconds is " + hour + " hours " + minute + " minutes and " + second + " seconds");
            }
            else
            {
                Console.WriteLine("That is not a valid number!");
            } */

            /* T6
            double dieselCon = 7.02;
            double price = 1.595;
            Console.Write("How far do you want to go? Give the amount of kilometers: ");
            string line = Console.ReadLine();
            double trip;
            bool result = Double.TryParse(line, out trip);
            if (result)
            {
                double diesel = trip / 100 * dieselCon;
                double cost = diesel * price;
                Console.WriteLine("The trip will take " + diesel + " liters of diesel.");
                Console.WriteLine("It will cost " + cost + " euros.");
            }
            else
            {
                Console.WriteLine("Stop dreaming, that is not a valid number.");
            } */


            /*  T7
            Console.Write("Give a year: ");
            string line = Console.ReadLine();
            int year;
            bool result = Int32.TryParse(line, out year);
            if (result)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine("Given year is a leap year.");
                }
                else
                {
                    Console.WriteLine("Given year is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Please check your input!");
            }

            */


            /* T8
            Console.WriteLine("Give first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Give second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Give third number:");
            double c = double.Parse(Console.ReadLine());

            double[] arrayNumbers = { a, b, c };
            double arrayNumbersBiggest = arrayNumbers.Max();
            Console.WriteLine("Biggest of the given numbers is " + arrayNumbersBiggest); */


            /* T9 
            int number;
            int sum = 0;
            bool result;
            do
            {
                Console.Write("Give a number (0 ends) : ");
                string line = Console.ReadLine();
                result = Int32.TryParse(line, out number);
                if (result)
                {
                    sum += number;
                }
            } while (result && number != 0);
            Console.WriteLine("Sum of given numbers is {0}.", sum); */


            /* T10:
            int[] array = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) Console.WriteLine("HEP!");
            }
            Console.ReadLine(); */

        }
    }
}
