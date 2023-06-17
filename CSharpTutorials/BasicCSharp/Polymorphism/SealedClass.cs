using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Polymorphism
{
     public class SealedClass
    {
         public int a = 5;
         public void showColor()
        {
            Console.WriteLine("Base color is " );
        }
    }
    public class BaseClass1 : SealedClass
    {
        
        public void showColor1()
        {
             base.a = 15;
            Console.WriteLine("Hello World");
        }
    }
}
