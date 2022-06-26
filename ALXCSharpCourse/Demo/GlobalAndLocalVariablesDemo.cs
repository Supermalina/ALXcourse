﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class GlobalAndLocalVariablesDemo
    {
        int x = 12;
        public static void Run()
        {
            int x = 5;
            MultiplyNumbers(2, 3);
        }

        private static void MultiplyNumbers(int v1, int v2)
        {
            var product = v1 * v2;
            Console.WriteLine($"Product: {product}");
        }
    }
}
