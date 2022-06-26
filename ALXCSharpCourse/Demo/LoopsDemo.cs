using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class LoopsDemo
    {
        public static void Run()
        {
            int[] digitArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("For each...");
            var sum1 = 0;
            foreach (var digit in digitArray)
            {
                sum1 = sum1 + digit;
                Console.WriteLine($"Sum of digits: {sum1}");
            }
            Console.WriteLine();

            Console.WriteLine("For...");
            sum1 = 0;
           

            for(int i = 0 ; i < 4; i++)
            {
                sum1 = sum1 + digitArray[i];
                Console.WriteLine($"Sum of digits: {sum1}");
            }
            Console.WriteLine();

            

            for (int i = digitArray.Length-1; i >=0; i--)
            {
                sum1 = sum1 + digitArray[i];
                Console.WriteLine($"Sum of digits: {sum1}");
            }
            Console.WriteLine();

            Console.WriteLine("While...");
            sum1 = 0;
            var iterator = 0;

            while (sum1 + digitArray[iterator] < 20)
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Sum of digits: {sum1}");
                iterator++;
            }

            Console.WriteLine("Do While...");
            sum1 = 0;
            iterator = 0;

            do
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Sum of digits: {sum1}");
                iterator++;
            }

            while (sum1 + digitArray[iterator] < 20);
            

            Console.WriteLine();

        }
    }
}
