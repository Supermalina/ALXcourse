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
                Console.WriteLine($"The {number} is equal than 15");
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
    }
}
