using ALXCSharpCourse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class ConditionalsDemo
    {
        public static void Run()
        {
            int number = 3;

            if (number > 15)
            {
                Console.WriteLine($"The {number} is greater than 15");
            }
            else if (number == 15)
            {
                Console.WriteLine($"The {number} is equal 15");
            }
            else if (number == 3)
            {
                Console.WriteLine("I am patato");
            }
            else
            {
                Console.WriteLine($"The {number} is smaller than 15");
            }
        }
        public static void RunNumberApp()
        {
            Console.WriteLine("Number app");
            Console.WriteLine("Enter a number: ");
            int x = 0;
            bool succeeded = Int32.TryParse(Console.ReadLine(), out x);
            //int x = Convert.ToInt32(Console.ReadLine());

            if (succeeded)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine($"The number {x} is even");
                }
                else
                {
                    Console.WriteLine($"The number {x} is odd");
                }
            }
            else
            {
                Console.WriteLine("The given input is not a number!");
            }

        }
        public static void RunSwitch()
        {
            var sex = Sex.FEMALE;
            switch (sex)
            {
                case Sex.MALE:
                    Console.WriteLine("The sex is male");
                    break;
                case Sex.FEMALE:
                    Console.WriteLine("The sex is female");
            
                    break;
                case Sex.CUSTOM:
                    Console.WriteLine("The sex is custom");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
                
            }
            Console.WriteLine("Switch end...");

            var number = 0;
            switch (number)
            {
                case 0:
                    Console.WriteLine("Hello");
                    break;
                case 1:
                    Console.WriteLine("Hi");

                    break;
                case 126:
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("default");
                    break;

            }
            Console.WriteLine("Switch end...");
        }

    }
}
