using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Function
{
    public class FunctionAll
    {
        private int num1, num2;

        public void Sum()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num1 += num2;

            Console.WriteLine("Sum of two number is {0}", num1);//    
        }
        public void Sum(int n1,int n2)
        {
            num1 = n1;
            num2 = n2;
            num1 += num2;

            Console.WriteLine("Sum of two number is {0}", num1);//    
        }

        public int Add()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num1 += num2;
            return num1;
        }

        public int Add(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
           
            return num1+num2;
        }
    }
}
