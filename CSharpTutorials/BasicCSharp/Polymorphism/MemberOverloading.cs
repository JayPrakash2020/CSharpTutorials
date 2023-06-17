using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Polymorphism
{
    public class MemberOverloading
    {
        int n1, n2, res;
        public void Sum(int num1, int num2)
        {
            n1 = num1;
            n2 = num2;
            res=n1 + n2;
            Console.WriteLine("Sum of two number is " + res);
        }

        public void Sum(double num1, double num2)
        {
            var result = num1 + num2;
            
            Console.WriteLine("Sum of two number is " + result);
        }
    }
}
