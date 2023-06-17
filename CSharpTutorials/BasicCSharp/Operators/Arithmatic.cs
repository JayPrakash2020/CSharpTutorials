using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Operators
{
    public class Arithmatic
    {
        private static int num1, num2, res;
        public void Addition()
        {
            Console.WriteLine("Enter two numbers");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            res=num1 + num2;

            Console.WriteLine("Sum of two number is {0}", res);//            Console.WriteLine("Sum of two number is "+ res);
        }
        public static void Subtraction()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 - num2;

            Console.WriteLine("Subtraction of two number is {0}", res);//            Console.WriteLine("Sum of two number is "+ res);
        }
    }
}
