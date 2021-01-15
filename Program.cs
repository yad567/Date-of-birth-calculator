using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2021;
            Console.WriteLine("Enter your year of birth");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            if (yearOfBirth < 2021 && yearOfBirth > 1900)
            {
                int age = year - yearOfBirth;
                Console.WriteLine("Your age is " + age);
                
            } else
            {
                Console.WriteLine("Pleas enter your age It's not a joke");
            }
            Console.Read();
        }
    }
}
