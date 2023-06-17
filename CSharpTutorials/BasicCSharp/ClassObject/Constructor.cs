using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ClassObject
{
    public class Constructor
    {
        public int num1,num2;
        public static float roi = 8.8f;
        public Constructor()
        {
            Console.WriteLine("Constructor is Running");
        }
        public Constructor(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            Console.WriteLine("Numbers are  "+num1+"  "+num2 +"  "+roi);
        }
        ~Constructor()
        {
            Console.WriteLine("Destructor is Executing");
        }
    }
}
