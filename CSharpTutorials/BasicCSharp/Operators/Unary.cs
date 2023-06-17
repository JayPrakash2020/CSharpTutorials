using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Operators
{
    public class Unary
    {
        private int num=18;

        public void Incremental()
        {
            Console.WriteLine("Orignal Number is " + (num));//18
            Console.WriteLine("Value after Post Increment " + (num++));//18 -> 19
            Console.WriteLine("Value after Pre Increment " + (++num));// 19+1=20
        }
    }
}
