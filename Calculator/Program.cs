﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char repeat = 'Y';
            while (repeat == 'Y')
            {
                Console.Write("Write an expression: ");
                string expression = Console.ReadLine();
                expression = expression.Replace(".", ",");
                Console.WriteLine(expression);
                String[] numbers = expression.Split('+', '-', '*', '/');
                double a = Convert.ToDouble(numbers[0]);
                double b = Convert.ToDouble(numbers[1]);
                if (expression.Contains("+")) Console.WriteLine($"{a} + {b} = {a + b}");
                else if (expression.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
                else if (expression.Contains("*")) Console.WriteLine($"{a} * {b} = {a * b}");
                else if (expression.Contains("/")) Console.WriteLine($"{a} / {b} = {a / b}");
                Console.Write("Do u wanna to continue working? (Y/N): ");
                repeat = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
