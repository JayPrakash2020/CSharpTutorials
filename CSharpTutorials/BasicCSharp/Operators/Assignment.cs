using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Operators
{
    public class Assignment
    {
        private int num1, num2;

        public void AssignmentOperator()
        {
            num1 = 65;
            Console.WriteLine(num1);
            num2 = num1;
            Console.WriteLine(num2);
        }
        public void Assignment_Addtion()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num1 += num2;// num1=num1+num2

            Console.WriteLine("Sum of two number is {0}", num1);// 
        }
    }
}
