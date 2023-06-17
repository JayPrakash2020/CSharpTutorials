using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Polymorphism
{
    public class Car
    {
        public string color = "White";
        public void showColor()
        {
            Console.WriteLine("Base color is "+color);
        }
    }
    public class BaseClass : Car
    {
        string color = "Blue";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
            base.showColor();
        }
    }
}
