﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ControlStatement
{
    public class SwitchCase
    {
        private int num1, num2, res, choice;

        public void SimpleCalculator()
        {
            Console.WriteLine("Enter two number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter your choice");
            Console.WriteLine("1. For Addition");
            Console.WriteLine("2. For Subtraction");
            Console.WriteLine("3. For Multiplication");
            Console.WriteLine("4. For Division");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine("Sum of two number is " + res);
                    break;
                case 2:
                    res = num1 - num2;
                    Console.WriteLine("Subtraction of two number is " + res);
                    break;
                case 3:
                    res = num1 * num2;
                    Console.WriteLine("Multiplication of two number is " + res);
                    break;
                case 4:
                    res = num1 / num2;
                    Console.WriteLine("Division of two number is " + res);
                    break;
                default: 
                    Console.WriteLine("Wrong Chocie");
                    break;

            }

        }
    }
}
